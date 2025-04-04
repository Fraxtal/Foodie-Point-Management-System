using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using Foodie_Point_Management_System.Employee_Login;
using System.Runtime.InteropServices;

namespace Foodie_Point_Management_System.Chef
{
    public partial class frmChefInventory : Form
    {
        EmChef sessionCI;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );

        public frmChefInventory(EmChef sc)
        {
            InitializeComponent();
            this.sessionCI = sc;
            pnlNav.Height = btnInventory.Height;
            pnlNav.Top = btnInventory.Top;
            pnlNav.Left = btnInventory.Left;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void frmChefInventory_Load(object sender, EventArgs e)
        {
            dgvInventory.DataSource = sessionCI.InventoryDisplay();

            //prevent
            dgvInventory.CurrentCell = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtbxItemID.Clear();
            int inputQuantity_A;

            //Confirmation message before execution
            if (MessageBox.Show($"Are you sure you want to add a new record? \nNew Record: \n{txtbxItemName.Text}", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            //Check if relevant fields are filled
            if (string.IsNullOrEmpty(txtbxItemName.Text))
            {
                MessageBox.Show("Please fill in all empty fields if applicable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Quantity Input Validation
            if (string.IsNullOrEmpty(txtbxQuantity.Text) || !int.TryParse(txtbxQuantity.Text, out int num) || num < 0)
            {
                MessageBox.Show("Quantity must be a positive integer. Default value set to 0", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputQuantity_A = 0;
            }
            else
            {
                inputQuantity_A = Convert.ToInt32(txtbxQuantity.Text);
            }

            bool sameName = sessionCI.InventoryCheckName(txtbxItemName.Text);
            bool sameIDName = sessionCI.InventoryCheckIDName(txtbxItemID.Text, txtbxItemName.Text);

            //Check if there are records with the same name and id, then ask for confirmation
            if (!sameIDName)
            {
                if (sameName)
                {
                    if (MessageBox.Show($"A record with the name {txtbxItemName.Text} already exists. \nProceed anyways?", "Matching Name Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            //No sameID check because of auto-incrementing IDs
            MessageBox.Show(sessionCI.InventoryAdd(txtbxItemName.Text, inputQuantity_A));
            dgvInventory.DataSource = sessionCI.InventoryDisplay();
            dgvInventory.CurrentCell = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int inputQuantity_U;

            //Check if relevant fields are filled
            if (string.IsNullOrEmpty(txtbxItemID.Text) || string.IsNullOrEmpty(txtbxItemName.Text))
            {
                MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmation message before execution
            if (MessageBox.Show($"Are you sure you want to update this record? \nUpdated Record: \n{txtbxItemID.Text} {txtbxItemName.Text}", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            //Quantity input validation, prevent changes if an improper value is given, then focus selection on the quantity textbox
            if (string.IsNullOrEmpty(txtbxQuantity.Text) || !int.TryParse(txtbxQuantity.Text, out int num) || num < 0)
            {
                MessageBox.Show("Quantity must be a positive integer. Record not updated.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxQuantity.Focus();
                return;
            }
            else
            {
                inputQuantity_U = Convert.ToInt32(txtbxQuantity.Text);
            }

            bool existID = sessionCI.InventoryCheckID(txtbxItemID.Text);
            bool sameName = sessionCI.InventoryCheckName(txtbxItemName.Text);
            bool sameIDName = sessionCI.InventoryCheckIDName(txtbxItemID.Text, txtbxItemName.Text);

            //Check if there are records with the same name and ask for confirmation
            if (!sameIDName && sameName)
            {

                if (MessageBox.Show($"A record with the name {txtbxItemName.Text} already exists. \nProceed anyways?", "Matching Name Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

            }

            //Check if record exists so it can be updated, then display the corresponding success notification or error message.
            if (existID)
            {
                MessageBox.Show(sessionCI.InventoryUpdate(int.Parse(txtbxItemID.Text), txtbxItemName.Text, inputQuantity_U));
            }
            else
            {
                MessageBox.Show($"Record with ID {txtbxItemID.Text} does not exist.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvInventory.DataSource = sessionCI.InventoryDisplay();
            dgvInventory.CurrentCell = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Check if the user is selecting a cell in the dgv
            if (dgvInventory.CurrentCell == null)
            {
                MessageBox.Show("Please select a record from the table to delete.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //variable holds the ID of the record to be deleted
            string todelete = dgvInventory.CurrentRow.Cells[0].Value.ToString();

            //Confirmation message before execution, clears all related fields afterwards
            if (MessageBox.Show($"Are you sure you want to delete this record? \nRecord: \n{todelete} {dgvInventory.CurrentRow.Cells[1].Value.ToString()}", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(sessionCI.InventoryDelete(todelete));
                dgvInventory.Rows.RemoveAt(dgvInventory.CurrentRow.Index);
                txtbxItemID.Clear();
                txtbxItemName.Clear();
                txtbxQuantity.Clear();
                dgvInventory.CurrentCell = null;
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Removes text from the event that provides context
            if (string.IsNullOrEmpty(txtbxSearchBar.Text) || txtbxSearchBar.Text == "Search by ID or Name...")
            {
                dgvInventory.DataSource = sessionCI.InventoryDisplay();
            }
            else
            {
                dgvInventory.DataSource = sessionCI.InventorySearch(txtbxSearchBar.Text);
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cell click event that checks if the user is selecting a valid cell, then transfer the values to the corresponding text boxes
            if (e.RowIndex != -1)
            {
                DataGridViewRow rows = dgvInventory.Rows[e.RowIndex];
                txtbxItemID.Text = rows.Cells[0].Value.ToString();
                txtbxItemName.Text = rows.Cells[1].Value.ToString();
                txtbxQuantity.Text = rows.Cells[2].Value.ToString();
            }
        }

        private void txtbxSearchBar_Enter(object sender, EventArgs e)
        {
            //search bar context
            if (txtbxSearchBar.Text == "Search by ID or Name...")
            {
                txtbxSearchBar.Text = "";
                txtbxSearchBar.ForeColor = Color.Black;
            }
        }

        private void txtbxSearchBar_Leave(object sender, EventArgs e)
        {
            //search bar context
            if (txtbxSearchBar.Text == "")
            {
                txtbxSearchBar.Text = "Search by ID or Name...";
                txtbxSearchBar.ForeColor = Color.Silver;
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            frmChefDashboard dashboard = new frmChefDashboard(sessionCI);
            dashboard.Show();
            this.Hide();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmChefViewOrders pageVO = new frmChefViewOrders(sessionCI);
            pageVO.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmChefInventory pageI = new frmChefInventory(sessionCI);
            pageI.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmEmployeeProfileSettings pagePS = new frmEmployeeProfileSettings(sessionCI);
            pagePS.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Logout and return to login page?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sessionCI = null;
                EmployeeLogin pageL = new EmployeeLogin();
                pageL.Show();
                this.Hide();
            }
        }

        private void lblInventory_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
