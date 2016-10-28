using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Entities;
using DA;
using DA.Abstract;
using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class RoleMasterDA : IRoleMasterDA
    {
        public int SaveRoleMasterdataToDB(RoleMaster r)
        {
            
            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spInsRoleMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Role_Id",r.RoleId);
                cmd.Parameters.AddWithValue("@Role_Name", r.Role);
                cmd.Parameters.AddWithValue("@Role_Status", r.RoleActive);
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

        public int UpdateRoleMasterdataToDB(RoleMaster r)
        {
            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spUpdtRoleMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Role_Id", r.RoleId);
                cmd.Parameters.AddWithValue("@Role_Name", r.Role);
                cmd.Parameters.AddWithValue("@Role_Status", r.RoleActive);
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

        public int DeleteRoleMasterdata(RoleMaster r)
        {
            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";


            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spDeleteRoleMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Role_Id", r.RoleId);
                //cmd.Parameters.AddWithValue("@Role_Name", r.Role);
                //cmd.Parameters.AddWithValue("@Role_Status", r.RoleActive);
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
    }
}
