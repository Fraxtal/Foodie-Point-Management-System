using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodie_Point_Management_System.Customer;
using Foodie_Point_Management_System.Manager;

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
<<<<<<< HEAD
            Application.Run(new ManagerDashboard());
=======
            Application.Run(new ManagerReservationsReport(new EmManager(1,"e","e","e")));
>>>>>>> ab9a506878f63e35a0628d84f339fb54244c9948
        }
    }
}
