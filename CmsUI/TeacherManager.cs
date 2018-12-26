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
            yxm.Visible = false;
            kc.Visible = false;
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
            ClassRoomBLL classRoomBLL = new ClassRoomBLL();
            dataGridView5.DataSource = classRoomBLL.clnoGetList(clno);
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
            comboBox1.DataSource = miBll.bnoGetClno(mibll.BuildingsNameToNoumber(bname));
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
            List<ClassRoom> list2 = new List<ClassRoom>();
            dataGridView5.DataSource = list2;
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
            tnoLoadTeachCourseList(tname);
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
            List<TeacherCourse> list2 = new List<TeacherCourse>();
            dataGridView4.DataSource = list2;
        }

        private void tnameLoadList(string tname)//将按名取得的教师信息赋给表1的数据源
        {
            TeacherBLL miBll = new TeacherBLL();
            dataGridView1.DataSource = miBll.tnameGetList(tname);
        }

        private void tnoLoadTeachCourseList(string tname)//指定教师开课信息表数据源
        {
            TeacherBLL miBll = new TeacherBLL();
            TeacherCourseBLL mibll = new TeacherCourseBLL();
            dataGridView4.DataSource = mibll.tnoGetList(miBll.tnameGetTno(tname));    
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

        #region 课程查询

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//关键词
        {
            kcmc.ReadOnly = false;
            yxm.Visible = false;
            kc.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//目录
        {
            kcmc.ReadOnly = true;
            kcmc.Text = "";
            yxm.Visible = true;
            kc.Visible = true;
            Deptname_Cname_LoadList();
        }

        private void Deptname_Cname_LoadList()//设置目录查询的两个下拉框的数据源
        {
            DepartmentBLL departmentBLL = new DepartmentBLL();
            yxm.DataSource = departmentBLL.GetAllDeptname();
            CourseBLL courseBLL = new CourseBLL();
            kc.DataSource = courseBLL.deptnoGetcname(departmentBLL.GetDeptno(yxm.Text));
        }

        private void button4_Click(object sender, EventArgs e)//查找
        {
            string cname;
            if (radioButton4.Checked == true)
            {
                cname = kcmc.Text;
            }
            else
            {
                cname = kc.Text;
            }
            cnameLoadList(cname);
        }

        private void cnameLoadList(string cname)
        {
            CourseBLL miBll = new CourseBLL();
            dataGridView2.DataSource = miBll.cnameGetList(cname);
        }

        private void button3_Click(object sender, EventArgs e)//取消
        {
            radioButton4.Checked = true;
            kcmc.Text = "";
            kcmc.ReadOnly = false;
            yxm.Visible = false;
            kc.Visible = false;
            List<Course> list = new List<Course>();
            dataGridView2.DataSource = list;
        }

        private void yxm_SelectedIndexChanged(object sender, EventArgs e)//院系改变，课程下拉框数据源改变
        {
            DepartmentBLL departmentBLL = new DepartmentBLL();
            CourseBLL courseBLL = new CourseBLL();
            kc.DataSource = courseBLL.deptnoGetcname(departmentBLL.GetDeptno(yxm.Text));
        }



        #endregion

        #region 教室借用

        #endregion

        private void button7_Click(object sender, EventArgs e)//借用按钮
        {

        }

        private void Weekday_Period_LoadList()//通过星期和时间段的选择，跟新表的数据源
        {
            TeacherCourseBLL teacherCourseBLL = new TeacherCourseBLL();            
            BorrowClassRoomBLL borrowClassRoomBLL = new BorrowClassRoomBLL();
            borrowClassRoomBLL.Weekday_Period_GetClnoList(xq.Text, jysj.Text).AddRange(
                teacherCourseBLL.Weekday_Period_GetClnoList(xq.Text, jysj.Text)
                ); 

        }

        private void button5_Click(object sender, EventArgs e)//取消按钮
        {
            xq.Text = "";
            jysj.Text = "";
            jyjs.Text = "";
            syzxm.Text = "";
            ytsm.Text = "";
            List<ClassRoom> list = new List<ClassRoom>();
            dataGridView3.DataSource = list;
        }

        private void xq_SelectedIndexChanged(object sender, EventArgs e)//星期下拉选择框
        {
            Weekday_Period_LoadList();
        }

        private void jysj_SelectedIndexChanged(object sender, EventArgs e)//借用时间下拉选择框
        {
            Weekday_Period_LoadList();
        }

        private void jyjs_SelectedIndexChanged(object sender, EventArgs e)//教室号下拉框
        {

        }
    }
}
