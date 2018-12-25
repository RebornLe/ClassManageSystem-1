using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CmsModel;
using System.Data.SQLite;

namespace CmsDAL
{
    public class ClassRoomDAL
    {
        public List<ClassRoom> GetList()
        {
            string sql = "SELECT * FROM ClassRoom1";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<ClassRoom> list = new List<ClassRoom>();
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new ClassRoom()
                {
                    clno = row["clno"].ToString(),
                    bno = row["bno"].ToString(),
                    floor = row["floor"].ToString()
                });
            }
            return list;
        }
        public List<string> GetClno(string bno)
        {
            string sql = "SELECT clno FROM ClassRoom1 WHERE bno=@bno";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@bno",bno)
            };
            DataTable dt = SqlHelper.GetDataTable(sql,ps);
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["clno"].ToString());
            }
            return list;
        }
    }
}
