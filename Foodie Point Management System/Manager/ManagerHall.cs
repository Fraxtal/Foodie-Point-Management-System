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
    public partial class ManagerHall : Form
    {
        EmManager manager;
        public ManagerHall(EmManager s)
        {
            InitializeComponent();
            this.manager = s;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPax.Text, out int pax) || pax <= 0)
            {
                MessageBox.Show("Pax must be a positive number!");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbPartyType.Text))
            {
                MessageBox.Show("Party Type is required!");
                return;
            }

            manager.HallAdd(pax, cmbPartyType.Text);
            RefreshDataGrid();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHallID.Text) ||
       string.IsNullOrEmpty(txtPax.Text) ||
       string.IsNullOrEmpty(cmbPartyType.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (!int.TryParse(txtPax.Text, out int pax) || pax <= 0)
            {
                MessageBox.Show("Pax must be a positive number");
                return;
            }

            if (!int.TryParse(txtHallID.Text, out int hallId))
            {
                MessageBox.Show("Invalid Hall ID");
                return;
            }

            manager.HallEdit(hallId, pax, cmbPartyType.Text);

            dataGridViewHalls.DataSource = manager.LoadTable("SELECT * FROM Hall");
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewHalls.CurrentCell == null)
            {
                MessageBox.Show("Please select a hall to delete.");
                return;
            }



            int hallID = Convert.ToInt32(dataGridViewHalls.CurrentRow.Cells["HallID"].Value);

            DialogResult result = MessageBox.Show(
                "Delete this hall?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                manager.HallDelete(hallID);

                DataTable dt = (DataTable)dataGridViewHalls.DataSource;
                dt.Rows.RemoveAt(dataGridViewHalls.CurrentRow.Index);

                ClearFields();
            }
        }

        private void ManagerHall_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewHalls.AutoGenerateColumns = true;
                dataGridViewHalls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                RefreshDataGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Initialization error: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            txtHallID.Clear();
            txtPax.Clear();
            cmbPartyType.Text = string.Empty;
            txtSearch.Clear();
        }
        private void RefreshDataGrid()
        {
            try
            {
                dataGridViewHalls.DataSource = manager.LoadTable("SELECT HallID, Pax, PartyType FROM Hall");
                dataGridViewHalls.Refresh();
                dataGridViewHalls.ClearSelection();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dataGridViewHalls.DataSource = manager.HallSearch(txtSearch.Text);
            }
            else
            {
                RefreshDataGrid();
            }
        }

        private void dataGridViewHalls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHalls.Rows[e.RowIndex];

                txtHallID.Text = row.Cells["colHallID"].Value?.ToString() ?? "";
                txtPax.Text = row.Cells["colPax"].Value?.ToString() ?? "";
                cmbPartyType.Text = row.Cells["colPartyType"].Value?.ToString() ?? "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerDashboard dashboard = new ManagerDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
