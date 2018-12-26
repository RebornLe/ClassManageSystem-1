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
        ClassRoomDAL miDal = new ClassRoomDAL();
        public List<ClassRoom> GetList()
        {           
            return miDal.GetList();
        }
        public List<string> bnoGetClno(string bno)
        {
            return miDal.bnoGetClno(bno);
        }
        public List<ClassRoom> clnoGetList(string clno)
        {
            return miDal.clnoGetList(clno);
        }
        public List<ClassRoom> GetListExptClno(List<string> clnolist)
        {
            return miDal.GetListExptClno(clnolist);
        }
        public List<string> GetClnoListExptClno(List<string> clnolist)
        {
            return miDal.GetClnoListExptClno(clnolist);
        }
        public bool Add(ClassRoom classRoom)
        {
            return miDal.Insert(classRoom) > 0;
        }

        public bool Edit(ClassRoom classRoom)
        {
            return miDal.Update(classRoom) > 0;
        }
        public bool Remove(string clno)
        {
            return miDal.Delete(clno) > 0;
        }
    }
}
