using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using System.Data;



namespace DA.Abstract
{
    public interface IPurchaseDA
    {
        int GetPurchaseIdFromDB();
        bool SavePurchaseDetailsToDB(PurchaseEntities purchase,DataTable dt);
    }
}
