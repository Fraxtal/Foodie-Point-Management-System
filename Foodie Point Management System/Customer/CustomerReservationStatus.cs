using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerReservationStatus: Form
    {
        Customer session;
        public CustomerReservationStatus(Customer s)
        {
            InitializeComponent();
            this.session = s; 

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard cDash = new CustomerDashboard(session);
            cDash.Show();
            this.Hide();
        }

        private void CustomerReservationStatus_Load(object sender, EventArgs e)
        {
            RStatusGrid.DataSource = session.LoadDatatable($"SELECT ReservationID, DateTime AS \"Date\", Pax AS \"Pax\", HallID FROM Reservations WHERE DateTime >= DATEADD(DAY, -1, GETDATE()) AND CustomerID = {session.Id};");
        }

        private void RStatusGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = RStatusGrid.Rows[e.RowIndex];

            string result = session.ShowMessageReservationReply(rows.Cells[0].Value.ToString());

            if (result.StartsWith("Error"))
            {
                // Show error message box if the result indicates an error
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Show information message box if the result is normal or informational
                MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
