using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerProfile: Form
    {
        Customer session;
        public CustomerProfile(Customer s)
        {
            session = s;
            InitializeComponent();
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
    }
}
