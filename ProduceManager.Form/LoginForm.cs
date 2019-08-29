using ProduceManager.Core.Persistence;
using ProduceManager.Forms.Utils;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProduceManager.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Shown += LoginForm_Shown;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            Task.Run(() => ApplicationService.Instanse.GetAllBatches());
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            if (_txtUser.Text == "admin" && _txtPassword.Text == "123456")
            {
                AppHelper.MainForm = new MainForm();
                AppHelper.MainForm.Show();
                AppHelper.MainForm.FormClosed += MainForm_FormClosed;
                this.Hide();
            }
            else
            {
                MessageBoxHelper.Warn("用户名或者密码不正确。");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
