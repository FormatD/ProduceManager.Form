using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Threading;
using System.Globalization;
using ProduceManager.Forms.Utils;

namespace ProduceManager.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-Hans");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");

            Application.Run(AppHelper.MainForm = new MainForm());
        }
    }
}