using CmsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CmsDAL
{
    public class CourseDAL
    {
        /// <summary>
        /// 取得所有课程数据
        /// </summary>
        /// <returns></returns>
        public List<Course> GetList()
        {
            string sql = "SELECT * FROM Course";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<Course> list = new List<Course>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Course()
                {
                    cno = row["cno"].ToString(),
                    cname=row["cname"].ToString(),
                    credit=row["credit"].ToString(),
                    category=row["category"].ToString(),
                    deptno=row["deptno"].ToString()
                });
            }
            return list;
        }

        /// <summary>
        /// 通过课程名，取得指定的课程信息
        /// </summary>
        /// <param name="cname"></param>
        /// <returns></returns>
        public List<Course> cnameGetList(string cname)
        {
            string sql = "SELECT * FROM Course WHERE cname=@cname";
            SQLiteParameter p = new SQLiteParameter("@cname", cname);
            DataTable dt = SqlHelper.GetDataTable(sql,p);
            List<Course> list = new List<Course>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Course()
                {
                    cno = row["cno"].ToString(),
                    cname = row["cname"].ToString(),
                    credit = row["credit"].ToString(),
                    category = row["category"].ToString(),
                    deptno = row["deptno"].ToString()
                });
            }
            return list;
        }

        /// <summary>
        /// 通过学院号取得学院所有开设课程名字
        /// </summary>
        /// <param name="cname"></param>
        /// <returns></returns>
        public List<string> deptnoGetcname(string deptno)
        {
            string sql = "SELECT cname FROM Course WHERE deptno=@deptno";
            SQLiteParameter p = new SQLiteParameter("@deptno", deptno);
            DataTable dt = SqlHelper.GetDataTable(sql, p);
            List<string> list = new List<string>();
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    list.Add(row["cname"].ToString());
                }               
            }
            return list;
        }

        /// <summary>
        /// 向表中插入一条数据
        /// </summary>
        /// <param name="course">课程表对象</param>
        /// <returns>影响的行数</returns>
        public int Insert(Course course)
        {
            string sql = "INSERT INTO Course (cno,cname,credit,category,deptno) Values(@cno,@cname,@credit,@category,@deptno)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@cno",course.cno),
                new SQLiteParameter("@cname",course.cname),
                new SQLiteParameter("@credit",course.credit),
                new SQLiteParameter("@category",course.category),
                new SQLiteParameter("@deptno",course.deptno)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 更新课程表数据
        /// </summary>
        /// <param name="course">课程表模型对象</param>
        /// <returns>受影响的行数</returns>
        public int Update(Course course)
        {
            string sql = "UPDATE Course SET cname=@cname,credit=@credit,category=@category,deptno=@deptno WHERE cno=@cno";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@cno",course.cno),
                new SQLiteParameter("@cname",course.cname),
                new SQLiteParameter("@credit",course.credit),
                new SQLiteParameter("@category",course.category),
                new SQLiteParameter("@deptno",course.deptno)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 根据课程号删除课程信息
        /// </summary>
        /// <param name="cno">课程号字符串</param>
        /// <returns>受影响的行数</returns>
        public int Delete(string cno)
        {
            string sql = "DELETE FROM Course WHERE cno=@cno";
            SQLiteParameter p = new SQLiteParameter("@cno", cno);
            return SqlHelper.ExecuteNonQuery(sql, p);
        }
    }
}
