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
    public partial class ManagerFoodMenu : Form
    {
        private EmManager manager = new EmManager();
        public ManagerFoodMenu()
        {
            InitializeComponent();
            pnlNav.Height = btnMenuD.Height;
            pnlNav.Top = btnMenuD.Top;
            pnlNav.Left = btnMenuD.Left;

        }
        private void ManagerMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fpdbmsDataSet4.Menu' table. You can move, or remove it, as needed.
            try
            {
                dgvMenu.AutoGenerateColumns = true;
                dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                RefreshDataGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Initialization error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Food name is required!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Valid price is required!");
                return;
            }

            manager.FoodAdd(txtName.Text, cmbCuisineType.Text, price);
            RefreshDataGrid();
            ClearFields();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFoodID.Text, out int foodId))
            {
                MessageBox.Show("Select a menu item first!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Food name is required!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Valid price is required!");
                return;
            }

            manager.FoodEdit(foodId, txtName.Text, cmbCuisineType.Text, price);
            RefreshDataGrid();
            ClearFields();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentCell == null)
            {
                MessageBox.Show("Please select a menu item to delete.");
                return;
            }

            int foodId = Convert.ToInt32(dgvMenu.CurrentRow.Cells["FoodID"].Value);

            if (MessageBox.Show("Delete this menu item?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manager.FoodDelete(foodId);
                RefreshDataGrid();
                ClearFields();
            }
        }
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                txtFoodID.Text = row.Cells["colFoodID"].Value.ToString();
                txtName.Text = row.Cells["colName"].Value.ToString();
                cmbCuisineType.Text = row.Cells["colCuisineType"].Value.ToString();
                txtPrice.Text = row.Cells["colPrice"].Value.ToString();
            }
            
        }
        private void RefreshDataGrid()
        {
            try
            {
                dgvMenu.DataSource = manager.LoadTable("SELECT * FROM FoodMenu");
                dgvMenu.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearFields()
        {
            txtFoodID.Clear();
            txtName.Clear();
            cmbCuisineType.Text = "";
            txtPrice.Clear();
            txtSearch.Clear();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dgvMenu.DataSource = manager.FoodSearch(txtSearch.Text);
            }
            else
            {
                RefreshDataGrid();
            }
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuD_Click(object sender, EventArgs e)
        {
            ManagerFoodMenu managerMenu = new ManagerFoodMenu();
            managerMenu.Show();
            this.Hide();
            pnlNav.Height = btnMenuD.Height;
            pnlNav.Top = btnMenuD.Top;
            pnlNav.Left = btnMenuD.Left;
        }

        private void btnHallsD_Click(object sender, EventArgs e)
        {
            ManagerHall listOfHalls = new ManagerHall();
            listOfHalls.Show();
            this.Hide();
            pnlNav.Height = btnHallsD.Height;
            pnlNav.Top = btnHallsD.Top;
            pnlNav.Left = btnHallsD.Left;
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            //frmEmployeeProfileSettings settings = new frmEmployeeProfileSettings();
            //settings.Show();
            //this.Hide();
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            ManagerDashboard dash = new ManagerDashboard();
            dash.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnReserD_Click(object sender, EventArgs e)
        {
            ManagerReservationsReport reservation = new ManagerReservationsReport();
            reservation.Show();
            this.Hide();
            pnlNav.Height = btnReserD.Height;
            pnlNav.Top = btnReserD.Top;
            pnlNav.Left = btnReserD.Left;
        }

        private void btnSalesReportD_Click(object sender, EventArgs e)
        {
            ManagerSalesReport sales = new ManagerSalesReport();
            sales.Show();
            this.Hide();
            pnlNav.Height = btnSalesReportD.Height;
            pnlNav.Top = btnSalesReportD.Top;
            pnlNav.Left = btnSalesReportD.Left;
        }
    }
}
