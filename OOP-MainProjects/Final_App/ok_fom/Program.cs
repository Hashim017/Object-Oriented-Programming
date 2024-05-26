using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ok_fom
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
            AdminDL.loadAdmins();
            FlightsDataDL.loadFlights();
            CustomerDL.loadUsers(); 
            Application.Run(new LoadingPage());
            Application.Run(new MainPage());
        }
    }
}
