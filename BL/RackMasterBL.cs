using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using ErrorHandling;
using BL.Abstract;
using DA.Abstract;
using DA.Repository;


namespace BL
{
    public class RackMasterBL:IRackMasterBL
    {
        IRackMasterDA rackDA;

        public int RetrieveRackId()
        {
            try
            {
                rackDA = new RackMasterDA();
                return rackDA.RetrieveRackIdFromDB();
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public DataTable GetRackDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                rackDA = new RackMasterDA();
                return rackDA.GetRackDetailsFromDB();
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }
        }

        public int SaveRackMasterDetails(RackMaster rack)
        {
            try
            {
                //RackMasterBL rackBL = new RackMasterBL();//stackOverFlow Exception
                //A StackOverflowException exception is thrown when the execution stack overflows by having too many nested method calls. Associated Tips. Make sure you do not have an infinite loop or infinite recursion.
                rackDA = new RackMasterDA();
                return rackDA.SaveRackDetailsToDB(rack);
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public int UpdateRackMasterDetails(RackMaster rack)
        {
            try
            {
                rackDA = new RackMasterDA();
                return rackDA.UpdateRackDetailsToDB(rack);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

        }

        public int DeleteRackMasterDetails(int rackId)
        {
            try
            {
                rackDA = new RackMasterDA();
                return rackDA.DeleteRackDetailsFromDB(rackId);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }
    }
}
