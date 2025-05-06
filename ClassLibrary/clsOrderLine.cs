using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        private int OrderId;
        private int ItemId;
        private DateTime DateAdded;
        private bool IsDiscounted;
        private int DiscountPercentage;
        public string Status;

        public clsOrderLine()
        {
        }

        // getters
        public int GetOrderId() { return this.OrderId; }
        public int GetItemId() { return this.ItemId; }
        public DateTime GetDateAdded() { return this.DateAdded; }
        public bool GetIsDiscounted() { return this.IsDiscounted; }
        public int GetDiscountPercentage() { return this.DiscountPercentage; }
        public string GetStatus() { return this.Status; }

        public void SetOrderId(int orderId) { this.OrderId = orderId; }
        public void SetItemId(int itemId) { this.ItemId = itemId; }
        public void SetDateAdded(DateTime dateAdded) { this.DateAdded = dateAdded; }
        public void SetIsDiscounted(bool isDiscounted) { this.IsDiscounted = isDiscounted; }
        public void GetDiscountPercentage(int discountPercentage) { this.DiscountPercentage = discountPercentage; }
        public void SetStatus(string status) { this.Status = status; }

    }
}
