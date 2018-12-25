using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Data;

namespace CmsDAL
{
    public static class SqlHelper
    {
        //从配置文本中读取连接字符串
        //private static readonly string coonstr = ConfigurationManager.ConnectionStrings["Cms"].ConnectionString;
        private static readonly string coonstr = @"Data Source =  D:\C#_code\ClassManageSystem\ClassManageSystem.sqlite; version = 3";
        //private static readonly string coonstr = @"Data Source =  E:\Microsoft Visual Studio\workspace\ClassManageSystem-1\ClassManageSystem.sqlite; version = 3";
        //执行insert update delete的方法
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] ps)
        {
            //建立连接
            using (SQLiteConnection coon = new SQLiteConnection(coonstr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, coon);
                cmd.Parameters.AddRange(ps);
                //执行命令
                coon.Open();

                //违反独立性原则过后，会抛出System.Data.SQLite.SQLiteException错误，捕获此错误，返回用户名不可用

                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch(System.Data.SQLite.SQLiteException)
                {
                    return -1;
                 
                }
            }
        }

        //获取结果集
        public static DataTable GetDataTable(string sql, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection coon = new SQLiteConnection(coonstr))
            {
                //构造适配器对象
                SQLiteDataAdapter adapater = new SQLiteDataAdapter(sql, coon);

                //构造数据表，用于接收查询结果
                DataTable dt = new DataTable();

                //添加参数
                adapater.SelectCommand.Parameters.AddRange(ps);
                //执行
                adapater.Fill(dt);
                return dt;
            }
        }

        //获取首行首列值的方法
        public static object ExecuteScalar(string sql, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection coon = new SQLiteConnection(coonstr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, coon);
                cmd.Parameters.AddRange(ps);
                coon.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
