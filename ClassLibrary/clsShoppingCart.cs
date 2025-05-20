using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsShoppingCart
    {
        private List<clsShoppingCartItem> Items = new List<clsShoppingCartItem>();

        public clsShoppingCart() 
        { 
        
        }

        public clsShoppingCart(List<clsShoppingCartItem> items)
        {
            Items = items;
        }

        public List<clsShoppingCartItem> GetShoppingCart()
        {
            return Items;
        }

        public void AddItem(clsShoppingCartItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(clsShoppingCartItem item)
        {
            Items.Remove(item);
        }
    }
}
