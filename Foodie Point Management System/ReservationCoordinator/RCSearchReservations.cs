using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.ReservationCoordinator
{
    public partial class SearchReservations : Form
    {
        //ReservationCoordinator resManager = new ReservationCoordinator();
        public SearchReservations()
        {
            InitializeComponent();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void DGVResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchReservations_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cmbStatus.Text) || string.IsNullOrEmpty(txtHall.Text))
            {
                MessageBox.Show("Please fill in all blanks.");
                return;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
