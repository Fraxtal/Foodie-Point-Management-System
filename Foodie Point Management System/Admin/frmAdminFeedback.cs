using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Foodie_Point_Management_System.Employee_Login;

namespace Foodie_Point_Management_System.Admin
{
    public partial class frmAdminFeedback : Form
    {
        emAdmin session;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
                );

        public frmAdminFeedback(emAdmin s)
        {
            InitializeComponent();
            this.session = s;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnFeedbackD.Height;
            pnlNav.Top = btnFeedbackD.Top;
            pnlNav.Left = btnFeedbackD.Left;
        }

        private void unreadfeedbacks_Load(object sender, EventArgs e)
        {
            feedbackView.DataSource = session.LoadDatatable("SELECT f.FeedbackID, f.Rating, f.ReadStatus, c.Username FROM Feedback f LEFT JOIN Customer c ON f.CustomerID = c.CustomerID;");
        }

        private void feedbackView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (feedbackView.CurrentRow.Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Please Select a cell to add into your order list!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<string> response = session.ShowFeedbackContent(feedbackView.CurrentRow.Cells[0].Value.ToString());

                if (response[0] == "F")
                {
                    MessageBox.Show(response[1], "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(response[1], "Feedback Content Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            feedbackView.DataSource = session.LoadDatatable("SELECT f.FeedbackID, f.Rating, f.ReadStatus, c.Username FROM Feedback f LEFT JOIN Customer c ON f.CustomerID = c.CustomerID;");

        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmAdminUserManagement UserManagement = new frmAdminUserManagement(session);
            UserManagement.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            frmAdminFeedback Feedback = new frmAdminFeedback(session);
            Feedback.Show();
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            frmAdminSalesReport SalesReport = new frmAdminSalesReport(session);
            SalesReport.Show();
            this.Hide();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            frmAdminDashboard Dashboard = new frmAdminDashboard(session);
            Dashboard.Show();
            this.Hide();
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmAdminUserManagement UserManagement = new frmAdminUserManagement(session);
            UserManagement.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmAdminSalesReport SalesReport = new frmAdminSalesReport(session);
            SalesReport.Show();
            this.Hide();
        }

        private void btnFeedbackD_Click(object sender, EventArgs e)
        {
            frmAdminFeedback Feedback = new frmAdminFeedback(session);
            Feedback.Show();
            this.Hide();
            pnlNav.Height = btnFeedbackD.Height;
            pnlNav.Top = btnFeedbackD.Top;
            pnlNav.Left = btnFeedbackD.Left;
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmEmployeeProfileSettings settings = new frmEmployeeProfileSettings(session);
            settings.Show();
            this.Hide();
        }
    }
}
