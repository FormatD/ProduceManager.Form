using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProduceManager.Form.Utils
{
    public static class UsertControlExtension
    {
        public static T FindChildren<T>(this Control control) where T : Control
        {
            if (control is T)
                return (T)control;

            foreach (Control child in control.Controls)
            {
                var target = child.FindChildren<T>();
                if (target != null)
                    return target;
            }

            return null;
        }

    }
}
