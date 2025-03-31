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
    public partial class CustomerReservation: Form
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
        public CustomerReservation(Customer s)
        {
            session = s;
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnRStatus_Click(object sender, EventArgs e)
        {
            CustomerReservationStatus cReservationStatus = new CustomerReservationStatus(session);
            cReservationStatus.Show();
            this.Hide();
        }

        private void btnRReservation_Click(object sender, EventArgs e)
        {
            CustomerReservationRequest cReservationReq = new CustomerReservationRequest(session);
            cReservationReq.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
