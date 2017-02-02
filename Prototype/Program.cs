using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prototype
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

            Screens.Security.LogIn logInScreen = new Screens.Security.LogIn();
            Application.Run(logInScreen);

            if (logInScreen.isLoggedIn)
            {
                Globals.currentUsername = logInScreen.username;
                Globals.isAdmin = logInScreen.isAdmin;

                Screens.Customers.Find mainScreen = new Screens.Customers.Find();
                Application.Run(mainScreen);
            }
        }
    }
}
