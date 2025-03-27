using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodie_Point_Management_System.Employee_Login;

namespace Foodie_Point_Management_System.Chef
{
    public partial class frmChefDashboard : Form
    {
        EmChef sessionCD;
        public frmChefDashboard(EmChef sc)
        {
            InitializeComponent();
            this.sessionCD = sc;
        }
        private void lblUnfulfilled_Click(object sender, EventArgs e)
        {
            frmChefViewOrders pageVO = new frmChefViewOrders(sessionCD);
            pageVO.Show();
            this.Hide();
        }

        private void lblFulfilled_Click(object sender, EventArgs e)
        {
            frmChefViewOrders pageVO = new frmChefViewOrders(sessionCD);
            pageVO.Show();
            this.Hide();

        }

        private void lblUnfulOrders_Click(object sender, EventArgs e)
        {
            frmChefViewOrders pageVO = new frmChefViewOrders(sessionCD);
            pageVO.Show();
            this.Hide();
        }

        private void lblFulOrders_Click(object sender, EventArgs e)
        {
            frmChefViewOrders pageVO = new frmChefViewOrders(sessionCD);
            pageVO.Show();
            this.Hide();
        }
        private void linklblViewOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChefViewOrders pageVO = new frmChefViewOrders(sessionCD);
            pageVO.Show();
            this.Hide();
        }

        private void linklblInventory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChefInventory pageI = new frmChefInventory(sessionCD);
            pageI.Show();
            this.Hide();
        }

        private void linklblProfSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeProfileSettings pagePS = new frmEmployeeProfileSettings(sessionCD);
            pagePS.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Logout and return to login page?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sessionCD = null;
                EmployeeLogin pageL = new EmployeeLogin();
                pageL.Show();
                this.Hide();
            }
        }

        private void frmChefDashboard_Load(object sender, EventArgs e)
        {
            List<string> dashorders = sessionCD.DashboardOrderNumbers();

            lblWelcome.Text = sessionCD.EmpWelcome(sessionCD.Username);

            dgvDashInven.DataSource = sessionCD.InventoryDisplay();

            lblUnfulOrders.Text = dashorders[0];

            lblFulOrders.Text = dashorders[1];
        }
    }
}
