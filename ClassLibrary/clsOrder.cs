using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int OrderId;
        private int AccountId;
        private double TotalCost;
        private DateTime DateOfDelivery;
        private bool Delivered;
        private string DeliveryInstructions;
        private clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();

        public clsOrder(int AccountId, DateTime DateOfDelivery, bool Delivered, string DeliveryInstructions)
        {
            this.AccountId = AccountId;
            this.DateOfDelivery = DateOfDelivery;
            this.Delivered = Delivered;
            this.DeliveryInstructions = DeliveryInstructions;
        }

        public clsOrder() { }

        public clsOrderCollection Find(int needle, string fieldOfSearch)
        {
            clsDataConnection db = new clsDataConnection();
            clsOrderCollection orderCollection = new clsOrderCollection();

            if (fieldOfSearch == "OrderId")
            {
                db.AddParameter("OrderId", needle);
                db.Execute("sproc_tblOrder_FindByOrderId");
            }
            else if (fieldOfSearch == "AccountId")
            {
                db.AddParameter("AccountId", needle);
                db.Execute("sproc_tblOrder_FindByAccountId");
            }

            if (db.Count > 0)
            {
                int index = 0;
                int count = db.Count;

                while (index < count)
                {
                    clsOrder order = new clsOrder();
                    order.SetOrderId(Convert.ToInt32(db.DataTable.Rows[0]["OrderId"]));
                    order.SetAccountId(Convert.ToInt32(db.DataTable.Rows[0]["AccountId"]));
                    order.SetDateOfDelivery(Convert.ToDateTime(db.DataTable.Rows[0]["DateOfDelivery"]));
                    order.SetDelivered(Convert.ToBoolean(db.DataTable.Rows[0]["Delivered"]));
                    order.SetDeliveryInstructions(Convert.ToString(db.DataTable.Rows[0]["DeliveryInstructions"]));
                    orderCollection.AddOrder(order);

                    index++;
                }

                return orderCollection;
            }
            else
            {
                return orderCollection;
            }
        }

        public string Valid(int AccountId, DateTime DateOfDelivery, bool Delivered, string DeliveryInstructions, clsOrderLineCollection orderLineCollection)
        {
            string error = "";

            try
            {
                if (AccountId <= 0)
                {
                    error += "Account ID must be greater than zero. ";
                }
                if (DateOfDelivery < DateTime.Now)
                {
                    error += "Date of delivery cannot be in the past. ";
                }
                if (string.IsNullOrWhiteSpace(DeliveryInstructions))
                {
                    error += "Delivery instructions cannot be empty. ";
                }
                if (Delivered == true)
                {
                    error += "Order cannot be marked as delivered at the time of creation. ";
                }
                if (DeliveryInstructions.Length > 50)
                {
                    error += "Delivery instructions cannot exceed 50 characters. ";
                }
                if (orderLineCollection.GetCount() == 0)
                {
                    error += "Order must contain at least one order line. ";
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

        public int GetAccountId() { return this.AccountId; }

        public double GetTotalCost() { return this.TotalCost; }

        public DateTime GetDateOfDelivery() { return this.DateOfDelivery; }

        public bool GetDelivered() { return this.Delivered; }

        public string GetDeliveryInstructions() { return this.DeliveryInstructions; }

        public clsOrderLineCollection GetOrderLineCollection() { return this.orderLineCollection; }

        // setters
        public void SetOrderId(int id) { this.OrderId = id; }

        public void SetAccountId(int accountId) { this.AccountId = accountId; }

        public void SetTotalCost(double totalCost) { this.TotalCost = totalCost; }

        public void SetDateOfDelivery(DateTime dateOfDelivery) { this.DateOfDelivery = dateOfDelivery; }

        public void SetDelivered(bool delivered) { this.Delivered = delivered; }

        public void SetDeliveryInstructions(string deliveryInstructions) { this.DeliveryInstructions = deliveryInstructions; }

        public void SetOrderLineCollection(clsOrderLineCollection orderLineCollection) { this.orderLineCollection = orderLineCollection; }
    }
}