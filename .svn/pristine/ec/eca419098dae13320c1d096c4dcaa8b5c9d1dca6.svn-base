using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CmsCommon
{
    public class Md5Helper
    {
        public static string EncryptString(string str)
        {
            //utf8,x2
            MD5 md5 = MD5.Create();
            //将字符串转化成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            //调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            //将加密结果进行转换字符串
            StringBuilder sb = new StringBuilder();
            foreach(byte b in byteNew)
            {
                //将字符串转换成16进制表示的字符串，而且恒占用两位
                sb.Append(b.ToString("x2"));
            }
            //返回加密的字符串
            return sb.ToString();
        }
    }
}
