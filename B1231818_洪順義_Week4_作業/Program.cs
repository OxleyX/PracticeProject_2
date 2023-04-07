using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace B1231818_洪順義_Week4_作業
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
