using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.ApplicationLayer;

namespace TMS
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
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Train Management System";
            frm.Show();
            Application.Run(new SignInPage(frm));


        }
    }
}
