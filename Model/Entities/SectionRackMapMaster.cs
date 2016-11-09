using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entities
{
    public class SectionRackMapMaster
    {
       public int sr_rac_map_id { get; set; }
       public int racId { get; set; }
       public int secId { get; set; }
       public int print { get; set; }
       public int status { get; set; }
    }
}
