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
    public class TeacherDAL
    {
        /// <summary>
        /// 取得教师表所有数据
        /// </summary>
        /// <returns></returns>
        public List<Teacher> GetList()
        {
            string sql = "SELECT * FROM Teacher";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<Teacher> list = new List<Teacher>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Teacher()
                {
                    tno = row["tno"].ToString(),
                    tname = row["tname"].ToString(),
                    sex = row["sex"].ToString(),
                    deptno = row["deptno"].ToString(),
                    title = row["title"].ToString(),
                    tid = row["tid"].ToString()
                });
            }
            return list;
        }

        /// <summary>
        /// 通过教师姓名返回指定教师的信息
        /// </summary>
        /// <param name="tname"></param>
        /// <returns></returns>
        public List<Teacher> tnameGetList(string tname)
        {
            string sql = "SELECT * FROM Teacher WHERE tname=@tname";
            SQLiteParameter p = new SQLiteParameter("@tname",tname);
            DataTable dt = SqlHelper.GetDataTable(sql,p);
            List<Teacher> list = new List<Teacher>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new Teacher()
                    {
                        tno = row["tno"].ToString(),
                        tname = row["tname"].ToString(),
                        sex = row["sex"].ToString(),
                        deptno = row["deptno"].ToString(),
                        title = row["title"].ToString(),
                        tid = row["tid"].ToString()
                    });
                }
            }
            else
            {

            }    
            return list;
        }

        /// <summary>
        /// 根据学院号取得学院的所有老师姓名
        /// </summary>
        /// <param name="deptno"></param>
        /// <returns></returns>
        public List<string> deptnoGetNameList(string deptno)
        {
            string sql = "SELECT tname FROM Teacher WHERE deptno=@deptno";
            SQLiteParameter p = new SQLiteParameter("@deptno", deptno);
            DataTable dt = SqlHelper.GetDataTable(sql, p);
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["tname"].ToString());
            }
            return list;
        }

        /// <summary>
        /// 根据教师姓名取得教师号
        /// </summary>
        /// <param name="tname"></param>
        /// <returns></returns>
        public string tnameGetTno(string tname)
        {
            string sql = "SELECT tno FROM Teacher WHERE tname=@tname";
            SQLiteParameter p = new SQLiteParameter("@tname", tname);
            string list = SqlHelper.ExecuteScalar(sql, p).ToString();
            return list;
        }

        /// <summary>
        /// 教师表插入一条数据
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public int Insert(Teacher teacher)
        {
            string sql = "INSERT INTO Teacher (tno,tname,sex,deptno,title,tid) Values(@tno,@tname,@sex,@deptno,@title,@tid)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@tno",teacher.tno),
                new SQLiteParameter("@tname",teacher.tname),
                new SQLiteParameter("@sex",teacher.sex),          
                new SQLiteParameter("@deptno",teacher.deptno),
                new SQLiteParameter("@title",teacher.title),
                new SQLiteParameter("@tid",teacher.tid)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 跟新教师表的一条数据
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public int Update(Teacher teacher)
        {
            string sql = "UPDATE Teacher SET tname=@tname,sex=@sex,deptno=@deptno,title=@title,tid=@tid WHERE tno=@tno";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@tno",teacher.tno),
                new SQLiteParameter("@tname",teacher.tname),
                new SQLiteParameter("@sex",teacher.sex),
                new SQLiteParameter("@deptno",teacher.deptno),
                new SQLiteParameter("@title",teacher.title),
                new SQLiteParameter("@tid",teacher.tid)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        public int Delete(string tno)
        {
            string sql = "DELETE FROM Teacher WHERE tno=@tno";
            SQLiteParameter p = new SQLiteParameter("@tno", tno);
            return SqlHelper.ExecuteNonQuery(sql, p);
        }
    }
}
