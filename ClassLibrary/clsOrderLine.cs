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
        private double AgreedPrice;
        public string Status;
        public int Quantity;

        public clsOrderLine(int itemId, DateTime dateAdded, string status, double agreedPrice, int quantity)
        {
            SetItemId(itemId);
            SetDateAdded(dateAdded);
            SetStatus(status);
            SetAgreedPrice(agreedPrice);
            SetStatus(status);
        }

        public clsOrderLine() {}

        public bool Find(clsOrderLineCollection orderLineCollection)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", this.GetOrderId());
            db.Execute("sproc_tblOrderLines_Find");

            if (db.Count > 0)
            {
                int index = 0;
                int count = db.Count;

                while (index < count)
                {
                    clsOrderLine line = new clsOrderLine();
                    line.SetItemId(Convert.ToInt32(db.DataTable.Rows[index]["AccountId"]));
                    line.SetDateAdded(Convert.ToDateTime(db.DataTable.Rows[index]["TotalCost"]));
                    line.SetStatus(Convert.ToString(db.DataTable.Rows[index]["DeliveryInstructions"]));
                    line.SetQuantity(Convert.ToInt32(db.DataTable.Rows[index]["DeliveryInstructions"]));
                    orderLineCollection.AddOrderline(line);

                    index++;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        // getters
        public int GetOrderId() { return this.OrderId; }
        public int GetItemId() { return this.ItemId; }
        public DateTime GetDateAdded() { return this.DateAdded; }
        public double GetAgreedPrice() { return this.AgreedPrice; }
        public string GetStatus() { return this.Status; }
        public int GetQuantity() { return this.Quantity; }

        public void SetOrderId(int orderId) { this.OrderId = orderId; }
        public void SetItemId(int itemId) { this.ItemId = itemId; }
        public void SetDateAdded(DateTime dateAdded) { this.DateAdded = dateAdded; }
        public void SetAgreedPrice (double agreedPrice) { this.AgreedPrice = agreedPrice; }
        public void SetStatus(string status) { this.Status = status; }
        public void SetQuantity(int quantity) { this.Quantity = quantity; }
    }
}
