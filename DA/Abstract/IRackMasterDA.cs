using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;

namespace DA.Abstract
{
    public interface IRackMasterDA
    {
        int RetrieveRackIdFromDB();
        int SaveRackDetailsToDB(RackMaster rack);
        int UpdateRackDetailsToDB(RackMaster rack);
        int DeleteRackDetailsFromDB(int rackId);
        DataTable GetRackDetailsFromDB();
    }
}
