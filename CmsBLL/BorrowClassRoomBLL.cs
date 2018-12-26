using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmsDAL;
using CmsModel;
using CmsCommon;

namespace CmsBLL
{
    public class BorrowClassRoomBLL
    {
        BorrowClassRoomDAL miDal = new BorrowClassRoomDAL();
        public List<BorrowClassRoom> Load()
        {            
            return miDal.GetList();
        }
        public List<BorrowClassRoom> clnoGetList(string clno)
        {           
            return miDal.clnoGetList(clno);
        }
        public List<string> Weekday_Period_GetClnoList(string weekday, string period)
        {          
            return miDal.Weekday_Period_GetClnoList(weekday, period);
        }
        public bool Add(BorrowClassRoom borrowClassRoom)
        {
            return miDal.Insert(borrowClassRoom) > 0;
        }
        public List<BorrowClassRoom> GetWaitList()
        {
            return miDal.GetWaitList();
        }
        public bool RemoveOne(BorrowClassRoom borrowClassRoom)
        {
            return miDal.DeleteOne(borrowClassRoom) > 0;
        }
    }
}
