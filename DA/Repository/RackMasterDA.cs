using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model.Entities;
using Model.Connection;
using DA.Abstract;
using DA.Repository;
using ErrorHandling;

namespace DA.Repository
{
    public class RackMasterDA:IRackMasterDA
    {
        SqlCommand cmd;
        DataTable dt;
        DBConnection con = new DBConnection();

        public int RetrieveRackIdFromDB()
        {
            try
            {
                cmd = new SqlCommand("spCountRackDetails", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

            finally
            {
                con.CloseCon();
            }
        }

        public int SaveRackDetailsToDB(RackMaster rack)
        {
            try
            {
                cmd = new SqlCommand("spInsertRackDetails", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Rack_Id", rack.rackId);
                cmd.Parameters.AddWithValue("Rack_Name", rack.rackName);
                cmd.Parameters.AddWithValue("Rack_Status", rack.rackStatus);
                int count = cmd.ExecuteNonQuery();
                return count;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

            finally
            {
                con.CloseCon();
            }
        }

        public int UpdateRackDetailsToDB(RackMaster rack)
        {
            try
            {
                cmd = new SqlCommand("spUpdateRackDetails", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Rack_Id", rack.rackId);
                cmd.Parameters.AddWithValue("Rack_Name", rack.rackName);
                cmd.Parameters.AddWithValue("Rack_Status", rack.rackStatus);
                int count = cmd.ExecuteNonQuery();
                return count;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

            finally
            {
                con.CloseCon();
            }
        }

        public int DeleteRackDetailsFromDB(int rackId)
        {
            try
            {
                cmd = new SqlCommand("spDeleteRackDetails", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Rack_Id",rackId);
                int count = cmd.ExecuteNonQuery();
                return count;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

            finally
            {
                con.CloseCon();
            }
        }

        public DataTable GetRackDetailsFromDB()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("spLoadRackMasterDetailsToGrid", con.ActiveCon());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
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
                con.CloseCon();
            }
        }
    }
}
