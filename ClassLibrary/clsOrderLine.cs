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
            SetQuantity(quantity);
        }

        public clsOrderLine() {}

        public clsOrderLineCollection FindAll(int orderId)
        {
            clsDataConnection db = new clsDataConnection();
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();
            db.AddParameter("OrderId", orderId);
            db.Execute("sproc_tblOrderLines_FindAll");

            if (db.Count > 0)
            {
                int index = 0;
                int count = db.Count;

                while (index < count)
                {
                    clsOrderLine line = new clsOrderLine();
                    line.SetOrderId(Convert.ToInt32(db.DataTable.Rows[index]["OrderId"]));
                    line.SetItemId(Convert.ToInt32(db.DataTable.Rows[index]["ItemId"]));
                    line.SetDateAdded(Convert.ToDateTime(db.DataTable.Rows[index]["DateAdded"]));
                    line.SetStatus(Convert.ToString(db.DataTable.Rows[index]["Status"]));
                    line.SetAgreedPrice(Convert.ToDouble(db.DataTable.Rows[index]["AgreedPrice"]));
                    line.SetQuantity(Convert.ToInt32(db.DataTable.Rows[index]["Quantity"]));
                    orderLineCollection.AddOrderline(line);

                    index++;
                }
            }

            return orderLineCollection;
        }

        public clsOrderLineCollection FindOrderLine(int orderId, int itemId)
        {
            clsDataConnection db = new clsDataConnection();
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();
            db.AddParameter("OrderId", orderId);
            db.AddParameter("ItemId", itemId);
            db.Execute("sproc_tblOrderLines_Find");

            if (db.Count == 1)
            {
                clsOrderLine line = new clsOrderLine();
                line.SetOrderId(Convert.ToInt32(db.DataTable.Rows[0]["OrderId"]));
                line.SetItemId(Convert.ToInt32(db.DataTable.Rows[0]["ItemId"]));
                line.SetDateAdded(Convert.ToDateTime(db.DataTable.Rows[0]["DateAdded"]));
                line.SetStatus(Convert.ToString(db.DataTable.Rows[0]["Status"]));
                line.SetAgreedPrice(Convert.ToDouble(db.DataTable.Rows[0]["AgreedPrice"]));
                line.SetQuantity(Convert.ToInt32(db.DataTable.Rows[0]["Quantity"]));
                orderLineCollection.AddOrderline(line);
            }

            return orderLineCollection;
        }

        public string Valid(int orderId, int itemId, DateTime dateAdded, double agreedPrice, string status, int quantity)
        {
            string error = "";

            try
            {
                if (orderId <= 0)
                {
                    error += "Order ID must be greater than zero. ";
                }
                if (itemId <= 0)
                {
                    error += "Item ID must be greater than zero. ";
                }
                if (agreedPrice < 0)
                {
                    error += "Agreed price cannot be negative. ";
                }
                if (string.IsNullOrEmpty(status))
                {
                    error += "Status cannot be empty. ";
                }
                if (status.Length > 50)
                {
                    error += "Status cannot exceed 50 characters. ";
                }
                if (quantity <= 0)
                {
                    error += "Quantity must be greater than zero. ";
                }
            }
            catch (Exception ex)
            {
                error += "An error occurred: " + ex.Message;
            }

            return error;
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
