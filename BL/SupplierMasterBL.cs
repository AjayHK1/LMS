using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using ErrorHandling;
using DA.Abstract;
using DA.Repository;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations; 

namespace BL
{
    public class SupplierMasterBL
    {
        ISupplierMasterDA supplier;

        public int RetrieveSupplierID()
        {
            try
            {
                supplier = new SupplierMasterDA();
                return supplier.RetrieveSupplierIDFromDB();
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public int saveSupplierDetails(SupplierMaster supplierDetails)
        {
            try
            {
                supplier = new SupplierMasterDA();
                return supplier.saveSupplierDetailsToDB(supplierDetails);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public int updateSupplierDetails(SupplierMaster supplierDetails)
        {
            try
            {
                supplier = new SupplierMasterDA();
                return supplier.updateSupplierDetailsToDB(supplierDetails);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public int deleteSupplierDetails(int supplierId)
        {
            try
            {
                supplier = new SupplierMasterDA();
                return supplier.deleteSupplierDetailsFromDB(supplierId);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public bool ValidationOfControls(string searchId)
        {
            int result = 0;
            bool isValid;
            try
            {
                isValid = int.TryParse(searchId, out result);

                if (isValid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return false;
            }
        }

        public String ValidationOfControls(SupplierMaster supplier)
        {
            
            string errorString = "";
            int count = 0;

            try
            {
                if (supplier.supplierId == 0)
                {
                    errorString = "txtSupplierId";
                    return errorString;
                }

                else if (supplier.supplierName == "")
                {
                    errorString = "txtSupplierName";
                    return errorString;
                }

                else if (supplier.supplierName != "")
                {
                    foreach (char c in supplier.supplierName)
                    {
                        count++;
                    }

                    if (count > 10)
                    {
                        errorString = "txtSupplierName";
                        return errorString;
                    }
                }

                else if (supplier.supplierStatus == -1)
                {
                    errorString = "cmbStatus";
                    return errorString;
                }

                return errorString;

            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return errorString;
            }
        }

        public DataTable GetSupplierDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                supplier = new SupplierMasterDA();
                return supplier.GetSupplierDetailsFromDBToGrid();
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return dt;
            }
        }

        public DataTable GetSupplierDetails(int Id)
        {
            DataTable dt = new DataTable();

            try
            {
                supplier = new SupplierMasterDA();
                return supplier.GetSupplierDetailsFromDBToGrid(Id);
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
