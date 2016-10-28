using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model.Entities;
using Model.Connection;
using DA.Abstract;

namespace DA.Repository
{
    public class MemberMasteDA : IMemberMaster
    {
        int n = 0;
        DBConnection dbCon = new DBConnection();
        public int SaveMemberMasterdataToDB(MemberMaster objMember)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spInsMemberMasterDetails", dbCon.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Member_Id", objMember.MemberId);
                cmd.Parameters.AddWithValue("@Member_Name", objMember.MemberName);
                cmd.Parameters.AddWithValue("@Member_Email", objMember.MemberEmail);
                cmd.Parameters.AddWithValue("@Member_Mobile", objMember.Mobile);
                cmd.Parameters.AddWithValue("@Member_DOB", objMember.MemberDOB);
                cmd.Parameters.AddWithValue("@Member_DOJ", objMember.MemberDOJ);
                cmd.Parameters.AddWithValue("@Member_Address", objMember.MemberAddress);
                cmd.Parameters.AddWithValue("@PlanId", objMember.PlanId);
                cmd.Parameters.AddWithValue("@Member_Status", objMember.MemberStatus);
                n = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

            }

            finally
            {
                dbCon.CloseCon();
            }
            return n;
        }

        public int UpdateMemberMasterdataToDB(MemberMaster objMember)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateMemberMasterDetails", dbCon.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Member_Id", objMember.MemberId);
                cmd.Parameters.AddWithValue("@Member_Name", objMember.MemberName);
                cmd.Parameters.AddWithValue("@Member_Email", objMember.MemberEmail);
                cmd.Parameters.AddWithValue("@Member_Mobile", objMember.Mobile);
                cmd.Parameters.AddWithValue("@Member_DOB", objMember.MemberDOB);
                cmd.Parameters.AddWithValue("@Member_DOJ", objMember.MemberDOJ);
                cmd.Parameters.AddWithValue("@Member_Address", objMember.MemberAddress);
                cmd.Parameters.AddWithValue("@PlanId", objMember.PlanId);
                cmd.Parameters.AddWithValue("@Member_Status", objMember.MemberStatus);
                n = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

            }

            finally
            {
                dbCon.CloseCon();
            }
            return n;
        }

        public int DeleteMemberMasterdataFromDB(MemberMaster objMember)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteMemberMasterDetails", dbCon.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Member_Id", objMember.MemberId);
                n = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

            }

            finally
            {
                dbCon.CloseCon();
            }
            return n;
        }
    }
}
