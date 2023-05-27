using System;
using System.Windows.Forms;
using MyApp.Services.Factories.Implementations;

namespace MyApp.WinForm
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

            // Main relies upon the DataAccess in order to work
            Application.Run(new Main(new ServiceFactory()));
        }
    }
}
