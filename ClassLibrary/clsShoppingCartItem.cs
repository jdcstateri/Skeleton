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
        public double Cost;

        public clsShoppingCartItem(int ProductId, int Quantity, double Cost)
        {
            this.ProductId = ProductId;
            this.Quantity = Quantity;
            this.Cost = Cost;
        }
    }
}
