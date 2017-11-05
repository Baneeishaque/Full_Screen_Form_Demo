using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Full_Screen_Form_Demo
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
            Application.Run(new Full_Screen_Form());
        }
    }
}
