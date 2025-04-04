using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Foodie_Point_Management_System.Employee_Login;

namespace Foodie_Point_Management_System.ReservationCoordinator
{
    public partial class CustomerRequest : Form
    {
        ReservationCoord rc;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );
        public CustomerRequest(ReservationCoord s)
        {
            InitializeComponent();
            this.rc = s;
            pnlNav.Height = btnRequest.Height;
            pnlNav.Top = btnRequest.Top;
            pnlNav.Left = btnRequest.Left;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
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
        private void btnDash_Click(object sender, EventArgs e)
        {
            ReservationCoordinatorDashboard dashboard = new ReservationCoordinatorDashboard(rc);
            dashboard.Show();
            this.Hide();
        }

        private void btnSearchReser_Click(object sender, EventArgs e)
        {
            SearchReservations searchReservations = new SearchReservations();
            searchReservations.Show();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            CustomerRequest customerRequest = new CustomerRequest(rc);
            customerRequest.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmEmployeeProfileSettings rcProfile = new frmEmployeeProfileSettings(rc);
            rcProfile.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EmployeeLogin pageL = new EmployeeLogin();
                pageL.Show();
                this.Hide();
            }
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnReserManage_Click(object sender, EventArgs e)
        {
            ManageReservations manageReservation = new ManageReservations(rc);
            manageReservation.Show();
            this.Hide();
        }
    }
}
