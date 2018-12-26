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
        public List<string> bnoGetClno(string bno)
        {
            ClassRoomDAL miDal = new ClassRoomDAL();
            return miDal.bnoGetClno(bno);
        }
        public List<ClassRoom> clnoGetList(string clno)
        {
            ClassRoomDAL miDal = new ClassRoomDAL();
            return miDal.clnoGetList(clno);
        }
        public List<ClassRoom> GetListExptClno(List<string> clnolist)
        {
            ClassRoomDAL miDal = new ClassRoomDAL();
            return miDal.GetListExptClno(clnolist);
        }
        public List<string> GetClnoListExptClno(List<string> clnolist)
        {
            ClassRoomDAL miBll = new ClassRoomDAL();
            return miBll.GetClnoListExptClno(clnolist);
        }
    }
}
