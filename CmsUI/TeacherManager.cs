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
            yx.Visible = false;
            js.Visible = false;
        }

        #region 教室查询子系统
        private void btnSave_Click(object sender, EventArgs e)//教室查找
        {
            string clno;
            if (rb1.Checked==true)
            {
                clno = txtName.Text;
            }
            
            else
            {
                clno = comboBox1.Text;
            }
            
            clnoLoadList(clno);          
        }

        private void clnoLoadList(string clno)
        {
            BorrowClassRoomBLL miBll = new BorrowClassRoomBLL();                      
            dgvList.DataSource = miBll.clnoGetList(clno);
            //dgvList.Columns["usestatus"].Visible = false;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)//关键词
        {
            txtName.ReadOnly = false;
            comboBox2.Visible = false;
            comboBox1.Visible = false;                  
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)//目录
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
            txtName.ReadOnly = false;
            List<BorrowClassRoom> list = new List<BorrowClassRoom>();
            dgvList.DataSource = list;           
        }


        private void TeacherManager_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dgvList.DataSource = null;
        }

        #endregion

        #region 教师查询

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//关键词按钮
        {
            jsxm.ReadOnly = false;
            yx.Visible = false;
            js.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//目录按钮
        {
            jsxm.ReadOnly = true;
            jsxm.Text = "";
            yx.Visible = true;
            js.Visible = true;
            Dept_Tname_LoadList();
        }

        private void button2_Click(object sender, EventArgs e)//查找
        {
            string tname;
            if (radioButton2.Checked == true)
            {
                tname = jsxm.Text;
            }
            else
            {
                tname = js.Text;
            }
            tnameLoadList(tname);
        }

        private void button1_Click(object sender, EventArgs e)//取消
        {
            radioButton2.Checked = true;
            jsxm.Text = "";
            jsxm.ReadOnly = false;
            yx.Visible = false;
            js.Visible = false;
            List<Teacher> list = new List<Teacher>();
            dataGridView1.DataSource = list;

            //rb2.Checked = false;
            //rb1.Checked = true;
            //txtName.Text = "";
            //comboBox2.Visible = false;
            //comboBox1.Visible = false;
            //txtName.ReadOnly = false;
            //List<BorrowClassRoom> list = new List<BorrowClassRoom>();
            //dgvList.DataSource = list;
        }

        private void tnameLoadList(string tname)//将按名取得的教师信息赋给表1的数据源
        {
            TeacherBLL miBll = new TeacherBLL();
            dataGridView1.DataSource = miBll.tnameGetList(tname);
        }

        private void Dept_Tname_LoadList()//按目录查询的两个下拉框数据源
        {
            DepartmentBLL mibll = new DepartmentBLL();
            yx.DataSource = mibll.GetAllDeptname();
            TeacherBLL miBll = new TeacherBLL();
            string deptname = yx.Text;
            js.DataSource = miBll.deptnoGetNameList(mibll.GetDeptno(deptname));
        }

        private void yx_SelectedIndexChanged(object sender, EventArgs e)//选择学院时，更新教师下拉框的数据源
        {
            DepartmentBLL mibll = new DepartmentBLL();
            //yx.DataSource = mibll.GetAllDeptname();
            TeacherBLL miBll = new TeacherBLL();
            string deptname = yx.Text;
            js.DataSource = miBll.deptnoGetNameList(mibll.GetDeptno(deptname));
        }
        #endregion

        #region 教师查询

        #endregion

        #region 课程查询

        #endregion

        #region 教室借用

        #endregion


    }
}
