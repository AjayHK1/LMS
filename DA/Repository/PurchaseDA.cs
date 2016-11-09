using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model.Entities;
using Model.Connection;
using DA.Abstract;




namespace DA.Repository
{
    public class PurchaseDA : IPurchaseDA
    {
        DBConnection conectn = new DBConnection();
        SqlDataAdapter adp;
        SqlCommand cmd;
        DataTable dt;

        public int GetPurchaseIdFromDB()
        {
            try
            {
                cmd = new SqlCommand("spCountPurchaseDetails", conectn.ActiveCon());
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
                conectn.CloseCon();
            }
        }

        public bool SavePurchaseDetailsToDB(PurchaseEntities purchase,DataTable dt)
        {

            try
            {
                cmd = new SqlCommand("spInsertPurchaseDetails", conectn.ActiveCon());
                cmd.Parameters.Add("@PurId", purchase.purchaseId);
                cmd.Parameters.Add("@PurDate", purchase.purcahseDate);
                cmd.Parameters.Add("@Pur_From", purchase.purchaseFrom);
                cmd.Parameters.Add("@Pur_Status", purchase.purchaseStatus);
                 
                cmd.Parameters.AddWithValue("@SubDetails", dt);
                cmd.CommandType = CommandType.StoredProcedure;
                ///////////////////////////////////////////////////////////////
                //SqlParameter parameter = new SqlParameter("@SubDetails", SqlDbType.Structured);
                // parameter.Value = dt;
                
                 
                 int count = cmd.ExecuteNonQuery();
                 
                //////////////////////////////////////////////////////////////
                return true;
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return false;
            }

            finally
            {
                conectn.CloseCon();
            }
        }
    }
}
