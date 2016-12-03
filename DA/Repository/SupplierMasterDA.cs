using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using DA.Abstract;
using DA.Repository;
using Model.Connection;
using System.Data;
using System.Data.SqlClient;
using ErrorHandling;

namespace DA.Repository
{
    public class SupplierMasterDA : ISupplierMasterDA
    {
        DBConnection conectn = new DBConnection();
        DataTable dt;
        SqlDataAdapter adp;
       public int RetrieveSupplierIDFromDB()
       {
           try
           {
               using (SqlCommand cmd = new SqlCommand("spRetrieveSupplierId", conectn.ActiveCon()))
               {
                   cmd.CommandType = CommandType.StoredProcedure;
                   //SqlDataAdapter adp = new SqlDataAdapter(cmd);
                   //dt = new DataTable();
                   //adp.Fill(dt);
                   int id = Convert.ToInt32(cmd.ExecuteScalar());
                   return id;
               }
           }

           catch(Exception ex)
           {
               string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
               ErrorHandling.Class1.LogFileWrite(errorMessage);
               return -1;
           }

       }

        public int saveSupplierDetailsToDB(SupplierMaster supplier)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spSaveSupplierDetails", conectn.ActiveCon()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", supplier.supplierId);
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.supplierName);
                    cmd.Parameters.AddWithValue("@SupplierStatus", supplier.supplierStatus);
                    int count = cmd.ExecuteNonQuery();
                    return count;
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }

        }

        public int updateSupplierDetailsToDB(SupplierMaster supplier)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateSupplierDetails", conectn.ActiveCon()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", supplier.supplierId);
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.supplierName);
                    cmd.Parameters.AddWithValue("@SupplierStatus", supplier.supplierStatus);
                    int count = cmd.ExecuteNonQuery();
                    return count;
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public int deleteSupplierDetailsFromDB(int supplierId)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteSupplierDetails", conectn.ActiveCon()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                    int count = cmd.ExecuteNonQuery();
                    return count;
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public DataTable GetSupplierDetailsFromDBToGrid()
        {
            dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("spLoadSupplierDetailsTOGrid", conectn.ActiveCon()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    return dt;
                }
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }
        }

        public DataTable GetSupplierDetailsFromDBToGrid(int Id)
        {
            dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("spSearchSupplierById", conectn.ActiveCon()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", Id);
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    return dt;
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }
        }
    }
}
