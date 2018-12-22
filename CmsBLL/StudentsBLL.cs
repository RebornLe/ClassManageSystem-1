using CmsDAL;
using CmsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsBLL
{
    public class StudentsBLL
    {
        public List<Students> GetList()
        {
            StudentsDAL miDal = new StudentsDAL();
            return miDal.GetList();
        }
    }
}
