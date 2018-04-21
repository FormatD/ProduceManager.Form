using ProduceManager.Forms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProduceManager.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            if (_txtUser.Text == "admin" && _txtPassword.Text == "123456")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBoxHelper.Warn("用户名或者密码不正确。");
            }
        }
    }
}
