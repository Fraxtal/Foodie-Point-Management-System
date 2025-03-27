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

namespace Foodie_Point_Management_System.Manager
{
    public partial class ManagerReservationsReport : Form
    {
        EmManager session = new EmManager();

        public ManagerReservationsReport()
        {
            InitializeComponent();
        }

        private void ManagerReservationsReport_Load(object sender, EventArgs e)
        {
            dataGridViewReservations.DataSource = session.LoadReservationReport();
        }

        private void btnLoadReports_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
