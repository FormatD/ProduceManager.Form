using DevExpress.XtraSplashScreen;
using ProduceManager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProduceManager.Forms.Utils
{
    public class WaitHelper : IDisposable
    {
        private static WaitHelper _instance;

        public static IDisposable ShowWaitForm(string caption, Form target)
        {
            if (_instance != null)
                CloseWaitForm();

            _instance = new WaitHelper();
            if (SplashScreenManager.Default == null)
                SplashScreenManager.ShowDefaultWaitForm(target ?? AppHelper.MainForm, false, false, false, 250, caption);

            return _instance;
        }

        public static void CloseWaitForm()
        {
            var ssm = SplashScreenManager.Default;
            if (ssm != null && ssm.ActiveSplashFormTypeInfo != null && ssm.ActiveSplashFormTypeInfo.Mode == Mode.WaitForm)
                SplashScreenManager.CloseForm(false, 750, AppHelper.MainForm);
        }

        public void Dispose()
        {
            CloseWaitForm();
        }
    }

    public class AppHelper
    {
        public static MainForm MainForm { get; set; }
    }
}
