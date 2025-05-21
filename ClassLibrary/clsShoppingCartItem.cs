using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsShoppingCartItem
    {
        public int ProductId;
        public int Quantity;
        public float Cost;
        public bool IsDiscounted;
        public float DiscountPercentage;

        public clsShoppingCartItem(int ProductId, int Quantity, float Cost, bool IsDiscounted, float DiscountPercentage)
        {
            this.ProductId = ProductId;
            this.Quantity = Quantity;
            this.Cost = Cost;
            this.IsDiscounted = IsDiscounted;
            this.DiscountPercentage = DiscountPercentage;
        }
    }
}
