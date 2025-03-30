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
    public partial class ManagerReports : Form
    {
        EmManager manager;

        public ManagerReports(EmManager s)
        {
            InitializeComponent();
            this.manager = s;
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
        }

        private void btnreservations_Click(object sender, EventArgs e)
        {
            ManagerReservationsReport reservationsReport = new ManagerReservationsReport(manager);
            reservationsReport.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ManagerDashboard dashboard = new ManagerDashboard(manager);
            dashboard.Show();
            this.Close();
        }
    }
}
