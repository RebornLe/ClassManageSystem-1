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
        public List<BorrowClassRoom> Load()
        {
            BorrowClassRoomDAL miDal = new BorrowClassRoomDAL();
            return miDal.GetList();
        }
        public List<BorrowClassRoom> clnoGetList(string clno)
        {
            BorrowClassRoomDAL miDal = new BorrowClassRoomDAL();
            return miDal.clnoGetList(clno);
        }
        public List<string> Weekday_Period_GetClnoList(string weekday, string period)
        {
            BorrowClassRoomDAL miDal = new BorrowClassRoomDAL();
            return miDal.Weekday_Period_GetClnoList(weekday, period);
        }
    }
}
