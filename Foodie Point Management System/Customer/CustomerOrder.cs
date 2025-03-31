using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Customer
{
    public partial class CustomerOrder: Form
    {
        Customer session;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
            );

        public CustomerOrder(Customer s)
        {
            this.session = s;
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnOrderD.Height;
            pnlNav.Top = btnOrderD.Top;
            pnlNav.Left = btnOrderD.Left;
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            OrderMenuGrid.DataSource = session.LoadDatatable("SELECT FoodID, Name as \"Name\", CuisineType as \"Cuisine Type\", Price as \"Price (RM)\" FROM FoodMenu");
            
        }

        private void rbChi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChi.Checked)
                OrderMenuGrid.DataSource = session.LoadDatatable("Select FoodID, name as \"Name\", CuisineType as \"Cuisine Type\", Price as \"Price (RM)\" from FoodMenu where CuisineType = 'Chinese'");

        }

        private void rbMalay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMalay.Checked)
                OrderMenuGrid.DataSource = session.LoadDatatable("Select FoodID, Name as \"Name\", CuisineType as \"Cuisine Type\", Price as \"Price (RM)\" from FoodMenu where CuisineType = 'Malay'");

        }

        private void rbIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIn.Checked)
                OrderMenuGrid.DataSource = session.LoadDatatable("Select FoodID, Name as \"Name\", CuisineType as \"Cuisine Type\", price as \"Price (RM)\" from FoodMenu where CuisineType = 'Indian'");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbChi.Checked = false;
            rbMalay.Checked = false;
            rbIn.Checked = false;
            rbBeverage.Checked = false;
            OrderMenuGrid.DataSource = session.LoadDatatable("SELECT FoodID, Name as \"Name\", CuisineType as \"Cuisine Type\", Price as \"Price (RM)\" FROM FoodMenu");
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            CustomerOrderList cOrderlist = new CustomerOrderList(session);
            cOrderlist.Show();
            this.Hide(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (OrderMenuGrid.CurrentRow.Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Please Select a cell to add into your order list!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!int.TryParse(txtQuant.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid positive numeric value into the quantity box!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(quantity == 0)
            {
                MessageBox.Show("Please enter a numeric value above 0!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string msg = session.AddFood_OrderList(OrderMenuGrid.CurrentRow.Cells[0].Value.ToString(), quantity);

                MessageBox.Show(msg, "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OrderMenuGrid.DataSource = session.LoadDatatable($"Select FoodID, Name as \"Name\", CuisineType as \"Cuisine Type\", Price as \"Price (RM)\" from FoodMenu where name like '%{txtSearch.Text.Trim()}%'");
        }

        private void rbBeverage_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBeverage.Checked)
                OrderMenuGrid.DataSource = session.LoadDatatable("Select FoodID, Name as \"Name\", CuisineType as \"Cuisine Type\", price as \"Price (RM)\" from FoodMenu where CuisineType = 'Beverages'");

        }
        private void btnDash_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard(session);
            dashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOrderD_Click(object sender, EventArgs e)
        {
            CustomerOrder ordermenu = new CustomerOrder(session);
            ordermenu.Show();
            this.Hide();
        }

        private void btnReserD_Click(object sender, EventArgs e)
        {
            CustomerReservation reservation = new CustomerReservation(session);
            reservation.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile cProfile = new CustomerProfile(session);
            cProfile.Show();
            this.Hide();
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
