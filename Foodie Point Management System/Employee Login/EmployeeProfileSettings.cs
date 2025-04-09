using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodie_Point_Management_System.Chef;
using System.Runtime.InteropServices;
using Foodie_Point_Management_System.Admin;
using Foodie_Point_Management_System.Manager;
using Foodie_Point_Management_System.ReservationCoordinator;

namespace Foodie_Point_Management_System.Employee_Login
{
    public partial class frmEmployeeProfileSettings : Form
    {
        Employee sessionPV;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
            );

        public frmEmployeeProfileSettings(Employee se)
        {
            InitializeComponent();
            this.sessionPV = se;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void frmChefProfileSettings_Load(object sender, EventArgs e)
        {
            List<string> einfo = sessionPV.EmployeeLoad();

            txtbxUsername.Text = einfo[0];
            txtbxFullname.Text = einfo[1];
            txtbxEmail.Text = einfo[2];
            txtbxPassword.Text = einfo[3];
            lblRoleDisplay.Text = einfo[4];

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> einfo = new List<string> { txtbxUsername.Text.Trim(), txtbxFullname.Text.Trim(), txtbxEmail.Text.Trim(), txtbxPassword.Text.Trim() };

            if (string.IsNullOrEmpty(txtbxUsername.Text) || string.IsNullOrEmpty(txtbxFullname.Text) || string.IsNullOrEmpty(txtbxEmail.Text) || string.IsNullOrEmpty(txtbxPassword.Text))
            {
                MessageBox.Show("Please fill in all empty fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Save changes?", "Update Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sessionPV.EmployeeProfileUpdate(einfo);

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string role = sessionPV.Role;

            switch (role)
            {
                case "Admin":
                    {
                        frmAdminDashboard aDash = new frmAdminDashboard((emAdmin)sessionPV);
                        aDash.Show();
                        this.Hide();
                        break;
                    }

                case "Chef":
                    {
                        frmChefDashboard cfDash = new frmChefDashboard((EmChef)sessionPV);
                        cfDash.Show();
                        this.Hide();
                        break;
                    }

                case "Manager":
                    {
                        ManagerDashboard mDash = new ManagerDashboard((EmManager)sessionPV);
                        mDash.Show();
                        this.Hide();
                        break;
                    }

                case "Reservation Coordinator":
                    {
                        ReservationCoordinatorDashboard rDash = new ReservationCoordinatorDashboard((ReservationCoord)sessionPV);
                        rDash.Show();
                        this.Hide();
                        break;
                    }
            }
        }

        
    }
}
