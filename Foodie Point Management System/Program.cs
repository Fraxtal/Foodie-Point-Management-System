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
            Application.Run(new ManagerReservationsReport(new EmManager(1,"e","e","e")));
        }
    }
}
