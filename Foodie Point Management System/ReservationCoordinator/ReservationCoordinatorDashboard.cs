using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.ReservationCoordinator
{
    public partial class ReservationCoordinatorDashboard : Form
    {
        ReservationCoordinator rc = new ReservationCoordinator();

        public ReservationCoordinatorDashboard()
        {
            InitializeComponent();
        }

        private void lblupcoming_Click(object sender, EventArgs e)
        {

        }

        private void ReservationCoordinatorDashboard_Load(object sender, EventArgs e)
        {
            radAll.Checked = true;
        }

        private Dictionary<DateTime, string> reservationStatus = new Dictionary<DateTime, string>();

        

        private void lnkmanage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageReservations manageReservation = new ManageReservations();
            manageReservation.Show();
        }

        private void lnkcustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRequest customerRequest = new CustomerRequest();
            customerRequest.Show();
        }

        private void monthlyreservation_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void upcoming_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pending_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnksettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmEmployeeProfileSettings rcProfile = new frmEmployeeProfileSettings();
            //rcProfile.Show();
        }

        private void radconfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (radconfirm.Checked)
            {
                upcoming.DataSource = rc.ReservationTable("SELECT * FROM Reservations WHERE ReservationStatus = 'Confirmed'");
            }
            
        }

        private void radpending_CheckedChanged(object sender, EventArgs e)
        {
            if (radpending.Checked)
            {
                upcoming.DataSource = rc.ReservationTable("SELECT * FROM Reservations WHERE ReservationStatus = 'Pending'");
            }
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radAll.Checked)
            {
                upcoming.DataSource = rc.ReservationTable("SELECT * FROM Reservations");
            }
        }
    }
}
