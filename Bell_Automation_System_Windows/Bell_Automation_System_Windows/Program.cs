﻿using System;
using System.Collections.Generic;
//using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Bell_Automation_System_Windows
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
            Application.Run(new Main_Form());
        }
    }
}
