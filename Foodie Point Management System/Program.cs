using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodie_Point_Management_System.Admin;
using Foodie_Point_Management_System.Chef;
using Foodie_Point_Management_System.Customer;
using Foodie_Point_Management_System.Employee_Login;
using Foodie_Point_Management_System.Manager;
using Foodie_Point_Management_System.ReservationCoordinator;
using static System.Collections.Specialized.BitVector32;

namespace Foodie_Point_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CustomerLogin());
            Application.Run(new EmployeeLogin());
        }
    }
}
