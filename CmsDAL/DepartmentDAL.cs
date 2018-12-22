using CmsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsDAL
{
    public class DepartmentDAL
    {
        public List<Department> GetList()
        {
            string sql = "SELECT * FROM Department";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<Department> list = new List<Department>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Department()
                {
                    deptno = row["deptno"].ToString(),
                    deptname = row["deptname"].ToString()
                });
            }
            return list;
        }
    }
}
