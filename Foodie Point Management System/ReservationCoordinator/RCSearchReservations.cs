using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodie_Point_Management_System.Employee_Login;

namespace Foodie_Point_Management_System.ReservationCoordinator
{
    public partial class SearchReservations : Form
    {
        ReservationCoord rc;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );
        public SearchReservations(ReservationCoord s)
        {
            this.rc = s;
            InitializeComponent();
            pnlNav.Height = btnSearchReser.Height;
            pnlNav.Top = btnSearchReser.Top;
            pnlNav.Left = btnSearchReser.Left;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void DGVResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchReservations_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cmbStatus.Text) || string.IsNullOrEmpty(txtHall.Text))
            {
                MessageBox.Show("Please fill in all blanks.");
                return;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDash_Click(object sender, EventArgs e)
        {
            ReservationCoordinatorDashboard dashboard = new ReservationCoordinatorDashboard(rc);
            dashboard.Show();
            this.Hide();
        }

        private void btnSearchReser_Click(object sender, EventArgs e)
        {
            SearchReservations searchReservations = new SearchReservations(rc);
            searchReservations.Show();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            CustomerRequest customerRequest = new CustomerRequest(rc);
            customerRequest.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmEmployeeProfileSettings rcProfile = new frmEmployeeProfileSettings(rc);
            rcProfile.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EmployeeLogin pageL = new EmployeeLogin();
                pageL.Show();
                this.Hide();
            }
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnReserManage_Click(object sender, EventArgs e)
        {
            ManageReservations manageReservation = new ManageReservations(rc);
            manageReservation.Show();
            this.Hide();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }
    }
}
