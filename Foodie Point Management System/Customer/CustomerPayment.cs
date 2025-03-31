using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodie_Point_Management_System.Manager;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerPayment : Form
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
        public CustomerPayment(Customer s)
        {
            InitializeComponent();
            this.session= s;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            string msg = session.PaymentProcess(session.PaymentTotal(), "Cash");
            if (msg == "Payment Successful!" || msg == "Due to having none in your total, thus you are immediately transfered to your main dashboard!")
            {
                MessageBox.Show(msg, "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerDashboard cDash = new CustomerDashboard(session);
                cDash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(msg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCCard_Click(object sender, EventArgs e)
        {
            string msg = session.PaymentProcess(session.PaymentTotal(), "Cash");
            if (msg == "Payment Successful!")
            {
                MessageBox.Show(msg, "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerDashboard cDash = new CustomerDashboard(session);
                cDash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(msg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            txtTotal.Text = session.PaymentTotal().ToString();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
