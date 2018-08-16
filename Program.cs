using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tx_sample_line_numbering_gdi
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
            Application.Run(new Form1());

        }
        //static void Main()
        //{
        //    if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form1());             // Edit as needed
        //}

        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //private static extern bool SetProcessDPIAware();


    }
}