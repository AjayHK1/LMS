using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using System.Data;
using System.Data.SqlClient;
using DA.Abstract;

namespace DA.Repository
{
    public class SectionMasterDA : ISectionMasterDA
    {
        public int SaveSectionMasterdataToDB(SectionMaster objSection)
        {

            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spInsertSectionMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sec_Id", objSection.sectionId);
                cmd.Parameters.AddWithValue("@Sec_Name", objSection.sectionName);
                cmd.Parameters.AddWithValue("@Sec_Status", objSection.sectionStatus);
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

        public int UpdateSectionMasterdataToDB(SectionMaster r)
        {
            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spUpdateSectionMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sec_Id", r.sectionId);
                cmd.Parameters.AddWithValue("@Sec_Name", r.sectionName);
                cmd.Parameters.AddWithValue("@Sec_Status", r.sectionStatus);
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

        public int DeleteSectionMasterdataToDB(SectionMaster r)
        {
            int n = 0;
            SqlConnection connectn = null;
            string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

            try
            {
                connectn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("spDeleteSectionMasterDetails", connectn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sec_Id", r.sectionId);
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
