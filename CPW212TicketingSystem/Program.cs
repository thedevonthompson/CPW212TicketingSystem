using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPW212TicketingSystem.Forms;

namespace CPW212TicketingSystem
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
            // Run login form
            FrmLogin login = new FrmLogin();
            // check to see iff credentials match if so run the main form, if the user Closes out before logging in it will end the program
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
