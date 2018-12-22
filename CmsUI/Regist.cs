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
using CmsUI;

namespace CmsUI
{
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }

        UserInfoBLL uiBll = new UserInfoBLL();

        private void btnRegist_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo()
            {
                uName = txtName.Text,
                uPwd =  txtPwd.Text,
                uType = rbt1.Checked ? 1:0 //老师值为1，学生值为0
            };
            if (txtPwd.Text == txtRePwd.Text)
            {
                if (uiBll.Add(ui))
                {
                    MessageBox.Show("注册成功!");
                }
                else
                {
                    MessageBox.Show("用户名不可用，请重新输入!");
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtRePwd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("两次输入密码不一样，请确认密码!");
                txtPwd.Text = "";
                txtRePwd.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Regist_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
