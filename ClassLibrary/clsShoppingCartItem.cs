using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsShoppingCartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float Cost { get; set; }

        public bool IsDiscounted { get; set; }
        public int DiscountPercentage { get; set; }

    }
}
