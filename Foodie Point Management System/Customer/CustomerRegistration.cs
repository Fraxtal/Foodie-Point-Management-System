using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerRegistration: Form
    {
        Customer session = new Customer();

        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Login_Click(object sender, EventArgs e)
        {
            CustomerLogin login = new CustomerLogin();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtCfmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password does not match!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!session.IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please input a valid email!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string msg = session.Auth_Register(txtUsername.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim());

                if (msg == "Registered Successfully!")
                {
                    MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustomerLogin login = new CustomerLogin();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbSPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbSPassword.Checked ? '\0' : '*';
            txtCfmPassword.PasswordChar = cbSPassword.Checked ? '\0' : '*';
        }
    }
}