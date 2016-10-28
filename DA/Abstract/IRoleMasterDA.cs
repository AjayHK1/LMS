using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Entities;

namespace DA.Abstract
{
    public interface IRoleMasterDA
    {
         int SaveRoleMasterdataToDB(RoleMaster r);
         int UpdateRoleMasterdataToDB(RoleMaster r);
         int DeleteRoleMasterdata(RoleMaster r);
    }
}
