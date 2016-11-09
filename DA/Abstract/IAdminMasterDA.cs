using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model.Entities;

namespace DA.Abstract
{
    public interface IAdminMasterDA
    {
        int RetrieveRoleIdFromDB(string name);
        int RetrieveProUserIdFromDB();
        DataTable LoadRoleNameToCombo();
        int SaveProfileDataToDB(AdminMaster admin);
        int UpdateProfileDataToDB(AdminMaster admin);
        DataTable LoadGridDetailsFromDB();
        string RetrieveRoleNameFromDB(int id);
        int DeleteProfileDetailsFromDB(AdminMaster admin);
    }
}
