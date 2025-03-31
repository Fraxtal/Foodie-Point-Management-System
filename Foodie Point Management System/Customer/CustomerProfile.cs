using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerProfile: Form
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
        public CustomerProfile(Customer s)
        {
            session = s;
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
        }

        private void btnUProfile_Click(object sender, EventArgs e)
        {
            List<string> info = new List<string> { txtUsername.Text.Trim(), txtFName.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim() };
            string msg = session.UpdateCustomerInfo(info);
            if (msg == "Your account information has been updated successfully!" || msg == "No changes were made.")
            {
                MessageBox.Show(msg, "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerDashboard cDash = new CustomerDashboard(session);
            }
            else if (msg == "")
            {
                MessageBox.Show(msg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            List<string> info = session.LoadInfo();

            txtUsername.Text = info[0];
            txtFName.Text = info[1];
            txtEmail.Text = info[2];
            txtPassword.Text = info[3];
            lblDateReg.Text = info[4];
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
