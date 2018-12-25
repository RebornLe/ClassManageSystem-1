﻿using CmsDAL;
using CmsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsBLL
{
    public class TeachBuildingBLL
    {
        public List<TeachBuilding> GetList()
        {
            TeachBuildingDAL miDal = new TeachBuildingDAL();
            return miDal.GetList();
        }
        public List<string> GetBuildingsName()
        {
            TeachBuildingDAL miDal = new TeachBuildingDAL();
            return miDal.GetBuildingsName();
        }
        public string BuildingsNameToNoumber(string bname)
        {
            TeachBuildingDAL miDal = new TeachBuildingDAL();
            return miDal.BuildingsNameToNoumber(bname);
        }
    }
}
