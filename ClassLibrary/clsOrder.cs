using System;
using System.Runtime.InteropServices;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int OrderId;
        private int AccountId;
        private float TotalCost;
        private DateTime DateOfDelivery;
        private bool Delivered;
        private string DeliveryInstructions;

        public clsOrder()
        {
        }

        // getters
        public int GetOrderId() { return this.OrderId; }

        public int GetAccountId() { return this.AccountId; }

        public float GetTotalCost() {return this.TotalCost; }

        public DateTime GetDateOfDelivery(){ return this.DateOfDelivery; }

        public bool GetDelivered(){ return this.Delivered; }

        public string GetDeliveryInstructions(){ return this.DeliveryInstructions; }

        // setters
        public void SetOrderId(int id){ this.OrderId = id; }

        public void SetAccountId(int accountId){ this.AccountId = accountId; }

        public void SetTotalCost(float totalCost){ this.TotalCost = totalCost; }

        public void SetDateOfDelivery(DateTime dateOfDelivery) { this.DateOfDelivery = dateOfDelivery; }

        public void SetDelivered(bool delivered){ this.Delivered = delivered; }

        public void SetDeliveryInstructions(string deliveryInstructions) { this.DeliveryInstructions = deliveryInstructions; } 
    }
}