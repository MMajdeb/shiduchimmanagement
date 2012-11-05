using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

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

            DataLayer.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                  
            Application.Run(new MainForm());
        }
    }
}
