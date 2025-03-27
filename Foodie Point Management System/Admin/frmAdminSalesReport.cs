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

namespace Foodie_Point_Management_System.Admin
{
    public partial class frmAdminSalesReport : Form
    {
        emAdmin session = new emAdmin();
        public frmAdminSalesReport()
        {
            InitializeComponent();
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
    }
}
