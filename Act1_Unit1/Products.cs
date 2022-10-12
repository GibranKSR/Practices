using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityNo1_UNIT1
{
    internal class Products
    {
        public string? name { get; set; }
        public string? desc { get; set; }
        public int disc { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string? code { get; set; }

        public int addedQuantity = 0;
    }
}
