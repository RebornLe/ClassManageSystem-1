using CmsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsDAL
{
    public class TeacherCourseDAL
    {
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
    }
}
