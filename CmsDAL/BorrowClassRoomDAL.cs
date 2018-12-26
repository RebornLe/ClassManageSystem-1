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
        public List<BorrowClassRoom> clnoGetList(string Clno)
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

        /// <summary>
        /// 通过星期和时间段取得教室号
        /// </summary>
        /// <param name="weekday"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        public List<string> Weekday_Period_GetClnoList(string weekday,string period)
        {
            List<string> list = new List<string>();
            string sql = "SELECT clno FROM BorrowClassRoom WHERE weekday=@weekday,period=@period";
            SQLiteParameter[] ps = 
            {
                new SQLiteParameter("@weekday",weekday),
                new SQLiteParameter("@period",period)
            };
            DataTable dt = SqlHelper.GetDataTable(sql, ps);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(row["clno"].ToString());
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
