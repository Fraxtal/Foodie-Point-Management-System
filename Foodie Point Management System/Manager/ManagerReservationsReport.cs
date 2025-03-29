using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Manager
{
    public partial class ManagerReservationsReport : Form
    {
        EmManager session = new EmManager();

        string query = @"
                       SELECT 
                            YEAR(r.DateTime) AS Year,
                            MONTH(r.DateTime) AS Month,
                            h.PartyType,
                            COUNT(r.ReservationID) AS ReservationCount,
                            SUM(r.Pax) AS TotalPax
                       FROM 
                            Reservations r
                       JOIN 
                            Hall h ON r.HallID = h.HallID
                       GROUP BY 
                            YEAR(r.DateTime),
                            MONTH(r.DateTime),
                            h.PartyType
                       ORDER BY 
                            Year, Month, h.PartyType;
                       ";

        public ManagerReservationsReport()
        {
            InitializeComponent();
        }

        private void ManagerReservationsReport_Load(object sender, EventArgs e)
        {
            dataGridViewReservations.DataSource = session.LoadTable(query);
        }

        private void printReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Times New Roman", 20, FontStyle.Bold);
            Font subHeaderFont = new Font("Times New Roman", 17, FontStyle.Bold);
            Font font = new Font("Times New Roman", 10);
            Brush brush = Brushes.Black;

            float pageWidth = e.PageBounds.Width;

            float x = 70;
            float y = 50;
            float lineHeight = font.GetHeight(g) + 4;
            float columnWidth = 140;

            g.DrawString("Foodie Point Management System", headerFont, brush, (pageWidth - g.MeasureString("Foodie Point Management System", headerFont).Width) / 2, y);
            y += headerFont.GetHeight(g) + 20;

            g.DrawString("Reservation Report", headerFont, brush, x, y);
            y += subHeaderFont.GetHeight(g) + 20;

            // Print column headers
            g.DrawString("Reservation Year", font, brush, x, y);
            g.DrawString("Reservation Month", font, brush, x + columnWidth, y);
            g.DrawString("Party Type", font, brush, x + 2 * columnWidth, y);
            g.DrawString("Reservation Count", font, brush, x + 3 * columnWidth, y);
            g.DrawString("Total Pax", font, brush, x + 4 * columnWidth, y);

            y += lineHeight;

            // Print rows from DataTable
            foreach (DataRow row in dataGridViewReservations.Rows)
            {
                g.DrawString(row["ReservationYear"].ToString(), font, brush, x, y);
                g.DrawString(row["ReservationMonth"].ToString(), font, brush, x + columnWidth, y);
                g.DrawString(row["PartyType"].ToString(), font, brush, x + 2 * columnWidth, y);
                g.DrawString(row["ReservationCount"].ToString(), font, brush, x + 3 * columnWidth, y);
                g.DrawString(row["TotalPax"].ToString(), font, brush, x + 4 * columnWidth, y);

                y += lineHeight;

                // Check if the content exceeds the page length
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.Show();
            this.Hide();
        }
    }
}
