using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using DA.Abstract;
using System.Data;
using System.Data.SqlClient;

namespace DA.Repository
{
    public class PlanMasterDA : IPlanMasterDA
    {
        public int SavePlanMasterdataToDB(PlanMaster objPlan)
        {
            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spInsertPlanMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Plan_Id", objPlan.PlanId);
                cmd.Parameters.AddWithValue("@Plan_Name", objPlan.PlanName);
                cmd.Parameters.AddWithValue("@Plan_Doc", objPlan.DateOfCreation);
                cmd.Parameters.AddWithValue("@Plan_Book_Limit", objPlan.Limit);
                cmd.Parameters.AddWithValue("@Plan_Book_Can_Hold", objPlan.BookOnHold);
                cmd.Parameters.AddWithValue("@Plan_Validity", objPlan.Validity);
                cmd.Parameters.AddWithValue("@Plan_Amount", objPlan.Amount);
                cmd.Parameters.AddWithValue("@Plan_Discount", objPlan.Discount);
                cmd.Parameters.AddWithValue("@Plan_Status", objPlan.Status);

                connectn.Open();
                n = cmd.ExecuteNonQuery();
                n = n > 0 ? 1 : 0;
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connectn.Close();
            }

            return n;
        }

        public int UpdatePlanMasterdataToDB(PlanMaster objPlan)
        {
            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spUpdatePlanMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Plan_Id", objPlan.PlanId);
                cmd.Parameters.AddWithValue("@Plan_Name", objPlan.PlanName);
                cmd.Parameters.AddWithValue("@Plan_Doc", objPlan.DateOfCreation);
                cmd.Parameters.AddWithValue("@Plan_Book_Limit", objPlan.Limit);
                cmd.Parameters.AddWithValue("@Plan_Book_Can_Hold", objPlan.BookOnHold);
                cmd.Parameters.AddWithValue("@Plan_Validity", objPlan.Validity);
                cmd.Parameters.AddWithValue("@Plan_Amount", objPlan.Amount);
                cmd.Parameters.AddWithValue("@Plan_Discount", objPlan.Discount);
                cmd.Parameters.AddWithValue("@Plan_Status", objPlan.Status);

                connectn.Open();
                n = cmd.ExecuteNonQuery();
                n = n > 0 ? 1 : 0;
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connectn.Close();
            }

            return n;
        }

        public int DeletePlanMasterdataFromDB(PlanMaster p)
        {
            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spDeletePlanMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Plan_Id", p.PlanId);

                connectn.Open();
                n = cmd.ExecuteNonQuery();
                n = n > 0 ? 1 : 0;

            }

            catch(Exception ex)
            {

            }

            finally
            {
                connectn.Close();
            }
            return n;
        }
    }
}
