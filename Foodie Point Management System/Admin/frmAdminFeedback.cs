using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Admin
{
    public partial class frmAdminFeedback : Form
    {
        emAdmin session = new emAdmin();

        public frmAdminFeedback()
        {
            InitializeComponent();
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
    }
}
