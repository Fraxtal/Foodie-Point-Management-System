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
using System.Runtime.InteropServices;

namespace Foodie_Point_Management_System.Chef
{
    public partial class frmChefDashboard : Form
    {
        EmChef sessionCD;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );
        public frmChefDashboard(EmChef sc)
        {
            InitializeComponent();
            this.sessionCD = sc;
            pnlNav.Height = btnDash.Height;
            pnlNav.Top = btnDash.Top;
            pnlNav.Left = btnDash.Left;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
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
       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Logout and return to login page?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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

        private void btnDash_Click(object sender, EventArgs e)
        {
            frmChefDashboard dashboard = new frmChefDashboard(sessionCD);
            dashboard.Show();
            this.Hide();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmChefViewOrders pageVO = new frmChefViewOrders(sessionCD);
            pageVO.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmChefInventory pageI = new frmChefInventory(sessionCD);
            pageI.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmEmployeeProfileSettings pagePS = new frmEmployeeProfileSettings(sessionCD);
            pagePS.Show();
            this.Hide();
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
