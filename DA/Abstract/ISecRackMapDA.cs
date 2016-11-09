using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model.Entities;

namespace DA.Abstract
{
    public interface ISecRackMapDA
    {
        int LoadSecRackMapIdFromDB();
        DataTable LoadRackNameFromDB();
        DataTable LoadSectioNameFromDB();
        int SaveSecRacMapRecordsToDB(SectionRackMapMaster SecRacMap);
        int UpdateSectionRackMapDetailsToDB(SectionRackMapMaster SecRacMap);
        int DeleteSectionRackMapDetailsFromDB(int secRackId);
        DataTable LoadGridDetailsFromDB();
        string RetrieveSectionNameFromDB(int secId);
        string RetrieveRackNameFromDB(int rackId);
    }
}
