using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DatingManagement
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
           
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Blue");
            DevExpress.Skins.SkinManager.EnableFormSkins();


            DataLayer.ConnectionString = @"Data Source=|DataDirectory|\shiduchim.sdf;Max Database Size=2047";
    
            Application.Run(new MainForm());
        }
    }
}
