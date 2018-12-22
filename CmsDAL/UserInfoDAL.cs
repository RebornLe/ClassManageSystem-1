using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CmsModel;
using System.Data.SQLite;
using CmsCommon;


namespace CmsDAL
{
    public partial class UserInfoDAL
    {
        /// <summary>
        /// 注册用户时候，将新注册用户加入表中
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        public int Insert(UserInfo ui)
        {
            string sql = "insert into UserInfo(uName, uPwd, uType) values(@name, @pwd, @type)";
            SQLiteParameter[] p =
                {
                new SQLiteParameter("@name", ui.uName),
                new SQLiteParameter("@pwd", Md5Helper.EncryptString(ui.uPwd)),
                new SQLiteParameter("type", ui.uType)
            };
            //执行插入操作
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        /// <summary>
        /// 进行查找，返回UserInfo对象列表
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> getList()
        {
            string sql = "select * from UserInfo";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<UserInfo> list = new List<UserInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new UserInfo()
                {
                    uId = Convert.ToInt32(row["uId"]),
                    uName = row["uName"].ToString(),
                    uPwd = row["uPwd"].ToString(),
                    uType = Convert.ToInt32(row["uType"])
                });
            }
            return list;
        }

        public UserInfo getByName(string name)
        {
            UserInfo ui = null;
            string sql = "select * from UserInfo where Uname = @name";
            SQLiteParameter p = new SQLiteParameter("@name", name);
            //执行查询得到结果
            DataTable dt = SqlHelper.GetDataTable(sql, p);
            //判断根据用户名查询是否有对象
            if (dt.Rows.Count > 0)
            {
                ui = new UserInfo()
                {
                    uId = Convert.ToInt32(dt.Rows[0][0]),
                    uName = dt.Rows[0][1].ToString(),
                    uPwd = dt.Rows[0][2].ToString(),
                    uType = Convert.ToInt32(dt.Rows[0][3])                    
                };

            }
            else
            {

            }
            return ui;
        }
    }
}
