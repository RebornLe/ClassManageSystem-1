using CmsDAL;
using CmsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsBLL
{
    public class TeacherBLL
    {
        public List<Teacher> GetList()
        {
            TeacherDAL miDal = new TeacherDAL();
            return miDal.GetList();
        }
    }
}
