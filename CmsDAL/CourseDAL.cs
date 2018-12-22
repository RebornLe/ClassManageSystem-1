using CmsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsDAL
{
    public class CourseDAL
    {
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
    }
}
