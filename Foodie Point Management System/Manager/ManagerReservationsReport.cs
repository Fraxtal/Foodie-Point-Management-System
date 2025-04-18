﻿using System;
using System.Collections;
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
using System.Runtime.InteropServices;
using Foodie_Point_Management_System.Employee_Login;

namespace Foodie_Point_Management_System.Manager
{
    public partial class ManagerReservationsReport : Form
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );
        EmManager session;

        string query = "SELECT YEAR(r.DateTime) AS Year, MONTH(r.DateTime) AS Month, h.PartyType, COUNT(r.ReservationID) AS ReservationCount, SUM(r.Pax) AS TotalPax FROM Reservations r JOIN Hall h ON r.HallID = h.HallID GROUP BY YEAR(r.DateTime), MONTH(r.DateTime), h.PartyType ORDER BY Year, Month, h.PartyType;";

        public ManagerReservationsReport(EmManager s)
        {
            InitializeComponent();
            this.session = s;
            pnlNav.Height = btnReserD.Height;
            pnlNav.Top = btnReserD.Top;
            pnlNav.Left = btnReserD.Left;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void ManagerReservationsReport_Load(object sender, EventArgs e)
        {
            dataGridViewReservations.DataSource = session.LoadTable(query);

            // Fill ComboBoxes based on data in database

            string partyTypeQuery = "SELECT DISTINCT PartyType FROM Hall";
            DataTable partyTypeData = session.LoadTable(partyTypeQuery);
            cbPType.Items.Clear();
            foreach (DataRow row in partyTypeData.Rows)
            {
                cbPType.Items.Add(row["PartyType"].ToString());
            }

            string yearQuery = "SELECT DISTINCT YEAR(DateTime) AS ReservationYear FROM Reservations ORDER BY ReservationYear";
            DataTable yearData = session.LoadTable(yearQuery);
            cbYear.Items.Clear();
            foreach (DataRow row in yearData.Rows)
            {
                cbYear.Items.Add(row["ReservationYear"].ToString());
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += printReport_PrintPage;

            pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewReservations.DataSource = session.ReservationFilterBox(cbPType,cbYear);
        }

        private void cbPType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewReservations.DataSource = session.ReservationFilterBox(cbPType, cbYear);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbPType.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            this.query = "SELECT YEAR(r.DateTime) AS Year, MONTH(r.DateTime) AS Month, h.PartyType, COUNT(r.ReservationID) AS ReservationCount, SUM(r.Pax) AS TotalPax FROM Reservations r JOIN Hall h ON r.HallID = h.HallID GROUP BY YEAR(r.DateTime), MONTH(r.DateTime), h.PartyType ORDER BY Year, Month, h.PartyType;";
            dataGridViewReservations.DataSource = session.LoadTable(query);

        }

        private void printReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Times New Roman", 20, FontStyle.Bold);
            Font subHeaderFont = new Font("Times New Roman", 17, FontStyle.Bold);
            Font font = new Font("Times New Roman", 13);
            Brush brush = Brushes.Black;

            float pageWidth = e.PageBounds.Width;

            int totalR = 0;
            int totalP = 0;

            float x = 70;
            float y = 50;
            float lineHeight = font.GetHeight(g) + 4;
            float columnWidth = 150;

            g.DrawString("Foodie Point Management System", headerFont, brush, (pageWidth - g.MeasureString("Foodie Point Management System", headerFont).Width) / 2, y);
            y += headerFont.GetHeight(g) + 20;

            g.DrawString("Reservation Report", headerFont, brush, x, y);
            y += subHeaderFont.GetHeight(g) + 20;

            g.DrawString("----------------------------------------------------------------------------------------", subHeaderFont, brush, x, y);
            y += subHeaderFont.GetHeight(g) + 20;

            // Print column headers
            g.DrawString("Year", font, brush, x, y);
            g.DrawString("Month", font, brush, x + columnWidth, y);
            g.DrawString("Party Type", font, brush, x + 2 * columnWidth, y);
            g.DrawString("Reservation Count", font, brush, x + 3 * columnWidth, y);
            g.DrawString("Total Pax", font, brush, x + 4 * columnWidth, y);

            y += lineHeight;

            // Print rows from DataTable
            foreach (DataGridViewRow dgvRow in dataGridViewReservations.Rows)
            {
                // Skip the new row if AllowUserToAddRows is true
                if (dgvRow.IsNewRow) continue;

                // Access values through the Cells collection
                g.DrawString(dgvRow.Cells["Year"].Value?.ToString(), font, brush, x, y);
                g.DrawString(dgvRow.Cells["Month"].Value?.ToString(), font, brush, x + columnWidth, y);
                g.DrawString(dgvRow.Cells["PartyType"].Value?.ToString(), font, brush, x + 2 * columnWidth, y);
                g.DrawString(dgvRow.Cells["ReservationCount"].Value?.ToString(), font, brush, x + 3 * columnWidth, y);
                g.DrawString(dgvRow.Cells["TotalPax"].Value?.ToString(), font, brush, x + 4 * columnWidth, y);

                if (int.TryParse(dgvRow.Cells["ReservationCount"].Value?.ToString(), out int reservationCount))
                {
                    totalR += reservationCount;
                }
                if (int.TryParse(dgvRow.Cells["TotalPax"].Value?.ToString(), out int paxCount))
                {
                    totalP += paxCount;
                }


                y += lineHeight;

                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            g.DrawString("----------------------------------------------------------------------------------------", subHeaderFont, brush, x, y);
            y += subHeaderFont.GetHeight(g) + 20;
            g.DrawString($"Total Pax: {totalP}", font, brush, x + 4 * columnWidth, y);
            y += lineHeight;
            g.DrawString($"Total Reservations: {totalR}", font, brush, x + 4 * columnWidth, y);
            y += lineHeight;


            e.HasMorePages = false;
        }


        private void btnMenuD_Click(object sender, EventArgs e)
        {
            ManagerFoodMenu managerMenu = new ManagerFoodMenu(session);
            managerMenu.Show();
            this.Hide();
        }

        private void btnHallsD_Click(object sender, EventArgs e)
        {
            ManagerHall listOfHalls = new ManagerHall(session);
            listOfHalls.Show();
            this.Hide();
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmEmployeeProfileSettings settings = new frmEmployeeProfileSettings(session);
            settings.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EmployeeLogin pageL = new EmployeeLogin();
                pageL.Show();
                this.Hide();
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            ManagerDashboard dash = new ManagerDashboard(session);
            dash.Show();
            this.Hide();
        }


        private void btnReserD_Click(object sender, EventArgs e)
        {
            ManagerReservationsReport reservation = new ManagerReservationsReport(session);
            reservation.Show();
            this.Hide();
            pnlNav.Height = btnReserD.Height;
            pnlNav.Top = btnReserD.Top;
            pnlNav.Left = btnReserD.Left;
        }

        private void btnSalesReportD_Click(object sender, EventArgs e)
        {
            ManagerSalesReport sales = new ManagerSalesReport(session);
            sales.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gbSortBy_Enter(object sender, EventArgs e)
        {

        }
    }
}
