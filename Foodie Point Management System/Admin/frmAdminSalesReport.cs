using Foodie_Point_Management_System.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Admin
{
    public partial class frmAdminSalesReport : Form
    {
        emAdmin session;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );
        public frmAdminSalesReport(emAdmin s)
        {
            InitializeComponent();
            this.session = s;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnSales.Height;
            pnlNav.Top = btnSales.Top;
            pnlNav.Left = btnSales.Left;
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreview.Document = printReport;
            printPreview.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printReport;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printReport.Print();
            }
        }

        private void printReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Times New Roman", 20, FontStyle.Bold);
            Font subHeaderFont = new Font("Times New Roman", 17, FontStyle.Bold);
            Font font = new Font("Times New Roman", 13);
            Brush brush = Brushes.Black;

            float pageWidth = e.PageBounds.Width;

            float x = 70;
            float y = 50;
            float lineHeight = font.GetHeight(g) + 4;
            float columnWidth = 200;


            g.DrawString("Foodie Point Management System", headerFont, brush, (pageWidth - g.MeasureString("Foodie Point Management System", headerFont).Width) / 2, y);
            y += headerFont.GetHeight(g) + 20;

            g.DrawString("Sales Report", headerFont, brush, x, y);
            y += subHeaderFont.GetHeight(g) + 20;

            g.DrawString("----------------------------------------------------------------------------------------", subHeaderFont, brush, x, y);
            y += subHeaderFont.GetHeight(g) + 20;

            // Determine which columns to print based on the report category
            string category = ""; // You'll need to set this based on your report type

            if (rbMonthly.Checked) category = "Month";
            else if (rbEmployee.Checked) category = "Employee";
            else if (rbPaymentMethod.Checked) category = "PaymentMethod";

            // Print column headers based on category
            switch (category)
            {
                case "Month":
                    g.DrawString("Year", font, brush, x, y);
                    g.DrawString("Month", font, brush, x + columnWidth, y);
                    g.DrawString("Total Sales", font, brush, x + 2 * columnWidth, y);
                    break;

                case "Employee":
                    g.DrawString("Employee", font, brush, x, y);
                    g.DrawString("Total Sales", font, brush, x + columnWidth, y);
                    break;

                case "PaymentMethod":
                    g.DrawString("Payment Method", font, brush, x, y);
                    g.DrawString("Total Sales", font, brush, x + columnWidth, y);
                    break;

                default:
                    // Fallback for unknown categories
                    foreach (DataGridViewColumn column in srdw.Columns)
                    {
                        if (!column.Visible || column.IsDataBound) continue;
                        g.DrawString(column.HeaderText, font, brush, x + (columnWidth * column.Index), y);
                    }
                    break;
            }

            y += lineHeight;

            decimal totalSales = 0;

            // Print rows from DataTable
            foreach (DataGridViewRow dgvRow in srdw.Rows)
            {
                if (dgvRow.IsNewRow) continue;

                switch (category)
                {
                    case "Month":
                        g.DrawString(dgvRow.Cells["Year"].Value?.ToString(), font, brush, x, y);
                        g.DrawString(dgvRow.Cells["Month"].Value?.ToString(), font, brush, x + columnWidth, y);
                        g.DrawString(dgvRow.Cells["TotalSales"].Value?.ToString(), font, brush, x + 2 * columnWidth, y);
                        break;

                    case "Employee":
                        g.DrawString(dgvRow.Cells["Employee"].Value?.ToString(), font, brush, x, y);
                        g.DrawString(dgvRow.Cells["TotalSales"].Value?.ToString(), font, brush, x + columnWidth, y);
                        break;

                    case "PaymentMethod":
                        g.DrawString(dgvRow.Cells["Payment Method"].Value?.ToString(), font, brush, x, y);
                        g.DrawString(dgvRow.Cells["TotalSales"].Value?.ToString(), font, brush, x + columnWidth, y);
                        break;

                    default:
                        // Fallback for unknown categories
                        foreach (DataGridViewCell cell in dgvRow.Cells)
                        {
                            if (!cell.OwningColumn.Visible) continue;
                            g.DrawString(cell.Value?.ToString(), font, brush, x + (columnWidth * cell.ColumnIndex), y);
                        }
                        break;
                }
                if (decimal.TryParse(dgvRow.Cells["TotalSales"].Value?.ToString(), out decimal sales))
                {
                    totalSales += sales;
                }

                y += lineHeight;

                // Check for page overflow
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            g.DrawString("----------------------------------------------------------------------------------------", subHeaderFont, brush, x, y);
            y += subHeaderFont.GetHeight(g) + 20;

            if (category != "")
            {
                g.DrawString($"Total Sales: {totalSales:C}", font, brush, x, y);
                y += lineHeight;
            }


            e.HasMorePages = false;
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmAdminUserManagement UserManagement = new frmAdminUserManagement(session);
            UserManagement.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            frmAdminFeedback Feedback = new frmAdminFeedback(session);
            Feedback.Show();
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            frmAdminSalesReport SalesReport = new frmAdminSalesReport(session);
            SalesReport.Show();
            this.Hide();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            frmAdminDashboard Dashboard = new frmAdminDashboard(session);
            Dashboard.Show();
            this.Hide();

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmAdminUserManagement UserManagement = new frmAdminUserManagement(session);
            UserManagement.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmAdminSalesReport SalesReport = new frmAdminSalesReport(session);
            SalesReport.Show();
            this.Hide();
            pnlNav.Height = btnSales.Height;
            pnlNav.Top = btnSales.Top;
            pnlNav.Left = btnSales.Left;
        }

        private void btnFeedbackD_Click(object sender, EventArgs e)
        {
            frmAdminFeedback Feedback = new frmAdminFeedback(session);
            Feedback.Show();
            this.Hide();
            pnlNav.Height = btnFeedbackD.Height;
            pnlNav.Top = btnFeedbackD.Top;
            pnlNav.Left = btnFeedbackD.Left;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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
