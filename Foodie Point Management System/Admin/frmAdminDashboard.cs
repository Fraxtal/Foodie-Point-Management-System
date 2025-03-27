using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Admin
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void linklblUserManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminUserManagement UserManagement = new frmAdminUserManagement();
            UserManagement.Show();
            this.Hide();
        }

        private void linklblSalesReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminSalesReport SalesReport = new frmAdminSalesReport();
            SalesReport.Show();
            this.Hide();
        }

        private void linklblViewFeeback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminFeedback Feedback = new frmAdminFeedback();
            Feedback.Show();
            this.Hide();
        }

        private void linklblAdminProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmAdminUserManagement UserManagement = new frmAdminUserManagement();
            UserManagement.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            frmAdminFeedback Feedback = new frmAdminFeedback();
            Feedback.Show();
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            frmAdminSalesReport SalesReport = new frmAdminSalesReport();
            SalesReport.Show();
            this.Hide();
        }
    }
}
