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
        DepartmentDAL miDal = new DepartmentDAL();
        public List<Department> GetList()
        { 
            return miDal.GetList();
        }

        public string GetDeptno(string deptname)
        {
            return miDal.GetDeptno(deptname);
        }

        public List<string> GetAllDeptname()
        {
            return miDal.GetAllDeptname();
        }
        public List<string> GetAllDeptno()
        {
            return miDal.GetAllDeptno();
        }
    }
}
