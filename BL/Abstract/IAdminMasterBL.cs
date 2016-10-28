using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model.Entities;

namespace BL
{
    public interface IAdminMasterBL
    {
        int RetrieveRoleId(string RoleName);
        DataTable LoadRoleName();
        int SaveProfileData(AdminMaster admin);
        int UpdateProfileData(AdminMaster admin);
        int RetrieveProUserId();
        DataTable LoadGridDetails();
        string RetrieveRoleName(int id);
    }
}
