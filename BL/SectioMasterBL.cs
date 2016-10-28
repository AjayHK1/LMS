using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;
using DA.Abstract;
using DA.Repository;

namespace BL
{
    public class SectioMasterBL
    {
        public int SaveSectionMasterdata(SectionMaster s)
        {
            int n = 0;

            try
            {
                ISectionMasterDA objSec = new SectionMasterDA();
                n = Convert.ToInt32(objSec.SaveSectionMasterdataToDB(s));
            }

            catch (Exception ex)
            {

            }


            return n;

        }

        public int UpdateSectiondata(SectionMaster s)
        {
            int n = 0;

            try
            {
                ISectionMasterDA objSection = new SectionMasterDA();
                n = Convert.ToInt32(objSection.UpdateSectionMasterdataToDB(s));
            }

            catch (Exception ex)
            {

            }

            finally
            {

            }

            return n;

        }

        public int DeleteSectionData(SectionMaster s)
        {
            int n = 0;

            try
            {
                ISectionMasterDA objSection = new SectionMasterDA();
                n = Convert.ToInt32(objSection.DeleteSectionMasterdataToDB(s));
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
