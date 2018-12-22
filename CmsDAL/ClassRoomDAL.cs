using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmsModel;

namespace CmsDAL
{
    public class ClassRoomDAL
    {
        public List<ClassRoom> GetList()
        {
            string sql = "SELECT * FROM ClassRoom";
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
    }
}
