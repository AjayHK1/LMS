using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model.Entities;
using DA.Abstract;
using DA.Repository;
using ErrorHandling;



namespace BL
{
    public class AdminMasterBL:IAdminMasterBL
    {
        IAdminMasterDA adminDA = new AdminMasterDA();
        DataTable dt = new DataTable();
        int roleId;

        public int SaveProfileData(AdminMaster admin)
        {
            
            try
            {
                return adminDA.SaveProfileDataToDB(admin);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

            // adminDA.SaveProfileDataToDB(admin);
            
        }

        public int UpdateProfileData(AdminMaster admin)
        {
            try
            {
                return adminDA.UpdateProfileDataToDB(admin);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public int DeleteProfileDetails(AdminMaster admin)
        {
            return adminDA.DeleteProfileDetailsFromDB(admin);
        }

        public int RetrieveRoleId(string name)
        {
            try
            {
                roleId = adminDA.RetrieveRoleIdFromDB(name);
                return roleId;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public int RetrieveProUserId()
        {
            adminDA = new AdminMasterDA();
            try
            {
                int n = adminDA.RetrieveProUserIdFromDB();
                return n;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public DataTable LoadRoleName()
        {
            dt = null;
            try
            {
                
                dt = adminDA.LoadRoleNameToCombo();
                return dt;
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }
        }

        public DataTable LoadGridDetails()
        {
            try
            {
               dt = adminDA.LoadGridDetailsFromDB();
               return dt;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }
        }

        public string RetrieveRoleName(int id)
        {
           return adminDA.RetrieveRoleNameFromDB(id);
        }
    }
}
