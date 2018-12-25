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
            comboBox2.Visible = false;
            comboBox1.Visible = false;
        }
        #region 教室查询子系统
        private void btnSave_Click(object sender, EventArgs e)//教室查找
        {
            string clno = txtName.Text+comboBox1.Text;
            LoadList(clno);          
        }

        private void LoadList(string clno)
        {
            BorrowClassRoomBLL miBll = new BorrowClassRoomBLL();
            dgvList.Columns[5].Visible = false;
            dgvList.DataSource = miBll.GetList(clno);
        }
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            //comboBox2.DataSource = null;
            //comboBox1.DataSource = null;           
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.ReadOnly = true;
            comboBox2.Visible = true;
            comboBox1.Visible = true;
            TeachBuildingBLL mibll = new TeachBuildingBLL();
            comboBox2.DataSource = mibll.GetBuildingsName();
            //取得选取的教学楼名
                  
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeachBuildingBLL mibll = new TeachBuildingBLL();
            string bname = comboBox2.Text;
            ClassRoomBLL miBll = new ClassRoomBLL();
            comboBox1.DataSource = miBll.GetClno(mibll.BuildingsNameToNoumber(bname));
        }
        private void btnCancel_Click(object sender, EventArgs e)//取消按钮，还原
        {
            rb2.Checked = false;
            rb1.Checked = true;
            txtName.Text = "";
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            dgvList.DataSource = null;           
            txtName.ReadOnly = false;           
        }
        

        //private void TeacherManager_Load(object sender, EventArgs e)
        //{
        //    LoadList();
        //}
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
