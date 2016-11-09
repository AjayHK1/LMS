using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model.Entities;
using DA.Abstract;
using DA.Repository;

namespace BL
{
    public class PurchaseBL
    {
        public int GetPurchaseId()
        {
            IPurchaseDA purchase;

            try
            {
                purchase = new PurchaseDA();
                return purchase.GetPurchaseIdFromDB();
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return -1;
            }
        }

        public bool SavePurchaseDetails(PurchaseEntities purchase,DataTable dt)
        {
            IPurchaseDA purch;

            try
            {
                purch = new PurchaseDA();
                return purch.SavePurchaseDetailsToDB(purchase, dt);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return false;
            }
        }
    }
}
