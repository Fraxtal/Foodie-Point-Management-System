using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerDashboard: Form
    {
        Customer session;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
            );
        public CustomerDashboard(Customer s)
        {
            InitializeComponent();
            this.session = s;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDash.Height;
            pnlNav.Top = btnDash.Top;
            pnlNav.Left = btnDash.Left;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            CustomerFeedback feedback = new CustomerFeedback(session);
            feedback.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            CustomerReservation reservation = new CustomerReservation(session);
            reservation.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            CustomerOrder ordermenu = new CustomerOrder(session);
            ordermenu.Show();
            this.Hide();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard(session);
            dashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOrderD_Click(object sender, EventArgs e)
        {
            CustomerOrder ordermenu = new CustomerOrder(session);
            ordermenu.Show();
            this.Hide();
        }

        private void btnReserD_Click(object sender, EventArgs e)
        {
            CustomerReservation reservation = new CustomerReservation(session);
            reservation.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile cProfile = new CustomerProfile(session);
            cProfile.Show();
            this.Hide();
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
