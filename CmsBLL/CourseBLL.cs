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
        public List<Course> GetList()
        {
            CourseDAL miDal = new CourseDAL();
            return miDal.GetList();
        }

        public List<Course> cnameGetList(string cname)
        {
            CourseDAL miDal = new CourseDAL();
            return miDal.cnameGetList(cname);
        }

        public List<string> deptnoGetcname(string deptno)
        {
            CourseDAL miDal = new CourseDAL();
            return miDal.deptnoGetcname(deptno);
        }
    }
}
