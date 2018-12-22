using CmsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsDAL
{
    public class StudentsDAL
    {
        public List<Students> GetList()
        {
            string sql = "SELECT * FROM Students";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<Students> list = new List<Students>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Students()
                {         
                    sno = row["sno"].ToString(),
                    sname = row["sname"].ToString(),
                    deptno = row["deptno"].ToString(),
                    sid = row["sid"].ToString()
                });
            }
            return list;
        }
    }
}
