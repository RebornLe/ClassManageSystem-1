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
                    uname = row["uname"].ToString(),                  
                    weekday = row["weekday"].ToString(),
                    period = row["period"].ToString(),
                    use = row["use"].ToString(),
                    usestatus =Convert.ToInt32(row["usestatus"]) 
                });
            }
            return list;
        }
        /// <summary>
        /// 返回指定的教室信息
        /// </summary>
        /// <param name="clno"></param>
        /// <returns></returns>
        public List<BorrowClassRoom> GetList(string Clno)
        {
            List < BorrowClassRoom > list= new List<BorrowClassRoom>();
            string sql = "SELECT * FROM BorrowClassRoom WHERE clno=@Clno";
            SQLiteParameter p = new SQLiteParameter("@Clno", Clno);
            DataTable dt = SqlHelper.GetDataTable(sql, p);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new BorrowClassRoom()
                    {
                        clno = row["clno"].ToString(),
                        uname = row["uname"].ToString(),
                        weekday = row["weekday"].ToString(),
                        period = row["period"].ToString(),
                        use = row["use"].ToString(),
                        usestatus = Convert.ToInt32(row["usestatus"])
                    });
                }
                return list;
            }
            else
            {

            }                                         
            return list;
        }
    }
}
