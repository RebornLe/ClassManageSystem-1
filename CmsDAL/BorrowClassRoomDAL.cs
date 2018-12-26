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
        /// <returns>表所有信息</returns>
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
        /// <param name="clno">教室号字符串</param>
        /// <returns>指定教室信息</returns>
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
        /// <param name="weekday">星期的字符串</param>
        /// <param name="period">时间段字符串</param>
        /// <returns>特定的教室号</returns>
        public List<string> Weekday_Period_GetClnoList(string weekday,string period)
        {
            List<string> list = new List<string>();
            string sql = "SELECT clno FROM BorrowClassRoom WHERE weekday=@weekday AND period=@period";
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

        /// <summary>
        /// 插入一条借用教室数据
        /// </summary>
        /// <param name="borrowClassRoom">BorrowClassRoom对象</param>
        /// <returns>受影响行数</returns>
        public int Insert(BorrowClassRoom borrowClassRoom)
        {
            string sql = "INSERT INTO BorrowClassRoom (clno,uname,weekday,period,use,usestatus) Values(@clno,@uname,@weekday,@period,@use,@usestatus)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@clno",borrowClassRoom.clno),
                new SQLiteParameter("@uname",borrowClassRoom.uname),
                new SQLiteParameter("@weekday",borrowClassRoom.weekday),
                new SQLiteParameter("@period",borrowClassRoom.period),
                new SQLiteParameter("@use",borrowClassRoom.use),
                new SQLiteParameter("@usestatus",borrowClassRoom.usestatus)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 取得等待申请审核的数据
        /// </summary>
        /// <returns></returns>
        public List<BorrowClassRoom> GetWaitList()
        {
            string sql = "SELECT * FROM BorrowClassRoom WHERE usestatus='0'";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<BorrowClassRoom> list = new List<BorrowClassRoom>();
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

        /// <summary>
        /// 删除一个指定数据
        /// </summary>
        /// <param name="borrowClassRoom"></param>
        /// <returns></returns>
        public int DeleteOne(BorrowClassRoom borrowClassRoom)
        {
            string sql = "DELETE FROM BorrowClassRoom WHERE clno=@clno AND uname=@uname AND weekday=@weekday AND period=@period AND use=@use AND usestatus=@usestatus";
            SQLiteParameter[] ps = {
                new SQLiteParameter("@clno",borrowClassRoom.clno),
                new SQLiteParameter("@uname",borrowClassRoom.uname),
                new SQLiteParameter("@weekday",borrowClassRoom.weekday),
                new SQLiteParameter("@period",borrowClassRoom.period),
                new SQLiteParameter("@use",borrowClassRoom.use),
                new SQLiteParameter("@usestatus",borrowClassRoom.usestatus)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }
    }
}
