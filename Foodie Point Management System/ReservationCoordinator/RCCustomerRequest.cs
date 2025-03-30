using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Foodie_Point_Management_System.ReservationCoordinator
{
    public partial class CustomerRequest : Form
    {
        ReservationCoord rc;
        public CustomerRequest(ReservationCoord s)
        {
            InitializeComponent();
            this.rc = s;
        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerRequest_Load(object sender, EventArgs e)
        {
            DGVcusMSG.DataSource = rc.ReservationTable("SELECT * FROM ReservationMessage");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (DGVcusMSG.CurrentCell == null)
            {
                MessageBox.Show("Please select a row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string msgID = DGVcusMSG.CurrentRow.Cells[0].Value.ToString();

            string rcresponse = rc.RCRequests(msgID, txtResponse.Text);

            if (rcresponse == "Reply submitted.")
            {
                MessageBox.Show(rcresponse, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rcresponse, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DGVcusMSG.DataSource = rc.ReservationTable("SELECT * FROM ReservationMessage");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVcusMSG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DGVcusMSG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow rows = DGVcusMSG.Rows[e.RowIndex];
                txtName.Text = rows.Cells[0].Value.ToString();
                txtresID.Text = rows.Cells[1].Value.ToString();
            }
        }
    }
}
