using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderLineCollection
    {
        private List<clsOrderLine> orderLineList = new List<clsOrderLine>();
        private int count = 0;
        private clsOrderLine thisOrderLine;

        public clsOrderLineCollection(){}

        public void Add(clsShoppingCart cart, clsOrder order)
        {
            foreach (clsShoppingCartItem item in cart.GetShoppingCart())
            {
                clsDataConnection db = new clsDataConnection();
                db.AddParameter("OrderId", order.GetOrderId());
                db.AddParameter("DateAdded", DateTime.Now);
                db.AddParameter("ItemId", item.ProductId);
                db.AddParameter("Status", "Pending");
                db.AddParameter("AgreedPrice", (item.Quantity * item.Cost));
                db.AddParameter("Quantity", item.Quantity);
                db.Execute("sproc_tblOrderLines_Insert");
            }
        }

        public void Update()
        {
            clsOrderLine line = GetThisOrderLine();

            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", line.GetOrderId());
            db.AddParameter("DateAdded", line.GetDateAdded());
            db.AddParameter("ItemId", line.GetItemId());
            db.AddParameter("Status", line.GetStatus());
            db.AddParameter("AgreedPrice", line.GetAgreedPrice());
            db.AddParameter("Quantity", line.GetQuantity());
            db.Execute("sproc_tblOrderLines_Update");
        }

        public void Delete()
        {
            clsOrderLine line = GetThisOrderLine();
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", line.GetOrderId());
            db.AddParameter("ItemId", line.GetItemId());
            db.Execute("sproc_tblOrderLines_Delete");
        }

        public bool Equals(clsOrderLineCollection other)
        {
            if (this.GetCount() != other.GetCount())
            {
                return false;
            }

            for (int i = 0; i < this.GetCount(); i++)
            {
                clsOrderLine thisLine = this.orderLineList[i];
                clsOrderLine otherLine = other.orderLineList[i];

                if (thisLine.GetOrderId() != otherLine.GetOrderId() ||
                    thisLine.GetItemId() != otherLine.GetItemId() ||
                    thisLine.GetDateAdded() != otherLine.GetDateAdded() ||
                    thisLine.GetStatus() != otherLine.GetStatus() ||
                    thisLine.GetAgreedPrice() != otherLine.GetAgreedPrice() ||
                    thisLine.GetQuantity() != otherLine.GetQuantity())
                {
                    return false;
                }
            }

            return true;
        }

        public void AddOrderline(clsOrderLine line)
        {
            orderLineList.Add(line);
            count++;
        }

        public void RemoveOrderline(clsOrderLine line)
        {
            orderLineList.Remove(line);
            count--;
        }

        public void SetThisOrderLine(clsOrderLine line)
        {
            this.thisOrderLine = line;
        }

        public clsOrderLine GetThisOrderLine()
        {
            return this.thisOrderLine;
        }

        public void GetOrderLineCollectionByText()
        {
            foreach (clsOrderLine line in orderLineList) 
            {
                Console.WriteLine("Order ID: " + line.GetOrderId());
                Console.WriteLine("Item ID: " + line.GetItemId());
                Console.WriteLine("Date Added: " + line.GetDateAdded());
                Console.WriteLine("Status: " + line.GetStatus());
                Console.WriteLine("Agreed Price: " + line.GetAgreedPrice());
                Console.WriteLine("Quantity: " + line.GetQuantity());
                Console.WriteLine("-----------------------------");
            }
        }

        public int GetCount()
        {
            return count;
        }
    }
}
