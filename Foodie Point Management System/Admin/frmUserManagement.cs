using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Admin
{
    public partial class frmAdminUserManagement : Form
    {
        emAdmin session;

        string table = "Customer";

        public frmAdminUserManagement(emAdmin s)
        {
            InitializeComponent();
            this.session = s;
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            umdw.DataSource = session.LoadDatatable("SELECT * FROM Customer");
            lblRole.Visible = false;
            cbRole.Visible = false;
        }

        private void radiobtnCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnCustomer.Checked)
            {
                umdw.DataSource = session.LoadDatatable("SELECT * FROM Customer");
                this.table = "Customer";
                lblRole.Visible = false;
                cbRole.Visible = false;
            }
        }

        private void radiobtnEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnEmployee.Checked)
            {
                umdw.DataSource = session.LoadDatatable("SELECT * FROM Employee");
                this.table = "Employee";
                lblRole.Visible = true;
                cbRole.Visible = true;
            }
        }

        private void umdw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rows = umdw.Rows[e.RowIndex];
                txtID.Text = rows.Cells[0].Value.ToString();
                txtUsername.Text = rows.Cells[1].Value.ToString();
                txtFullname.Text = rows.Cells[2].Value.ToString();
                txtEmail.Text = rows.Cells[3].Value.ToString();
                txtPassword.Text = rows.Cells[4].Value.ToString();
                txtDateCreated.Text = rows.Cells[5].Value.ToString();

                if (radiobtnEmployee.Checked)
                {
                    cbRole.SelectedIndex = cbRole.FindStringExact(rows.Cells[6].Value.ToString());
                }
            }
        }

        
        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (umdw.CurrentRow.Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Please Select a cell to add into your order list!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string result = session.UpdateUser(table, txtID.Text.Trim(), txtUsername.Text.Trim(), txtFullname.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim(), radiobtnEmployee.Checked ? cbRole.SelectedItem?.ToString() : null);
                if (result == "User updated successfully!")
                {
                    MessageBox.Show(result, "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radiobtnEmployee.Checked)
            {
                umdw.DataSource = session.LoadDatatable("SELECT * FROM Employee");
                this.table = "Employee";
                lblRole.Visible = true;
                cbRole.Visible = true;
            }
            else
            {
                umdw.DataSource = session.LoadDatatable("SELECT * FROM Customer");
                this.table = "Customer";
                lblRole.Visible = false;
                cbRole.Visible = false;
            }

        }

        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (umdw.CurrentRow.Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Please Select a cell to add into your order list!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string result = session.DeleteUser(table, txtID.Text.Trim());

                if (result == "User Deletion Succesful!")
                {
                    MessageBox.Show(result, "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radiobtnEmployee.Checked)
            {
                umdw.DataSource = session.LoadDatatable("SELECT * FROM Employee");
                this.table = "Employee";
                lblRole.Visible = true;
                cbRole.Visible = true;
            }
            else
            {
                umdw.DataSource = session.LoadDatatable("SELECT * FROM Customer");
                this.table = "Customer";
                lblRole.Visible = false;
                cbRole.Visible = false;
            }
        }

        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(umdw.CurrentRow.Cells[0].Value.ToString() == null))
            {
                string result = session.AddUser(table, txtUsername.Text.Trim(), txtFullname.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim(), radiobtnEmployee.Checked ? cbRole.SelectedItem?.ToString() : null);
                
                if (result == "User had been added!")
                {
                    MessageBox.Show(result, "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select a sell in the last row and fill in the information of the user you would like to add to continue!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (radiobtnEmployee.Checked)
            {
                umdw.DataSource = session.LoadDatatable("SELECT * FROM Employee");
                this.table = "Employee";
                lblRole.Visible = true;
                cbRole.Visible = true;
            }
            else
            {
                umdw.DataSource = session.LoadDatatable("SELECT * FROM Customer");
                this.table = "Customer";
                lblRole.Visible = false;
                cbRole.Visible = false;
            }
        }
    }
   
}
