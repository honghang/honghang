﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Myphotos
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

            #if AS_MDI_APP  
                Application.Run(new ParentForm()); 
            #else     
                Application.Run(new MainForm());
            #endif 
        }
    }
}