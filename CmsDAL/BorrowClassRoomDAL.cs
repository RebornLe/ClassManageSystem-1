using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmsCommon;
using CmsModel;
using System.Data.SQLite;
using System.Data;


namespace CmsDAL
{
    public class BorrowClassRoomDAL
    {
        /// <summary>
        /// 查询获取结果
        /// </summary>
        /// <returns></returns>
        public List<BorrowClassRoom> GetList()
        {
            string sql = "SELECT * FROM BorrowClassRoom";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<BorrowClassRoom> list = new List<BorrowClassRoom>();
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new BorrowClassRoom()
                {
                    clno = row["clno"].ToString(),
                    sno = row["sno"].ToString(),
                    usedate = row["usedata"].ToString(),
                    weekday = row["weekday"].ToString(),
                    period = row["period"].ToString(),
                    use = row["use"].ToString(),
                    usestatus = row["usestatus"].ToString()
                });
            }
            return list;
        }

        public int  
    }
}
