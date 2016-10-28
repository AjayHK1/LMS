using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
 
namespace DA.Abstract
{
    public interface ISectionMasterDA
    {
        int SaveSectionMasterdataToDB(SectionMaster s);
        int UpdateSectionMasterdataToDB(SectionMaster s);
        int DeleteSectionMasterdataToDB(SectionMaster s);
    }
}
