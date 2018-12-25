using CmsModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsDAL
{
    public class TeachBuildingDAL
    {       
        /// <summary>
        /// 查询教学楼信息
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 获取教学楼名
        /// </summary>
        /// <returns></returns>
        public List<string> GetBuildingsName()
        {
            string sql = "SELECT bname FROM TeachBuilding";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["bname"].ToString());
            }
            return list;
        }
        /// <summary>
        /// 根据教学楼姓名取得教学楼号
        /// </summary>
        /// <param name="bname"></param>
        /// <returns></returns>
        public string BuildingsNameToNoumber(string bname)
        {
            string sql = "SELECT bno FROM TeachBuilding WHERE bname=@bname";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@bname",bname)
            };
            DataTable dt = SqlHelper.GetDataTable(sql, ps);
            string bno=dt.ToString();          
            return bno;
        }
    }
}
