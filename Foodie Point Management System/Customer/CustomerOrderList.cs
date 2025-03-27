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
    public partial class CustomerOrderList : Form
    {
        Customer session;

        public CustomerOrderList(Customer s)
        {
            InitializeComponent();
            this.session = s;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            CustomerPayment payment = new CustomerPayment(session);
            payment.Show();
            this.Hide();
        }

        private void CustomerOrderList_Load(object sender, EventArgs e)
        {
            OrderListGrid.DataSource = session.LoadDatatable($"SELECT od.OrderDetailID AS \"Order Id\", od.FoodID AS \"Food ID\", fm.Name AS \"Name\", fm.CuisineType AS \"Cuisine Type\", od.Quantity AS \"Quantity\", od.Remarks AS \"Remarks\" FROM OrderDetail od JOIN FoodMenu fm ON od.FoodID = fm.FoodID JOIN OrderTable ot ON od.OrderID = ot.OrderID WHERE ot.CustomerID = '{session.Id}' AND ot.OrderStatus IS NULL;");
            OrderListGrid.CurrentCell = null;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CustomerOrder menu = new CustomerOrder(session);
            menu.Show();
            this.Hide();
        }

        private void OrderListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rows = OrderListGrid.Rows[e.RowIndex];
                txtOID.Text = rows.Cells[0].Value.ToString();
                txtFood.Text = rows.Cells[2].Value.ToString();
                txtQuantity.Text = rows.Cells[4].Value.ToString();
                txtRemarks.Text = rows.Cells[5].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please insert a valid numeric value to update your order list!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string msg = session.OrderListUpdater(txtOID.Text, quantity, txtRemarks.Text);

                if (msg == "Order Successfully Removed!" || msg == "Order Successfully Updated!" || msg == "Nothing was Changed!")
                {
                    MessageBox.Show(msg, "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    OrderListGrid.DataSource = session.LoadDatatable($"SELECT od.OrderDetailID AS \"Order Id\", od.FoodID AS \"Food ID\", fm.Name AS \"Name\", fm.CuisineType AS \"Cuisine Type\", od.Quantity AS \"Quantity\", od.Remarks AS \"Remarks\" FROM OrderDetail od JOIN FoodMenu fm ON od.FoodID = fm.FoodID JOIN OrderTable ot ON od.OrderID = ot.OrderID WHERE ot.CustomerID = '{session.Id}' AND ot.OrderStatus IS NULL;");
                }
                else
                {
                    MessageBox.Show(msg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
