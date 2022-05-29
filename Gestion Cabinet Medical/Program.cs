using System;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        /// 
        [STAThread]
        static void Main()
        {
            DevExpress.ExpressApp.FrameworkSettings.DefaultSettingsCompatibilityMode = DevExpress.ExpressApp.FrameworkSettingsCompatibilityMode.v20_1;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Forms.SplashScrean.SplashScreen());
            //Application.Run(new Forms.Consultation.Consultation_Management());
            Application.Run(new Forms.Bilans.Fiche_Bilan());
        }
    }
}
