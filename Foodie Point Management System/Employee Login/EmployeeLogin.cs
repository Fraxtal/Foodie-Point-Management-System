﻿using System;
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
using System.Runtime.InteropServices;

namespace Foodie_Point_Management_System.Employee_Login
{
    public partial class EmployeeLogin : Form
    {
        Employee sessionE = new Employee(0, "", "", "");
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
            );
        public EmployeeLogin()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
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
                            emAdmin s = new emAdmin(sessionE.Id, sessionE.Username, sessionE.Fullname, sessionE.Role);
                            MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmAdminDashboard aDash = new frmAdminDashboard(s);
                            aDash.Show();
                            this.Hide();
                            break;
                        }

                    case "Chef":
                        {
                            EmChef s = new EmChef(sessionE.Id, sessionE.Username, sessionE.Fullname, sessionE.Role);
                            MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmChefDashboard cfDash = new frmChefDashboard(s);
                            cfDash.Show();
                            this.Hide();
                            break;
                        }

                    case "Manager":
                        {
                            EmManager s = new EmManager(sessionE.Id, sessionE.Username, sessionE.Fullname, sessionE.Role);
                            MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagerDashboard mDash = new ManagerDashboard(s);
                            mDash.Show();
                            this.Hide();
                            break;
                        }

                    case "Reservation Coordinator":
                        {
                            ReservationCoord s = new ReservationCoord(sessionE.Id, sessionE.Username, sessionE.Fullname, sessionE.Role);
                            MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReservationCoordinatorDashboard rDash = new ReservationCoordinatorDashboard(s);
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

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblInputs_Click(object sender, EventArgs e)
        {

        }
    }
}
