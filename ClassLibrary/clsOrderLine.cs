using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        public clsOrderLine()
        {
        }

        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsDiscounted { get; set; }
        public int DiscountPercentage { get; set; }
        public string Status { get; set; }
    }
}
