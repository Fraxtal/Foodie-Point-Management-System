using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Manager
{
    public partial class ManagerDashboard : Form
    {
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
    }
}
