using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;


namespace DA.Abstract
{
    public interface IBookMasterDA
    {
        int SaveBookMasterdataToDB(BookMaster objBook);
        int UpdateBookMasterdataToDB(BookMaster objBook);
        int DeleteBookMasterdataFromDB(BookMaster objBook);
        void InsertToErrorLog(string page, string errortxt, string funtn);
    }
}
