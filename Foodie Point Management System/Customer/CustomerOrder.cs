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
    public partial class CustomerOrder: Form
    {
        Customer session;

        public CustomerOrder(Customer s)
        {
            this.session = s;
            InitializeComponent();
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
    }
}
