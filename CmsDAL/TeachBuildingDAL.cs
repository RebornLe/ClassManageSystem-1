using CmsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsDAL
{
    public class TeachBuildingDAL
    {
        public List<TeachBuilding> GetList()
        {
            string sql = "SELECT * FROM TeachBuilding";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<TeachBuilding> list = new List<TeachBuilding>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TeachBuilding()
                {
                    bno = row["bno"].ToString(),
                    bname = row["bname"].ToString()
                });
            }
            return list;
        }
    }
}
