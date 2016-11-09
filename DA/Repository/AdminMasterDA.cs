using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using Model.Connection;
using DA.Abstract;
using System.Data;
using System.Data.SqlClient;
using ErrorHandling;


namespace DA.Repository
{
    public class AdminMasterDA:IAdminMasterDA
    {
        DBConnection connctn = new DBConnection();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter adp;
        int n = 0;

        public DataTable LoadGridDetailsFromDB()
        {
            try
            {
                cmd = new SqlCommand("spLoadProfileDataToGrid", connctn.ActiveCon());
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }

            finally
            {
                connctn.CloseCon();
            }
        }


        public int SaveProfileDataToDB(AdminMaster admin)
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand("spInsProfileMasterDetails", connctn.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Pro_User_Id", admin.ProUserId);
                cmd.Parameters.AddWithValue("Pro_Name", admin.ProUserName);
                cmd.Parameters.AddWithValue("Pro_Email", admin.EMail);
                cmd.Parameters.AddWithValue("Pro_Mobile", admin.Mobile);
                cmd.Parameters.AddWithValue("Pro_Password", admin.Password);
                cmd.Parameters.AddWithValue("Pro_Address", admin.Address);
                cmd.Parameters.AddWithValue("Pro_Role", admin.Role);
                cmd.Parameters.AddWithValue("Pro_Status", admin.Status);
                return cmd.ExecuteNonQuery();//Think Instead of using n
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }


            finally
            {
                connctn.CloseCon();
            }

            
        }


        public int UpdateProfileDataToDB(AdminMaster admin)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateProfileMasterDetails", connctn.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Pro_User_Id", admin.ProUserId);
                cmd.Parameters.AddWithValue("Pro_Name", admin.ProUserName);
                cmd.Parameters.AddWithValue("Pro_Email", admin.EMail);
                cmd.Parameters.AddWithValue("Pro_Mobile", admin.Mobile);
                cmd.Parameters.AddWithValue("Pro_Password", admin.Password);
                cmd.Parameters.AddWithValue("Pro_Address", admin.Address);
                cmd.Parameters.AddWithValue("Pro_Role", admin.Role);
                cmd.Parameters.AddWithValue("Pro_Status", admin.Status);
                return cmd.ExecuteNonQuery();//Think Instead of using n
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }


            finally
            {
                connctn.CloseCon();
            }


        }

        public int DeleteProfileDetailsFromDB(AdminMaster admin)
        {
            try
            {
                cmd = new SqlCommand("spDeleteProfileMaster",connctn.ActiveCon());//Pro_User_Id
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pro_User_Id",admin.ProUserId);
                return cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

            finally
            {
                connctn.CloseCon();
            }

        }


        public int RetrieveRoleIdFromDB(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spRetrieveRoleId", connctn.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", name);
                n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

            finally
            {
                connctn.CloseCon();
            }
        }

        public int RetrieveProUserIdFromDB()
        {
            try
            {
                cmd = new SqlCommand("spCountProfileMaster", connctn.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

            finally
            {
                connctn.CloseCon();
            }
        }

        public DataTable LoadRoleNameToCombo()
        {
            try
            {
                cmd = new SqlCommand("spLoadRoleName", connctn.ActiveCon());
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;//whattoo add here
            }

            finally
            {
                connctn.CloseCon();
            }
        }

        public string RetrieveRoleNameFromDB(int id)
        {
            try
            {
                cmd = new SqlCommand("spRetrieveRoleName", connctn.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleId", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                return name;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return null;
            }

            finally
            {
                connctn.CloseCon();
            }

        }

        
    }
}
