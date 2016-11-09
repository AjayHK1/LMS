using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entities
{
    public class PurchaseEntities
    {
        public int purchaseId { get; set; }
        public string purchaseFrom { get; set; }
        public DateTime purcahseDate { get; set; }
        public int purchaseStatus { get; set; }  //Id,Name,Qty,Rate,Amount

        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookQty { get; set; }
        public int BookRate { get; set; }
        public int BookAmount { get; set; }

    }
}
