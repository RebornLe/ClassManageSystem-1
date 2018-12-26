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
        /// <summary>
        /// 获取全部教室信息
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 通过建筑号取得建筑的所有教室的号码
        /// </summary>
        /// <param name="bno"></param>
        /// <returns></returns>
        public List<string> bnoGetClno(string bno)
        {
            string sql = "SELECT clno FROM ClassRoom WHERE bno=@bno";
            SQLiteParameter p = new SQLiteParameter("@bno",bno);
            DataTable dt = SqlHelper.GetDataTable(sql,p);
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["clno"].ToString());
            }
            return list;
        }

        /// <summary>
        /// 根据教室号取得教室表的指定数据
        /// </summary>
        /// <param name="clno"></param>
        /// <returns></returns>
        public List<ClassRoom> clnoGetList(string clno)
        {
            string sql = "SELECT * FROM ClassRoom WHERE clno=@clno";
            SQLiteParameter p = new SQLiteParameter("@clno", clno);
            DataTable dt = SqlHelper.GetDataTable(sql,p);
            List<ClassRoom> list = new List<ClassRoom>();
            foreach (DataRow row in dt.Rows)
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

        /// <summary>
        /// 取得除特定教室号的其他教室信息
        /// </summary>
        /// <param name="clno"></param>
        /// <returns></returns>
        public List<ClassRoom> GetListExptClno(List<string> clnolist)
        {
            string sql = "SELECT * FROM ClassRoom WHERE clno NOT IN (";           
            foreach (string clno in clnolist)
            {
                sql += "'"+clno+"'," ;
            }
            sql += "'null')";                
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<ClassRoom> list = new List<ClassRoom>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new ClassRoom()
                    {
                        clno = row["clno"].ToString(),
                        bno = row["bno"].ToString(),
                        floor = row["floor"].ToString()
                    });
                }
            }
            else
            {

            }
            return list;
        }

        /// <summary>
        /// 取得除特定教室号的其他教室号
        /// </summary>
        /// <param name="clnolist"></param>
        /// <returns></returns>
        public List<string> GetClnoListExptClno(List<string> clnolist)
        {
            string sql = "SELECT * FROM ClassRoom WHERE clno NOT IN (";
            foreach (string clno in clnolist)
            {
                sql += "'" + clno + "',";
            }
            sql += "'null')";           
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<string> list = new List<string>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(row["clno"].ToString());
                }
            }
            else
            {

            }
            return list;
        }

        /// <summary>
        /// 向教室表插入一条数据
        /// </summary>
        /// <param name="classRoom"></param>
        /// <returns></returns>
        public int Insert(ClassRoom classRoom)
        {
            string sql = "INSERT INTO ClassRoom (clno,bno,floor) Values(@clno,@bno,@floor)";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@clno",classRoom.clno),
                new SQLiteParameter("@bno",classRoom.bno),
                new SQLiteParameter("@floor",classRoom.floor)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 更新教室表的一条数据  
        /// </summary>
        /// <param name="classRoom"></param>
        /// <returns></returns>
        public int Update(ClassRoom classRoom)
        {
            string sql = "UPDATE ClassRoom SET bno=@bno,floor=@floor WHERE clno=@clno";
            SQLiteParameter[] ps =
            {               
                new SQLiteParameter("@bno",classRoom.bno),
                new SQLiteParameter("@clno",classRoom.clno),
                new SQLiteParameter("@floor",classRoom.floor)
            };
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        /// <summary>
        /// 删除教室表的一条数据
        /// </summary>
        /// <param name="clno"></param>
        /// <returns></returns>
        public int Delete(string clno)
        {
            string sql = "DELETE FROM ClassRoom WHERE clno=@clno";
            SQLiteParameter p = new SQLiteParameter("@clno", clno);
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

    }
}
