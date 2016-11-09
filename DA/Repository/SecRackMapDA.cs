using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model.Connection;
using Model.Entities;
using ErrorHandling;
using DA.Abstract;
using DA.Repository;

namespace DA.Repository
{
   public class SecRackMapDA : ISecRackMapDA
   {
       DBConnection conectn = new DBConnection();
       SqlCommand cmd;
       SqlDataAdapter adp;
       DataTable dt;


       public int LoadSecRackMapIdFromDB()
       {
           try
           {
               cmd = new SqlCommand("spCountSecRackMapRecords",conectn.ActiveCon());
               cmd.CommandType = CommandType.StoredProcedure;
               int count = Convert.ToInt32(cmd.ExecuteScalar());
               return count;
           }

           catch(Exception ex)
           {
               string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
               ErrorHandling.Class1.LogFileWrite(errorMessage);
               return -1;
           }

           finally
           {
               conectn.CloseCon();
           } 
       }

       public DataTable LoadRackNameFromDB()
       {
           try
           {
               dt = new DataTable();
               cmd = new SqlCommand("spLoadRackName", conectn.ActiveCon());
               cmd.CommandType = CommandType.StoredProcedure;
               adp = new SqlDataAdapter(cmd);
               adp.Fill(dt);
               return dt;
           }

           catch(Exception ex)
           {
               string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
               ErrorHandling.Class1.LogFileWrite(errorMessage);
               return dt;
           }

           finally
           {
               conectn.CloseCon();
           }
       }

       public DataTable LoadSectioNameFromDB()
       {
           try
           {
               dt = new DataTable();
               cmd = new SqlCommand("spLoadSectionName",conectn.ActiveCon());
               cmd.CommandType = CommandType.StoredProcedure;
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
               conectn.CloseCon();
           }
       }

       public int SaveSecRacMapRecordsToDB(SectionRackMapMaster SecRacMap)
       {
           try
           {
               cmd = new SqlCommand("spInsertSecRacMapDetails",conectn.ActiveCon());
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("Sr_Id", SecRacMap.sr_rac_map_id);
               cmd.Parameters.AddWithValue("Rack_Id", SecRacMap.racId);
               cmd.Parameters.AddWithValue("Sec_Id",SecRacMap.secId);
               cmd.Parameters.AddWithValue("Sr_Print", SecRacMap.print);
               cmd.Parameters.AddWithValue("Sr_Status", SecRacMap.status);
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
               conectn.CloseCon();
           }
       }

       public DataTable LoadGridDetailsFromDB()
       {
           try
           {
               dt = new DataTable();
               cmd = new SqlCommand("spLoadSecRacMapDetailsToGrid", conectn.ActiveCon());
               adp = new SqlDataAdapter(cmd);
               adp.Fill(dt);
               return dt;
           }

           catch(Exception ex)
           {
               string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
               ErrorHandling.Class1.LogFileWrite(errorMessage);
               return dt = null;
           }

           finally
           {
               conectn.CloseCon();
           }
       }

       public string RetrieveSectionNameFromDB(int sectionId)
       {
           string sectionName = "";
           try
           {
               cmd = new SqlCommand("spRetrievSectionName", conectn.ActiveCon());
               cmd.Parameters.AddWithValue("@SectionId", sectionId);
               cmd.CommandType = CommandType.StoredProcedure;
               sectionName = cmd.ExecuteScalar().ToString();
               return sectionName;
           }

           catch (Exception ex)
           {
               string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
               ErrorHandling.Class1.LogFileWrite(errorMessage);
               return sectionName;
           }

           finally
           {
               conectn.CloseCon();
           }
       }

       public string RetrieveRackNameFromDB(int rackId)
       {
           string rackName = "";
           try
           {
               cmd = new SqlCommand("spRetrieveRackName", conectn.ActiveCon());
               cmd.Parameters.AddWithValue("@RackId", rackId);
               cmd.CommandType = CommandType.StoredProcedure;
               rackName = cmd.ExecuteScalar().ToString();
               return rackName;
           }

           catch (Exception ex)
           {
               string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
               ErrorHandling.Class1.LogFileWrite(errorMessage);
               return rackName;
           }

           finally
           {
               conectn.CloseCon();
           }
       }

       public int UpdateSectionRackMapDetailsToDB(SectionRackMapMaster SecRacMap)
       {
           try
           {
               cmd = new SqlCommand("spUpdateSecRacMapDetails", conectn.ActiveCon());
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("Sr_Id", SecRacMap.sr_rac_map_id);
               cmd.Parameters.AddWithValue("Rack_Id", SecRacMap.racId);
               cmd.Parameters.AddWithValue("Sec_Id",SecRacMap.secId);
               cmd.Parameters.AddWithValue("Sr_Print", SecRacMap.print);
               cmd.Parameters.AddWithValue("Sr_Status", SecRacMap.status);
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
               conectn.CloseCon();
           }

       }

       public int DeleteSectionRackMapDetailsFromDB(int secRackId)
       {
           try
           {
               cmd = new SqlCommand("spDeleteSecRacMapDetails", conectn.ActiveCon());
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("Sr_Id", secRackId);
               int count = cmd.ExecuteNonQuery();
               return count;
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
