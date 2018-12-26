using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmsBLL;
using CmsCommon;
using CmsModel;

namespace CmsUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Login());
            //Application.Run(new TeacherManager());
            Application.Run(new ScoolManager());
        }
    }
}
