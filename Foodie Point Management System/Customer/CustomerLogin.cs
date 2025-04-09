using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Foodie_Point_Management_System.Employee_Login;
using System.Runtime.InteropServices;

namespace Foodie_Point_Management_System.Customer
{

    public partial class CustomerLogin: Form
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
        public CustomerLogin()
        {
            InitializeComponent();
            session = new Customer();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void rbUsername_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsername.Checked)
            {
                lblInputs.Text = "Username:";
                txtInputs.Visible = true;
                txtPassword.Visible = true;
                lblPass.Enabled = true;
            }
        }

        private void rbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmail.Checked)
            {
                lblInputs.Text = "Email:";
                txtInputs.Visible = true;
                txtPassword.Visible = true;
                lblPass.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputs.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill all blank fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string query;
            string parameterName;
            if (lblInputs.Text == "Username:")
            {
                query = "SELECT * FROM Customer WHERE Username = @username AND Password = @password";
                parameterName = "@username";
            }
            else if (lblInputs.Text == "Email:")
            {
                query = "SELECT * FROM Customer WHERE Email = @email AND Password = @password";
                parameterName = "@email";
            }
            else
            {
                MessageBox.Show("Please select a valid login method!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string msg = session.Auth_Login(query, parameterName, txtInputs.Text, txtPassword.Text);

            if (msg == "Login Successful!"){
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CustomerRegistration cReg = new CustomerRegistration();
            cReg.Show();
            this.Hide();
        }

        private void cbSPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbSPassword.Checked ? '\0' : '*';
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLogin employeeLogin = new EmployeeLogin();
            employeeLogin.Show();
            this.Hide();
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
