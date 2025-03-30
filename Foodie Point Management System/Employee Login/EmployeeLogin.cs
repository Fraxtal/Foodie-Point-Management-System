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
using static System.Collections.Specialized.BitVector32;
using Foodie_Point_Management_System.Chef;
using Foodie_Point_Management_System.Admin;
using Foodie_Point_Management_System.Manager;
using Foodie_Point_Management_System.ReservationCoordinator;

namespace Foodie_Point_Management_System.Employee_Login
{
    public partial class EmployeeLogin : Form
    {
        Employee sessionE = new Employee(0, "", "", "");
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void rbUsername_CheckedChanged(object sender, EventArgs e)
        {
            lblInputs.Text = "Username:";
            txtInputs.Visible = true;
            txtPassword.Visible = true;
            lblPass.Enabled = true;
        }

        private void rbEmail_CheckedChanged(object sender, EventArgs e)
        {
            lblInputs.Text = "Email:";
            txtInputs.Visible = true;
            txtPassword.Visible = true;
            lblPass.Enabled = true;
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
                query = "SELECT * FROM Employee WHERE Username = @username AND Password = @password";
                parameterName = "@username";
            }
            else if (lblInputs.Text == "Email:")
            {
                query = "SELECT * FROM Employee WHERE Email = @email AND Password = @password";
                parameterName = "@email";
            }
            else
            {
                MessageBox.Show("Please select a valid login method!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string msg = sessionE.EmpLogin(query, parameterName, txtInputs.Text, txtPassword.Text);

            if (msg == "Login Successful!")
            {
                string roleC = sessionE.Role;
                switch (roleC)
                {
                    case "Admin":
                        {
                            emAdmin sessionChef = new emAdmin(sessionE.Id, sessionE.Username, sessionE.Fullname, sessionE.Role);
                            MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminDashboard aDash = new AdminDashboard(sessionE);
                            aDash.Show();
                            this.Hide();
                            break;
                        }

                    case "Chef":
                        {
                            EmChef sessionChef = new EmChef(sessionE.Id, sessionE.Username, sessionE.Fullname, sessionE.Role);
                            MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmChefDashboard cfDash = new frmChefDashboard(sessionChef);
                            cfDash.Show();
                            this.Hide();
                            break;
                        }

                    case "Manager":
                        {
                            EmManager sessionChef = new EmManager(sessionE.Id, sessionE.Username, sessionE.Fullname, sessionE.Role);
                            MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagerDashboard mDash = new ManagerDashboard(sessionE);
                            mDash.Show();
                            this.Hide();
                            break;
                        }

                    case "Reservation Coordinator":
                        {
                            ReservationCoord session = new ReservationCoord(sessionE.Id, sessionE.Username, sessionE.Fullname, sessionE.Role);
                            MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReservationCoordinatorDashboard rDash = new ReservationCoordinatorDashboard(sessionE);
                            rDash.Show();
                            this.Hide();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show(msg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
