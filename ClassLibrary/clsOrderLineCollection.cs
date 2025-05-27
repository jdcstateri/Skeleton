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

        public void AddOrderline(clsOrderLine line)
        {
            orderLineList.Add(line);
            count++;
        }

        public void RemoveOrderline(clsOrderLine line)
        {
            orderLineList.Remove(line);
        }

        public void SetThisOrderLine(clsOrderLine line)
        {
            this.thisOrderLine = line;
        }

        public clsOrderLine GetThisOrderLine()
        {
            return this.thisOrderLine;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
