using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerFeedback: Form
    {
        Customer session;

        public CustomerFeedback(Customer s)
        {
            InitializeComponent();
            this.session = s;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomerDashboard cDash = new CustomerDashboard(session);
            cDash.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbRating.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rating to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string msg = session.SubmitFeedback(int.Parse(cbRating.Text), txtContent.Text != "" ? txtContent.Text : null);

                if (msg == "Feedback Successfully Submitted!")
                {
                    MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustomerDashboard cDash = new CustomerDashboard(session);
                    cDash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
