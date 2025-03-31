using Foodie_Point_Management_System.ReservationCoordinator;
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

namespace Foodie_Point_Management_System.Admin
{
    public partial class frmAdminDashboard : Form
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );
        emAdmin session;

        public frmAdminDashboard(emAdmin s)
        {
            InitializeComponent();
            this.session = s;
            pnlNav.Height = btnDash.Height;
            pnlNav.Top = btnDash.Top;
            pnlNav.Left = btnDash.Left;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmAdminUserManagement UserManagement = new frmAdminUserManagement(session);
            UserManagement.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            frmAdminFeedback Feedback = new frmAdminFeedback(session);
            Feedback.Show();
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            frmAdminSalesReport SalesReport = new frmAdminSalesReport(session);
            SalesReport.Show();
            this.Hide();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            frmAdminDashboard Dashboard = new frmAdminDashboard(session);
            Dashboard.Show();
            this.Hide();
            pnlNav.Height = btnDash.Height;
            pnlNav.Top = btnDash.Top;
            pnlNav.Left = btnDash.Left;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmAdminUserManagement UserManagement = new frmAdminUserManagement(session);
            UserManagement.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmAdminSalesReport SalesReport = new frmAdminSalesReport(session);
            SalesReport.Show();
            this.Hide();
        }

        private void btnFeedbackD_Click(object sender, EventArgs e)
        {
            frmAdminFeedback Feedback = new frmAdminFeedback(session);
            Feedback.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
