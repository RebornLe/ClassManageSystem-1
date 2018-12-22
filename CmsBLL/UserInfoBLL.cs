using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmsDAL;
using CmsModel;
using CmsCommon;

namespace CmsBLL
{
    public class UserInfoBLL
    {        
        UserInfoDAL udDal = new UserInfoDAL();

        public bool Add(UserInfo ui)
        {
            return udDal.Insert(ui) > 0;
        }

        public LoginState login(string name, string pwd)
        {
            UserInfo ui = udDal.getByName(name);
            if (ui == null)
            {
                return LoginState.UserNameError;
            }
            else
            {
                if (ui.uPwd == Md5Helper.EncryptString(pwd))
                {
                    //密码正确
                    return LoginState.Ok;
                }
                else
                {
                    return LoginState.PasswordError;
                }
            }
        }
    }
}
