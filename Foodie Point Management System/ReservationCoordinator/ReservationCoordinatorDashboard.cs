using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Foodie_Point_Management_System.Employee_Login;

namespace Foodie_Point_Management_System.ReservationCoordinator
{
    public partial class ReservationCoordinatorDashboard : Form
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

        public ReservationCoordinatorDashboard(ReservationCoord s)
        {
            InitializeComponent();
            this.rc = s;
            pnlNav.Height = btnDash.Height;
            pnlNav.Top = btnDash.Top;
            pnlNav.Left = btnDash.Left;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void lblupcoming_Click(object sender, EventArgs e)
        {

        }

        private void ReservationCoordinatorDashboard_Load(object sender, EventArgs e)
        {
            radAll.Checked = true;
        }

        private Dictionary<DateTime, string> reservationStatus = new Dictionary<DateTime, string>();

        private void upcoming_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pending_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnksettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void radconfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (radconfirm.Checked)
            {
                upcoming.DataSource = rc.ReservationTable("SELECT * FROM Reservations WHERE ReservationStatus = 'Confirmed'");
            }
            
        }

        private void radpending_CheckedChanged(object sender, EventArgs e)
        {
            if (radpending.Checked)
            {
                upcoming.DataSource = rc.ReservationTable("SELECT * FROM Reservations WHERE ReservationStatus = 'Pending'");
            }
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radAll.Checked)
            {
                upcoming.DataSource = rc.ReservationTable("SELECT * FROM Reservations");
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            ReservationCoordinatorDashboard dashboard = new ReservationCoordinatorDashboard(rc);
            dashboard.Show();
            this.Hide();
        }

        private void btnSearchReser_Click(object sender, EventArgs e)
        {
            SearchReservations searchReservations = new SearchReservations();
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

        private void lblpending_Click(object sender, EventArgs e)
        {

        }
    }
}
