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
using Foodie_Point_Management_System.Employee_Login;
using System.Runtime.InteropServices;

namespace Foodie_Point_Management_System.Chef
{
    public partial class frmChefViewOrders : Form
    {
        EmChef sessionCV;
        string currentsort;
        string sort = "SELECT OrderTable.OrderID AS 'Order ID', FoodMenu.Name AS 'Food Name', OrderDetail.Quantity AS 'Quantity', " +
                    "OrderTable.CustomerID AS 'Customer ID', OrderTable.OrderStatus AS 'Status', Employee.FullName AS 'Chef Name' " +
                    "FROM OrderTable " +
                    "LEFT JOIN OrderDetail ON OrderTable.OrderID = OrderDetail.OrderID " +
                    "LEFT JOIN FoodMenu ON OrderDetail.FoodID = FoodMenu.FoodID " +
                    "LEFT JOIN Employee ON OrderTable.EmployeeID = Employee.EmployeeID ";
        string all = "WHERE OrderTable.OrderStatus IS NOT NULL ";
        string progress = "WHERE OrderTable.OrderStatus = 'In Progress' ";
        string queue = "WHERE OrderTable.OrderStatus = 'In Queue' ";
        string completed = "WHERE OrderTable.OrderStatus = 'Completed' ";
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );

        public frmChefViewOrders(EmChef sc)
        {
            InitializeComponent();
            this.sessionCV = sc;
            pnlNav.Height = btnViewOrder.Height;
            pnlNav.Top = btnViewOrder.Top;
            pnlNav.Left = btnViewOrder.Left;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void frmChefViewOrders_Load(object sender, EventArgs e)
        {
            rbtnAll.Checked = true;
        }

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rows = dgvOrderList.Rows[e.RowIndex];
                txtbxOrderID.Text = rows.Cells[0].Value.ToString();
                cmbboxStatus.Text = rows.Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtbxOrderID.Text, out int orderid) || string.IsNullOrEmpty(txtbxOrderID.Text) || cmbboxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order or enter a valid Order ID, then select the corresponding status to be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (dgvOrderList.CurrentRow.Cells[4].Value.ToString() == "Completed")
            {
                if (MessageBox.Show($"Order has already been marked as 'Completed'. \nDo you still want to update its status?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            if (!sessionCV.ViewOrderCheck(txtbxOrderID.Text))
            {
                MessageBox.Show("Invalid Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(sessionCV.ViewOrderUpdate(txtbxOrderID.Text, cmbboxStatus.Text));
            dgvOrderList.DataSource = sessionCV.ViewOrdersDisplay(currentsort);
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            string onlyuser = $"AND OrderTable.EmployeeID = {sessionCV.Id}";

            //show all orders assigned to me
            if (rbtnAll.Checked && chkbxMe.Checked)
            {
                currentsort = sort + all + onlyuser;
            }
            else if (rbtnAll.Checked && !chkbxMe.Checked)
            {
                currentsort = sort + all;
            }

            dgvOrderList.DataSource = sessionCV.ViewOrdersDisplay(currentsort);
        }

        private void rbtnPast_CheckedChanged(object sender, EventArgs e)
        {
            string onlyuser = $"AND OrderTable.EmployeeID = {sessionCV.Id}";

            //show completed orders assigned to me
            if (rbtnPast.Checked && chkbxMe.Checked)
            {
                currentsort = sort + completed + onlyuser;
            }
            else if (rbtnPast.Checked && !chkbxMe.Checked)
            {
                currentsort = sort + completed;
            }

            dgvOrderList.DataSource = sessionCV.ViewOrdersDisplay(currentsort);

        }

        private void rbtnOngoing_CheckedChanged(object sender, EventArgs e)
        {
            string onlyuser = $"AND OrderTable.EmployeeID = {sessionCV.Id}";

            //show in progress orders assigned to me
            if (rbtnOngoing.Checked && chkbxMe.Checked)
            {
                currentsort = sort + progress + onlyuser;
            }
            else if (rbtnOngoing.Checked && !chkbxMe.Checked)
            {
                currentsort = sort + progress;
            }

            dgvOrderList.DataSource = sessionCV.ViewOrdersDisplay(currentsort);
        }

        private void rbtnQueue_CheckedChanged(object sender, EventArgs e)
        {
            string onlyuser = $"AND OrderTable.EmployeeID = {sessionCV.Id}";

            //show queueing orders assigned to me
            if (rbtnQueue.Checked && chkbxMe.Checked)
            {
                currentsort = sort + queue + onlyuser;
            }
            else if (rbtnQueue.Checked && !chkbxMe.Checked)
            {
                currentsort = sort + queue;
            }

            dgvOrderList.DataSource = sessionCV.ViewOrdersDisplay(currentsort);
        }

        private void chkbxMe_CheckedChanged(object sender, EventArgs e)
        {
            string onlyuser = $"AND OrderTable.EmployeeID = {sessionCV.Id}";

            //show all orders assigned to me
            if (rbtnAll.Checked && chkbxMe.Checked)
            {
                currentsort = sort + all + onlyuser;
            }
            else if (rbtnAll.Checked && !chkbxMe.Checked)
            {
                currentsort = sort + all;
            }

            //show queueing orders assigned to me
            if (rbtnQueue.Checked && chkbxMe.Checked)
            {
                currentsort = sort + queue + onlyuser;
            }
            else if (rbtnQueue.Checked && !chkbxMe.Checked)
            {
                currentsort = sort + queue;
            }

            //show in progress orders assigned to me
            if (rbtnOngoing.Checked && chkbxMe.Checked)
            {
                currentsort = sort + progress + onlyuser;
            }
            else if (rbtnOngoing.Checked && !chkbxMe.Checked)
            {
                currentsort = sort + progress;
            }

            //show completed orders assigned to me
            if (rbtnPast.Checked && chkbxMe.Checked)
            {
                currentsort = sort + completed + onlyuser;
            }
            else if (rbtnPast.Checked && !chkbxMe.Checked)
            {
                currentsort = sort + completed;
            }

            dgvOrderList.DataSource = sessionCV.ViewOrdersDisplay(currentsort);
        }
        private void btnDash_Click(object sender, EventArgs e)
        {
            frmChefDashboard dashboard = new frmChefDashboard(sessionCV);
            dashboard.Show();
            this.Hide();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmChefViewOrders pageVO = new frmChefViewOrders(sessionCV);
            pageVO.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmChefInventory pageI = new frmChefInventory(sessionCV);
            pageI.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmEmployeeProfileSettings pagePS = new frmEmployeeProfileSettings(sessionCV);
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
                sessionCV = null;
                EmployeeLogin pageL = new EmployeeLogin();
                pageL.Show();
                this.Hide();
            }
        }

        private void txtbxOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
