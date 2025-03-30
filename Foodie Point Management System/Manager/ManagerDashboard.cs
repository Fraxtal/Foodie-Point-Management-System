using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodie_Point_Management_System.Employee_Login;
using System.Runtime.InteropServices;

namespace Foodie_Point_Management_System.Manager
{
    public partial class ManagerDashboard : Form
    {
<<<<<<< HEAD
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
        public ManagerDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDash.Height;
            pnlNav.Top = btnDash.Top;
            pnlNav.Left = btnDash.Left;
=======
        EmManager session;
        public ManagerDashboard(EmManager s)
        {
            InitializeComponent();
            this.session = s;
        }

        private void llblmenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerFoodMenu managerMenu = new ManagerFoodMenu(session);
            managerMenu.Show();
            this.Hide();
        }

        private void llblhalls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerHall listOfHalls = new ManagerHall(session);
            listOfHalls.Show();
            this.Hide();
        }

        private void llblreports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerReports reports = new ManagerReports(session);
            reports.Show();
            this.Hide();
        }

        private void llblsettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                    }

        private void lblsalesamount_Click(object sender, EventArgs e)
        {
            
>>>>>>> 66a1612653e6c948b04dcc409a25480793013a04
        }

        private void llblReservations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerReservationsReport reservations = new ManagerReservationsReport(session);
            reservations.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ManagerFoodMenu menu = new ManagerFoodMenu(session);
            menu.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ManagerSalesReport sales = new ManagerSalesReport();
            sales.Show();
            this.Hide();
        }

        private void btnHalls_Click(object sender, EventArgs e)
        {
            ManagerHall halls = new ManagerHall(session);
            halls.Show();
            this.Hide();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            ManagerReservationsReport reservations = new ManagerReservationsReport(session);
            reservations.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
    }
}
