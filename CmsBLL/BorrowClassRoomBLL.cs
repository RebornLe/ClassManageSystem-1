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
        public List<BorrowClassRoom> GetList()
        {
            BorrowClassRoomDAL miDal = new BorrowClassRoomDAL();
            return miDal.GetList();
        } 
    }
}
