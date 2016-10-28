using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using DA.Abstract;
using DA.Repository;

namespace BL
{
    public class BookMasterBL
    {
        public int SaveBookMasterdata(BookMaster b)
        {
            int n = 0;
            IBookMasterDA objBook = new BookMasterDA();
            try
            {
                //IBookMasterDA objBook = new BookMasterDA();
                n = Convert.ToInt32(objBook.SaveBookMasterdataToDB(b));
                return n;
            }

            catch (Exception ex)
            {
                objBook.InsertToErrorLog("BookBL", ex.Message.ToString(), "SaveBookMasterData");
            }


            return n;
        }

        public int UpdateBookMasterData(BookMaster b)
        {
            int n = 0;
            IBookMasterDA objBook = new BookMasterDA();
            try
            {
                n = Convert.ToInt32(objBook.UpdateBookMasterdataToDB(b));
            }

            catch (Exception ex)
            {
                objBook.InsertToErrorLog("BookBL", ex.Message.ToString(), "UpdateBookMasterData");
            }

                return n;

        }

        public int DeleteBookMasterData(BookMaster b)
        {
            int n = 0;
            IBookMasterDA objBook = new BookMasterDA();
            try
            {
                
                n = Convert.ToInt32(objBook.DeleteBookMasterdataFromDB(b));
            }

            catch (Exception ex)
            {
                objBook.InsertToErrorLog("BookBL", ex.Message.ToString(), "DeleteBookMasterData");
            }


            return n;

        }

        public void InserToErrorLog(string page,string errortxt,string funtn)
        {
            IBookMasterDA objBook = new BookMasterDA();
            objBook.InsertToErrorLog(page, errortxt, funtn);
        }
    }
}
