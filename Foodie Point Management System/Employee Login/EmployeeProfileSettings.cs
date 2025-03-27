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

namespace Foodie_Point_Management_System.Employee_Login
{
    public partial class frmEmployeeProfileSettings : Form
    {
        EmChef sessionPV;

        public frmEmployeeProfileSettings(EmChef sc)
        {
            InitializeComponent();
            this.sessionPV = sc;
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
            frmChefDashboard pageD = new frmChefDashboard(sessionPV);
            pageD.Show();
            this.Close();
        }

        
    }
}
