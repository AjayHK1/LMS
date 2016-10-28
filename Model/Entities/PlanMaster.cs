using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entities
{
    public class PlanMaster
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public string DateOfCreation { get; set; }
        public int Limit { get; set; }
        public int BookOnHold { get; set; }
        public string Validity { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public int Status { get; set; }
    }
}
