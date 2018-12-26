using CmsDAL;
using CmsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsBLL
{
    public class TeacherCourseBLL
    {
        public List<TeacherCourse> GetList()
        {
            TeacherCourseDAL miDal = new TeacherCourseDAL();
            return miDal.GetList();
        }

        public List<TeacherCourse> tnoGetList(string tno)
        {
            TeacherCourseDAL miDal = new TeacherCourseDAL();
            return miDal.tnoGetList(tno);
        }

        public List<string> Weekday_Period_GetClnoList(string weekday, string period)
        {
            TeacherCourseDAL miDal = new TeacherCourseDAL();
            return miDal.Weekday_Period_GetClnoList(weekday, period);
        }
    }
}
