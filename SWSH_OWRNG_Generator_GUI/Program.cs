using System;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator_GUI
{
    static class Program
    {
        public static MainWindow Window;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Window = new MainWindow();
            Application.Run(Window);
        }
    }
}
