using CmsDAL;
using CmsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsBLL
{
    public class ClassRoomBLL
    {
        public List<ClassRoom> GetList()
        {
            ClassRoomDAL miDal = new ClassRoomDAL();
            return miDal.GetList();
        }
        public List<string> GetClno(string bno)
        {
            ClassRoomDAL miDal = new ClassRoomDAL();
            return miDal.GetClno(bno);
        }
    }
}
