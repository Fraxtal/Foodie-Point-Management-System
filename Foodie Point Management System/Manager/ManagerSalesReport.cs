using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Manager
{
    public partial class ManagerSalesReport : Form
    {
        EmManager session = new EmManager();
        public ManagerSalesReport()
        {
            InitializeComponent();
            pnlNav.Height = btnSalesReportD.Height;
            pnlNav.Top = btnSalesReportD.Top;
            pnlNav.Left = btnSalesReportD.Left;
        }

        private void frmAdminSalesReport_Load(object sender, EventArgs e)
        {
            rbMonthly.Checked = true;
           
            cbYear.Items.Add(2023);
            cbYear.Items.Add(2024);
            cbYear.Items.Add(2025);
            cbYear.Items.Add("All Years");
            cbYear.SelectedItem = "All Years";

            LoadReport();
        }

        private void rbPaymentMethod_CheckedChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonthly.Checked) LoadReport();
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmployee.Checked) LoadReport();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            if (cbYear.SelectedItem == null) return;

            string selectedYear = cbYear.SelectedItem.ToString();
            string category = "";

            if (rbMonthly.Checked) category = "Month";
            else if (rbEmployee.Checked) category = "Employee";
            else if (rbPaymentMethod.Checked) category = "PaymentMethod";

            srdw.DataSource = session.LoadSalesReport(selectedYear, category);

        }

        private void btnMenuD_Click(object sender, EventArgs e)
        {
            ManagerFoodMenu managerMenu = new ManagerFoodMenu();
            managerMenu.Show();
            this.Hide();
            pnlNav.Height = btnMenuD.Height;
            pnlNav.Top = btnMenuD.Top;
            pnlNav.Left = btnMenuD.Left;
        }

        private void btnHallsD_Click(object sender, EventArgs e)
        {
            ManagerHall listOfHalls = new ManagerHall();
            listOfHalls.Show();
            this.Hide();
            pnlNav.Height = btnHallsD.Height;
            pnlNav.Top = btnHallsD.Top;
            pnlNav.Left = btnHallsD.Left;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //frmEmployeeProfileSettings settings = new frmEmployeeProfileSettings();
            //settings.Show();
            //this.Hide();
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            ManagerDashboard dash = new ManagerDashboard();
            dash.Show();
            this.Hide();
        }

        private void btnReserD_Click(object sender, EventArgs e)
        {
            ManagerReservationsReport reservation = new ManagerReservationsReport();
            reservation.Show();
            this.Hide();
            pnlNav.Height = btnReserD.Height;
            pnlNav.Top = btnReserD.Top;
            pnlNav.Left = btnReserD.Left;
        }

        private void btnSalesReportD_Click(object sender, EventArgs e)
        {
            ManagerSalesReport sales = new ManagerSalesReport();
            sales.Show();
            this.Hide();
            pnlNav.Height = btnSalesReportD.Height;
            pnlNav.Top = btnSalesReportD.Top;
            pnlNav.Left = btnSalesReportD.Left;
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
