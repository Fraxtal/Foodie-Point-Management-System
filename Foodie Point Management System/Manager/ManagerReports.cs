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
        public ManagerReports()
        {
            InitializeComponent();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
        }

        private void btnreservations_Click(object sender, EventArgs e)
        {
            ManagerReservationsReport reservationsReport = new ManagerReservationsReport();
            reservationsReport.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ManagerDashboard dashboard = new ManagerDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
