using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entities;

namespace DA.Abstract
{
    public interface IMemberMaster
    {
        int SaveMemberMasterdataToDB(MemberMaster objMember);
        int UpdateMemberMasterdataToDB(MemberMaster objMember);
        int DeleteMemberMasterdataFromDB(MemberMaster objMember);
    }
}
