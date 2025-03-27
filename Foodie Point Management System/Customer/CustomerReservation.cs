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
    public partial class CustomerReservation: Form
    {
        Customer session;
        public CustomerReservation(Customer s)
        {
            session = s;
            InitializeComponent();
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
    }
}
