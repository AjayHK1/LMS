using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;


namespace DA.Abstract
{
    public interface IPlanMasterDA
    {
        int SavePlanMasterdataToDB(PlanMaster objPlan);
        int UpdatePlanMasterdataToDB(PlanMaster objPlan);
        int DeletePlanMasterdataFromDB(PlanMaster objPlan);
    }
}
