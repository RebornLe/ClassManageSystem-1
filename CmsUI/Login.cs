using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmsBLL;
using CmsModel;

namespace CmsUI
{
    public partial class Login : Form
    {
        UserInfoBLL ub = new UserInfoBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string pwd = textPwd.Text;
            LoginState ls =  ub.login(name, pwd);
            switch (ls)
            {
                case LoginState.Ok:
                    break;
                case LoginState.PasswordError:
                    MessageBox.Show("密码错误!");
                    textName.Text = "";
                    textPwd.Text = "";
                    break;
                case LoginState.UserNameError:
                    MessageBox.Show("用户名错误");
                    textName.Text = "";
                    textPwd.Text = "";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regist ri = new Regist();
            //textName.Enabled = false;
            //textPwd.Enabled = false;
            //btnLogin.Enabled = false;
            //btnClose.Enabled = false;
            ri.Show();
        }
    }
}
