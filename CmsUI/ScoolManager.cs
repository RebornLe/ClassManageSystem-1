using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmsCommon;
using CmsModel;
using CmsBLL;

namespace CmsUI
{
    public partial class ScoolManager : Form
    {
        public ScoolManager()
        {
            InitializeComponent();
        }

        private void ScoolManager_Load(object sender, EventArgs e)
        {
            LoadCourseList();
            LoadClassRoomList();
            LoadTeacherList();
            LoadBorrowClassRoomList();
        }

        #region 课程信息管理


        private void LoadCourseList()//显示课程表的所有数据
        {
            CourseBLL miBll = new CourseBLL();
            CourseList.DataSource = miBll.GetList();
            DepartmentBLL departmentBLL = new DepartmentBLL();
            Deptno.DataSource = departmentBLL.GetAllDeptno();
        }

        private void CourseAdd_Click(object sender, EventArgs e)//添加按钮功能
        {
            Course course = new Course()
            {
                cno = Cno.Text,
                cname = Cname.Text,
                credit = Credit.Text,
                category = Category.Text,
                deptno = Deptno.Text
            };
            CourseBLL courseBLL = new CourseBLL();
            #region 添加
            if (CourseAdd.Text.Equals("添加"))
            {
                if (courseBLL.Add(course))
                {
                    MessageBox.Show("添加成功");

                    LoadCourseList();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            #endregion
            #region 修改
            else
            {
                if (courseBLL.Edit(course))
                {
                    MessageBox.Show("修改成功");
                    LoadCourseList();
                    Cno.ReadOnly = false;
                    CourseAdd.Text = "添加";
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            #endregion
            Cno.Text = "";
            Cname.Text = "";
            Credit.Text = "";
            Category.Text = "";
            Deptno.Text = "";
        }

        private void CourseCancel_Click(object sender, EventArgs e)//取消按钮功能
        {
            Cno.ReadOnly = false;
            Cno.Text = "";
            Cname.Text = "";
            Credit.Text = "";
            Category.Text = "";
            Deptno.Text = "";
            CourseAdd.Text = "添加";
        }

        private void CourseList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)//双击表的一行数据，将数据显示在右侧添加、修改栏
        {
            DataGridViewRow row = CourseList.Rows[e.RowIndex];
            Cno.Text = row.Cells[0].Value.ToString();
            Cno.ReadOnly = true;
            Cname.Text = row.Cells[1].Value.ToString();
            Credit.Text = row.Cells[2].Value.ToString();
            Category.Text = row.Cells[3].Value.ToString();
            Deptno.Text = row.Cells[4].Value.ToString();
            CourseAdd.Text = "修改";
        }

        private void CourseRemove_Click(object sender, EventArgs e)//删除按钮功能
        {
            var rows = CourseList.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                string cno = rows[0].Cells[0].Value.ToString();
                CourseBLL courseBLL = new CourseBLL();
                if (courseBLL.Remove(cno))
                {
                    MessageBox.Show("删除成功");
                    LoadCourseList();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行");
            }
        }

        #endregion

        #region 教室信息管理
        private void ClassRoomAdd_Click(object sender, EventArgs e)//添加、修改按钮
        {
            ClassRoom classRoom = new ClassRoom()
            {
                clno = Clno.Text,
                bno = Bno.Text,
                floor = Floor.Text
            };
            ClassRoomBLL classRoomBLL = new ClassRoomBLL();
            #region 添加
            if (ClassRoomAdd.Text.Equals("添加"))
            {
                if (classRoomBLL.Add(classRoom))
                {
                    MessageBox.Show("添加成功");

                    LoadClassRoomList();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            #endregion
            #region 修改
            else
            {
                if (classRoomBLL.Edit(classRoom))
                {
                    MessageBox.Show("修改成功");
                    LoadClassRoomList();
                    Clno.ReadOnly = false;
                    ClassRoomAdd.Text = "添加";
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            #endregion
            Clno.Text = "";
            Bno.Text = "";
            Floor.Text = "";
        }

        private void ClassRoomCancel_Click(object sender, EventArgs e)//取消按钮
        {
            Clno.ReadOnly = false;
            Clno.Text = "";
            Bno.Text = "";
            Floor.Text = "";
            ClassRoomAdd.Text = "添加";
        }

        private void ClassRoomRemove_Click(object sender, EventArgs e)//删除按钮
        {
            var rows = ClassRoomList.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                string clno = rows[0].Cells[0].Value.ToString();
                ClassRoomBLL classRoomBLL = new ClassRoomBLL();
                if (classRoomBLL.Remove(clno))
                {
                    MessageBox.Show("删除成功");
                    LoadClassRoomList();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行");
            }
        }

        private void LoadClassRoomList()//列表数据源显示所有教室数据
        {
            ClassRoomBLL classRoom = new ClassRoomBLL();
            ClassRoomList.DataSource = classRoom.GetList();
        }

        private void ClassRoomList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)//双击一行
        {
            DataGridViewRow row = ClassRoomList.Rows[e.RowIndex];
            Clno.Text = row.Cells[0].Value.ToString();
            Clno.ReadOnly = true;
            Bno.Text = row.Cells[1].Value.ToString();
            Floor.Text = row.Cells[2].Value.ToString();
            ClassRoomAdd.Text = "修改";
        }
        #endregion

        #region
        private void TeacherAdd_Click(object sender, EventArgs e)//添加、修改按钮
        {
            Teacher teacher = new Teacher()
            {
                tno = Tno.Text,
                tname = Tname.Text,
                sex = Sex.Text,
                title = Title.Text,
                deptno = DeptnoT.Text,
                tid = Tid.Text
            };
            TeacherBLL teacherBLL = new TeacherBLL();
            #region 添加
            if (TeacherAdd.Text.Equals("添加"))
            {
                if (teacherBLL.Add(teacher))
                {
                    MessageBox.Show("添加成功");

                    LoadTeacherList();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            #endregion
            #region 修改
            else
            {
                if (teacherBLL.Edit(teacher))
                {
                    MessageBox.Show("修改成功");
                    LoadTeacherList();
                    Tno.ReadOnly = false;
                    TeacherAdd.Text = "添加";
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            #endregion
            Tno.Text = "";
            Tname.Text = "";
            Sex.Text = "";
            Title.Text = "";
            DeptnoT.Text = "";
            Tid.Text = "";
        }

        private void TeacherCancel_Click(object sender, EventArgs e)//取消按钮
        {
            Tno.ReadOnly = false;
            Tno.Text = "";
            Tname.Text = "";
            Sex.Text = "";
            Title.Text = "";
            DeptnoT.Text = "";
            Tid.Text = "";
            TeacherAdd.Text = "添加";
        }

        private void TeacherRemove_Click(object sender, EventArgs e)//删除按钮
        {
            var rows = TeacherList.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                string tno = rows[0].Cells[0].Value.ToString();
                TeacherBLL teacherBLL = new TeacherBLL();
                if (teacherBLL.Remove(tno))
                {
                    MessageBox.Show("删除成功");
                    LoadTeacherList();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行");
            }
        }

        private void LoadTeacherList()//教师表数据源、院系号数据源
        {
            TeacherBLL teacherBLL = new TeacherBLL();
            TeacherList.DataSource = teacherBLL.GetList();
            DepartmentBLL departmentBLL = new DepartmentBLL();
            DeptnoT.DataSource = departmentBLL.GetAllDeptno();
        }

        private void TeacherList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)//双击表的一行数据，将数据显示在右侧添加、修改栏
        {
            DataGridViewRow row = TeacherList.Rows[e.RowIndex];
            Tno.Text = row.Cells[0].Value.ToString();
            Tno.ReadOnly = true;
            Tname.Text = row.Cells[1].Value.ToString();
            Sex.Text = row.Cells[2].Value.ToString();
            DeptnoT.Text = row.Cells[3].Value.ToString();
            Title.Text = row.Cells[4].Value.ToString();
            Tid.Text = row.Cells[5].Value.ToString();
            TeacherAdd.Text = "修改";
        }
        #endregion

        #region
        private void Agree_Click(object sender, EventArgs e)//同意申请
        {
            var rows = BorrowClassRoomList.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要同意申请吗？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                BorrowClassRoom borrowClassRoom = new BorrowClassRoom()
                {
                    clno = rows[0].Cells[0].Value.ToString(),
                    uname = rows[0].Cells[1].Value.ToString(),
                    weekday = rows[0].Cells[2].Value.ToString(),
                    period = rows[0].Cells[3].Value.ToString(),
                    use = rows[0].Cells[4].Value.ToString(),
                    usestatus = 1
                };
                BorrowClassRoomBLL borrowClassRoomBLL = new BorrowClassRoomBLL();
                if (borrowClassRoomBLL.Edit(borrowClassRoom))
                {
                    MessageBox.Show("同意申请完成");
                    LoadBorrowClassRoomList();
                }
                else
                {
                    MessageBox.Show("通过申请失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要通过申请的行");
            }

        }

        private void Remove_Click(object sender, EventArgs e)//删除申请
        {
            var rows = BorrowClassRoomList.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                BorrowClassRoom borrowClassRoom = new BorrowClassRoom()
                {
                    clno = rows[0].Cells[0].Value.ToString(),
                    uname = rows[0].Cells[1].Value.ToString(),
                    weekday = rows[0].Cells[2].Value.ToString(),
                    period = rows[0].Cells[3].Value.ToString(),
                    use = rows[0].Cells[4].Value.ToString(),
                    usestatus = Convert.ToInt32(rows[0].Cells[5].Value)
                };
                BorrowClassRoomBLL borrowClassRoomBLL = new BorrowClassRoomBLL();
                if (borrowClassRoomBLL.RemoveOne(borrowClassRoom))
                {
                    MessageBox.Show("删除成功");
                    LoadBorrowClassRoomList();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行");
            }
        }

        private void LoadBorrowClassRoomList()//教室借用信息数据源
        {
            BorrowClassRoomBLL borrowClassRoomBLL = new BorrowClassRoomBLL();
            BorrowClassRoomList.DataSource = borrowClassRoomBLL.GetWaitList();
        }

        private void BorrowClassRoomList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)//对状态类格式化，0-申请，1-同意
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = e.Value.ToString() == "1" ? "同意" : "申请";
            }
        }
        #endregion
    }
}
