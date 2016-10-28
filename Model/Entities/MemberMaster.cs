using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entities
{
    public class MemberMaster
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string Mobile { get; set; }
        public string MemberDOB { get; set; }
        public string MemberDOJ { get; set; }
        public string MemberAddress { get; set; }
        public string PlanName { get; set; }
        public int PlanId { get; set; }
        public int MemberStatus { get; set; }
    }
}
