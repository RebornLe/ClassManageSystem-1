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
    public class DepartmentDAL
    {
        /// <summary>
        /// 取得学院表的全部数据
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 取得所有学院名
        /// </summary>
        /// <param name="deptname"></param>
        /// <returns></returns>
        public List<string> GetAllDeptname()
        {
            string sql = "SELECT deptname FROM Department";         
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["deptname"].ToString());
            }
            return list;
        }
        /// <summary>
        /// 通过学院名取得学院的号码
        /// </summary>
        /// <param name="deptname"></param>
        /// <returns></returns>
        public string GetDeptno(string deptname)
        {
            string sql = "SELECT deptno FROM Department WHERE deptname=@deptname";
            SQLiteParameter p = new SQLiteParameter("@deptname", deptname);
            DataTable dt = SqlHelper.GetDataTable(sql, p);
            string list = dt.Rows[0]["deptno"].ToString();
            return list;
        }
    }
}
