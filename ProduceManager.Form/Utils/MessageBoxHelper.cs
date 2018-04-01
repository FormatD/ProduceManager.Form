using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProduceManager.Form.Utils
{
    public static class MessageBoxHelper
    {

        public static bool Warn(string message, string caption = "警告")
        {
            return XtraMessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        public static bool Question(string message, string caption = "询问")
        {
            return XtraMessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
