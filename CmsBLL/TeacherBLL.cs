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
        TeacherDAL miDal = new TeacherDAL();
        public List<Teacher> GetList()
        {
            return miDal.GetList();
        }

        public List<Teacher> tnameGetList(string tname)
        {
            return miDal.tnameGetList(tname);
        }

        public List<string> deptnoGetNameList(string deptno)
        {
            return miDal.deptnoGetNameList(deptno);
        }

        public string tnameGetTno(string tname)
        {
            return miDal.tnameGetTno(tname);
        }

        public bool Add(Teacher teacher)
        {
            return miDal.Insert(teacher) > 0;
        }

        public bool Edit(Teacher teacher)
        {
            return miDal.Update(teacher) > 0;
        }
        public bool Remove(string tno)
        {
            return miDal.Delete(tno) > 0;
        }
    }
}
