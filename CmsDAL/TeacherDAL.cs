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
    }
}
