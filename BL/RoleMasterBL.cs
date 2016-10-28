using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Entities;
using DA;
using DA.Abstract;
                            
                        
namespace BL
{
    public class RoleMasterBL
    {
        public int SaveRoldata(RoleMaster r)
        {
            int n = 0;

            try
            {
                IRoleMasterDA objRol = new RoleMasterDA();
                n = Convert.ToInt32(objRol.SaveRoleMasterdataToDB(r));
            }

            catch
            {

            }


            return n;

        }

        public int UpdateRoldata(RoleMaster r)
        {
            int n = 0;

            try
            {
                IRoleMasterDA objRol = new RoleMasterDA();
                n = Convert.ToInt32(objRol.UpdateRoleMasterdataToDB(r));
            }

            catch (Exception ex)
            {

            }

            finally
            {

            }

            return n;

        }

        public int DeleteRoldata(RoleMaster r)
        {
            int n = 0;

            try
            {
                IRoleMasterDA objRol = new RoleMasterDA();
                n = Convert.ToInt32(objRol.DeleteRoleMasterdata(r));
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
