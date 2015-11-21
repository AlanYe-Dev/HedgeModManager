﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLWModLoader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Mainfrm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: "+ex.Message+Environment.NewLine + Environment.NewLine + Environment.NewLine+"ADVANCED INFO (FOR DEBUGGING): "+Environment.NewLine + Environment.NewLine + ex.ToString(),"SLW Mod Loader",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
