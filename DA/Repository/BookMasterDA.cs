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

namespace DA.Repository
{
    public class BookMasterDA:IBookMasterDA
    {
        DBConnection con = new DBConnection();
        public int SaveBookMasterdataToDB(BookMaster objBook)
        {
            int n = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("spInsBookMasterDetails", con.ActiveCon()); //Constant file
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Book_Id", objBook.BookId);
                cmd.Parameters.AddWithValue("@Book_Name", objBook.BookName);
                cmd.Parameters.AddWithValue("@Book_Status", objBook.BookStatus);
                n = cmd.ExecuteNonQuery();
                n = n > 0 ? 1 : 0;
            }

            catch (Exception ex)
            {
                InsertToErrorLog("BookDA", ex.Message.ToString(), "SaveBookMasterdataToDB");
            }

            finally
            {
                con.CloseCon();
            }

            return n;
        }

        public int UpdateBookMasterdataToDB(BookMaster objBook)
        {
            int n = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("spUpdtBookMasterDetails", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Book_Id", objBook.BookId);
                cmd.Parameters.AddWithValue("@Book_Name", objBook.BookName);
                cmd.Parameters.AddWithValue("@Book_Status", objBook.BookStatus);
                n = cmd.ExecuteNonQuery();
                n = n > 0 ? 1 : 0;
            }

            catch (Exception ex)
            {
                InsertToErrorLog("BookDA", ex.Message.ToString(), "UpdateBookMasterdataToDB");
            }

            finally
            {
                con.CloseCon();
            }

            return n;
        }

        public int DeleteBookMasterdataFromDB(BookMaster objBook)
        {
            int n = 0;
            //spDeleteBookMasterDetails
            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteBookMasterDetails", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Book_Id", objBook.BookId);
                n = cmd.ExecuteNonQuery();
                n = n > 0 ? 1 : 0;
            }

            catch (Exception ex)
            {
                InsertToErrorLog("BookDA", ex.Message.ToString(), "DeleteBookMasterdataFromDB");
            }

            finally
            {
                con.CloseCon();
            }

            return n;
        }

        public void InsertToErrorLog(string page,string errortxt,string funtn)
        {
            SqlCommand cmd = new SqlCommand("spInsertErrorLogDetails", con.ActiveCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Err_Page",page);
            cmd.Parameters.AddWithValue("Err_Text",errortxt);
            cmd.Parameters.AddWithValue("Err_Fun",funtn);
            cmd.ExecuteNonQuery();
        }
    }
}
