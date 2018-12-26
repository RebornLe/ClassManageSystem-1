using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmsDAL;
using CmsModel;

namespace CmsBLL
{
    public class CourseBLL
    {
        CourseDAL miDal = new CourseDAL();
        public List<Course> GetList()
        {            
            return miDal.GetList();
        }

        public List<Course> cnameGetList(string cname)
        {
            return miDal.cnameGetList(cname);
        }

        public List<string> deptnoGetcname(string deptno)
        {
            return miDal.deptnoGetcname(deptno);
        }

        public bool Add(Course course)
        {
            return miDal.Insert(course) > 0;
        }

        public bool Edit(Course course)
        {
            return miDal.Update(course) > 0;
        }
        public bool Remove(string cno)
        {
            return miDal.Delete(cno)>0;
        }
    }
}
