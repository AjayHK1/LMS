using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entities
{
    public class AdminMaster
    {
        public int ProUserId { get; set; }
        public string ProUserName { get; set; }
        public string EMail { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }
    }
}
