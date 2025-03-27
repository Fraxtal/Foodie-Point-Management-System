using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.ReservationCoordinator
{
    public partial class ManageReservations : Form
    {
        ReservationCoordinator resManager = new ReservationCoordinator();
        public ManageReservations()
        {
            InitializeComponent();
        }
   
        private void ManageReservations_Load(object sender, EventArgs e)
        {
            List<string> res = resManager.ReservationCount();
            lblConfirmed.Text = res[1];
            lblPending.Text = res[0];
            lblCancelled.Text = res[2];

            DGVReservations.DataSource = resManager.ReservationTable("SELECT * FROM Reservations");

            dtpDate.Value = DateTime.Today;
        }


        private void DGVReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lbltitle2_Click(object sender, EventArgs e)
        {

        }

 
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cmbStatus.Text) || string.IsNullOrEmpty(txtPax.Text))
            {
                MessageBox.Show("Please fill in all blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DGVReservations.DataSource = resManager.ReservationTable("SELECT * FROM Reservations");
                return;
            }
            if (DGVReservations.Rows.Count == 0)
            {
                MessageBox.Show("No reservations found for the selected date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DGVReservations.DataSource = resManager.ReservationTable("SELECT * FROM Reservations");
                return;
            }

            var search = resManager.ReservationSearch(txtName.Text, cmbStatus.Text, dtpDate.Value, int.Parse(txtPax.Text));
            
            DGVReservations.DataSource = search;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this reservation?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please fill in all blanks.");
                return;
            }
            if (string.IsNullOrEmpty(txtPax.Text) || !int.TryParse(txtPax.Text, out int num) || num<=0)
            {
                MessageBox.Show("Number of guests must be a postive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            int hallID = resManager.AssignHall(int.Parse(txtPax.Text), dtpDate.Value);
            if (hallID == -1)
            {
                MessageBox.Show("No available hall for the selected date and party size.", "No Availability", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(resManager.ReservationAdd(txtName.Text, cmbStatus.Text, hallID.ToString(), dtpDate.Value, int.Parse(txtPax.Text)));
            DGVReservations.DataSource = resManager.ReservationTable("SELECT * FROM Reservations");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete this reservation? \n Reservation ID :{txtresID.Text}", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            if (DGVReservations.CurrentCell == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string delete = DGVReservations.CurrentRow.Cells[0].Value.ToString();
            {
                MessageBox.Show(resManager.ReservationDelete(Convert.ToInt32(delete)));
                DGVReservations.Rows.RemoveAt(DGVReservations.CurrentRow.Index);
                txtName.Clear();
                txtresID.Clear();
                dtpDate.Value=DateTime.Today;
                txtHall.Clear();
                txtPax.Clear();
                cmbStatus.SelectedIndex=-1;
                DGVReservations.CurrentCell = null;
            }

            DGVReservations.DataSource = resManager.ReservationTable("SELECT * FROM Reservations");
        }

        private void lblConfirmed_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtresID_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rows = DGVReservations.Rows[e.RowIndex];
                txtName.Text = rows.Cells[1].Value.ToString();
                txtresID.Text = rows.Cells[0].Value.ToString();
                dtpDate.Text = rows.Cells[2].Value.ToString();
                txtHall.Text = rows.Cells[4].Value.ToString();
                txtPax.Text = rows.Cells[3].Value.ToString();
                cmbStatus.Text = rows.Cells[5].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to edit this reservation? \n Reservation ID :{txtresID.Text}", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please fill in all blanks.");
                return;
            }
            if (string.IsNullOrEmpty(txtPax.Text) || !int.TryParse(txtPax.Text, out int num) || num <= 0)
            {
                MessageBox.Show("Number of guests must be a postive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(resManager.ReservationEdit(txtName.Text, cmbStatus.Text, txtHall.Text, dtpDate.Value, int.Parse(txtPax.Text), int.Parse(txtresID.Text)));

            DGVReservations.DataSource = resManager.ReservationTable("SELECT * FROM Reservations");
        }

        private void btnReply_Click(object sender, EventArgs e)
        {

        }

        private void DGVcusMSG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtHall_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtresID.Clear();
            dtpDate.Value = DateTime.Today;
            txtHall.Clear();
            txtPax.Clear();
            cmbStatus.SelectedIndex = -1;
            DGVReservations.CurrentCell = null;

            DGVReservations.DataSource = resManager.ReservationTable("SELECT * FROM Reservations");
        }
    }
}
