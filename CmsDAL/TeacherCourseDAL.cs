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
    public class TeacherCourseDAL
    {
        /// <summary>
        /// 取得所有教师开课数据
        /// </summary>
        /// <returns></returns>
        public List<TeacherCourse> GetList()
        {
            string sql = "SELECT * FROM TeacherCourse";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<TeacherCourse> list = new List<TeacherCourse>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TeacherCourse()
                {
                    clno = row["clno"].ToString(),
                    weekday = row["weekday"].ToString(),
                    period = row["period"].ToString(),
                    tno = row["tno"].ToString(),
                    cno = row["cno"].ToString()
                });
            }
            return list;
        }

        /// <summary>
        /// 根据教师号取得指定教师的开课信息
        /// </summary>
        /// <param name="tno"></param>
        /// <returns></returns>
        public List<TeacherCourse> tnoGetList(string tno)
        {
            string sql = "SELECT * FROM TeacherCourse WHERE tno=@tno";
            SQLiteParameter p = new SQLiteParameter("@tno", tno);
            DataTable dt = SqlHelper.GetDataTable(sql,p);
            List<TeacherCourse> list = new List<TeacherCourse>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TeacherCourse()
                {
                    clno = row["clno"].ToString(),
                    weekday = row["weekday"].ToString(),
                    period = row["period"].ToString(),
                    tno = row["tno"].ToString(),
                    cno = row["cno"].ToString()
                });
            }
            return list;
        }

        /// <summary>
        /// 通过星期和时间段取得教室号
        /// </summary>
        /// <param name="weekday"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        public List<string> Weekday_Period_GetClnoList(string weekday, string period)
        {
            List<string> list = new List<string>();
            string sql = "SELECT clno FROM TeacherCourse WHERE weekday=@weekday,period=@period";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@weekday",weekday),
                new SQLiteParameter("@period",period)
            };
            DataTable dt = SqlHelper.GetDataTable(sql, ps);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(row["clno"].ToString());
                }
                return list;
            }
            else
            {

            }
            return list;
        }
    }
}
