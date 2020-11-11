using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class Purchasing
    {
        public int Purchasing_Id { get; set; }
        public string Ordernumber { get; set; }
        public int Supplier { get; set; }
        public int Category { get; set; }
        public DateTime purchasedate { get; set; }
        public string Agent { get; set; }
        public int State { get; set; }
    }
}
