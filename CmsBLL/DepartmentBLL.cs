using CmsDAL;
using CmsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsBLL
{
    public class DepartmentBLL
    {
        public List<Department> GetList()
        {
            DepartmentDAL miDal = new DepartmentDAL();
            return miDal.GetList();
        }
    }
}
