using CmsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsDAL
{
    public class TeacherDAL
    {
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
    }
}
