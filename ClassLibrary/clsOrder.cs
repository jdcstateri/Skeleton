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
        private List<clsOrderLine> OrderLines = new List<clsOrderLine>();

        // constructor for creating a new order to add to the database
        public clsOrder(int AccountId, DateTime DateOfDelivery, bool Delivered, string DeliveryInstructions)
        {
            this.AccountId = AccountId;
            this.DateOfDelivery = DateOfDelivery;
            this.Delivered = Delivered;
            this.DeliveryInstructions = DeliveryInstructions;
        }

        public clsOrder()
        {

        }

        public void AddOrderline(clsOrderLine line)
        {
            OrderLines.Add(line);
        }

        public void RemoveOrderline(clsOrderLine line)
        {
            OrderLines.Remove(line);
        }

        // getters
        public int GetOrderId() { return this.OrderId; }

        public int GetAccountId() { return this.AccountId; }

        public double GetTotalCost() {return this.TotalCost; }

        public DateTime GetDateOfDelivery(){ return this.DateOfDelivery; }

        public bool GetDelivered(){ return this.Delivered; }

        public string GetDeliveryInstructions(){ return this.DeliveryInstructions; }

        // setters
        public void SetOrderId(int id){ this.OrderId = id; }

        public void SetAccountId(int accountId){ this.AccountId = accountId; }

        public void SetTotalCost(double totalCost){ this.TotalCost = totalCost; }

        public void SetDateOfDelivery(DateTime dateOfDelivery) { this.DateOfDelivery = dateOfDelivery; }

        public void SetDelivered(bool delivered){ this.Delivered = delivered; }

        public void SetDeliveryInstructions(string deliveryInstructions) { this.DeliveryInstructions = deliveryInstructions; }
    }
}