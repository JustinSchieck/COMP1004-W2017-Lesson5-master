using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson5
{
    public static class Program
    {
        // declared public static Form - Application GLOBAL
        public static SplashForm MySplashForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize SplashForm and CalculatorForm
            Program.MySplashForm = new SplashForm();

            Application.Run(Program.MySplashForm);
        }
    }
}
