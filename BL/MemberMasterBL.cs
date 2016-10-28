using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using DA.Abstract;
using DA.Repository;

namespace BL
{
    public class MemberMasterBL
    {
        int n = 0;

        public int SaveMemberMaster(MemberMaster objMem)
        {
            try
            {
                IMemberMaster iMem = new MemberMasteDA();
                n = iMem.SaveMemberMasterdataToDB(objMem);
                return n;
            }

            catch (Exception ex)
            {

            }

            finally
            {

            }

            return n;
        }

        public int UpdateMemberMaster(MemberMaster objMem)
        {
            try
            {
                IMemberMaster iMem = new MemberMasteDA();
                n = iMem.UpdateMemberMasterdataToDB(objMem);
                return n;
            }

            catch (Exception ex)
            {

            }

            finally
            {

            }
            return n;
        }

        public int DeleteMemberMaster(MemberMaster objMem)
        {
            try
            {
                IMemberMaster iMem = new MemberMasteDA();
                n = iMem.DeleteMemberMasterdataFromDB(objMem);
                return n;
            }

            catch (Exception ex)
            {

            }

            finally
            {

            }
            return n;
        }
    }
}
