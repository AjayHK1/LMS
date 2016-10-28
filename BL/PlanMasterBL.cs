using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using DA.Abstract;
using DA.Repository;

namespace BL
{
    public class PlanMasterBL
    {
        public int SavePlanMasterdata(PlanMaster objPlan)
        {
            int n = 0;

            try
            {
                IPlanMasterDA p = new PlanMasterDA();
                n = Convert.ToInt32(p.SavePlanMasterdataToDB(objPlan));
            }

            catch (Exception ex)
            {

            }


            return n;

        }

        public int UpdatePlanMasterdata(PlanMaster objPlan)
        {
            int n = 0;

            try
            {
                IPlanMasterDA p = new PlanMasterDA();
                n = Convert.ToInt32(p.UpdatePlanMasterdataToDB(objPlan));
            }

            catch (Exception ex)
            {

            }


            return n;
        }

        public int DeletePlanMasterdata(PlanMaster objPlan)
        {
            int n = 0;

            try
            {
                IPlanMasterDA p = new PlanMasterDA();
                n = Convert.ToInt32(p.DeletePlanMasterdataFromDB(objPlan));
            }

            catch (Exception ex)
            {

            }


            return n;
        }
    }
}
