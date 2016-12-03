using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DA.Abstract
{
    public interface ISupplierMasterDA
    {
       int RetrieveSupplierIDFromDB();
       int saveSupplierDetailsToDB(SupplierMaster supplier);
       int updateSupplierDetailsToDB(SupplierMaster supplier);
       int deleteSupplierDetailsFromDB(int supplierId);
       DataTable GetSupplierDetailsFromDBToGrid();
       DataTable GetSupplierDetailsFromDBToGrid(int Id);
    }
}
