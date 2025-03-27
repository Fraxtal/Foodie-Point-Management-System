using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerDashboard: Form
    {
        Customer session;
        public CustomerDashboard(Customer s)
        {
            InitializeComponent();
            this.session = s;
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerLogin login = new CustomerLogin();
            MessageBox.Show("You have successfully logged out!", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            login.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            CustomerFeedback feedback = new CustomerFeedback(session);
            feedback.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            CustomerReservation reservation = new CustomerReservation(session);
            reservation.Show();
            this.Hide();
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

        private void llProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerProfile cProfile = new CustomerProfile(session);
            cProfile.Show();
            this.Hide();
        }
    }
}
