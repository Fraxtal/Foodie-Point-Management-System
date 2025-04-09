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
    public partial class CustomerReservationRequest: Form
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
        public CustomerReservationRequest(Customer s)
        {
            session = s;
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtPax.Text == "")
            {
                MessageBox.Show("Please fill in the pax amount!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtPicker.Checked == false)
            {
                MessageBox.Show("Please pick a date and time!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string msg = session.SubmitReservationRequest(dtPicker.Value, int.Parse(txtPax.Text));
                if (msg == "Reservation Request Successfully Submitted!")
                {
                    MessageBox.Show(msg, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustomerDashboard cDash = new CustomerDashboard(session);
                    cDash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerReservationRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
