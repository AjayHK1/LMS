using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model.Entities;
using BL.Abstract;
using DA.Abstract;
using DA.Repository;

namespace BL
{
    public class SecRackMapBL
    {
        ISecRackMapDA sectnDA;
        DataTable dt;

        public int LoadSecRackMapId()
        {
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.LoadSecRackMapIdFromDB();
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public DataTable LoadRackName()
        {
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.LoadRackNameFromDB();
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }
        }

        public DataTable LoadSectionName()
        {
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.LoadSectioNameFromDB();
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }
        }

        public int SaveSecRacMapRecords(SectionRackMapMaster SecRacMap)
        {
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.SaveSecRacMapRecordsToDB(SecRacMap);
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public int UpdateSecRacMapRecords(SectionRackMapMaster SecRacMap)
        {
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.UpdateSectionRackMapDetailsToDB(SecRacMap);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public DataTable LoadGridDetails()
        {
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.LoadGridDetailsFromDB();
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt = null;
            }
        }

        public string RetrieveSectionName(int sectionId)
        {
            string sectionName = "";
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.RetrieveSectionNameFromDB(sectionId);
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return sectionName;
            }
        }

        public string RetrieveRackName(int rackId)
        {
            string rackName = "";
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.RetrieveRackNameFromDB(rackId); 
            }
            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return rackName;
            }
        }

        public int DeleteSectionRackMapDetails(int secRackId)
        {
            try
            {
                sectnDA = new SecRackMapDA();
                return sectnDA.DeleteSectionRackMapDetailsFromDB(secRackId); 
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }
    }
}
