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
        }
}
