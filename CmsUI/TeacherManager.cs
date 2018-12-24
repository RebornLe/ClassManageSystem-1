using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmsBLL;
using System.Windows.Forms;
using CmsModel;

namespace CmsUI
{
    public partial class TeacherManager : Form
    {
        public TeacherManager()
        {
            InitializeComponent();
        }
        #region 教室查询子系统
        private void btnSave_Click(object sender, EventArgs e)//教室查找
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox2.DataSource = null;

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.ReadOnly = true;
            TeachBuildingBLL mibll = new TeachBuildingBLL();
            comboBox2.DataSource = mibll.GetBuildingsName();
            //取得选取的教学楼名
            string bname = comboBox2.Text;
           
            //comboBox1.DataSource =;

        }
        #endregion
        #region 教师查询

        #endregion
        #region 教师查询

        #endregion
        #region 课程查询

        #endregion
        #region 教室借用

        #endregion
    }
}
