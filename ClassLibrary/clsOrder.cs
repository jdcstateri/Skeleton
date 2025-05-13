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
        private clsShoppingCart ShoppingCart;

        // constructor for creating a new order to add to the database
        public clsOrder(clsShoppingCart ShoppingCart, int AccountId, DateTime DateOfDelivery, string DeliveryInstructions)
        {
            this.AccountId = AccountId;
            this.DateOfDelivery = DateOfDelivery;
            this.DeliveryInstructions = DeliveryInstructions;
            this.ShoppingCart = ShoppingCart;

        }

        void CreateOrder()
        {

        }

        void CreateOrderLine()
        {

        }

        // getters
        public int GetOrderId() { return this.OrderId; }

        public int GetAccountId() { return this.AccountId; }

        public float GetTotalCost() {return this.TotalCost; }

        public DateTime GetDateOfDelivery(){ return this.DateOfDelivery; }

        public bool GetDelivered(){ return this.Delivered; }

        public string GetDeliveryInstructions(){ return this.DeliveryInstructions; }

        public clsShoppingCart GetShoppingCart() { return this.ShoppingCart; }

        // setters
        public void SetOrderId(int id){ this.OrderId = id; }

        public void SetAccountId(int accountId){ this.AccountId = accountId; }

        public void SetTotalCost(float totalCost){ this.TotalCost = totalCost; }

        public void SetDateOfDelivery(DateTime dateOfDelivery) { this.DateOfDelivery = dateOfDelivery; }

        public void SetDelivered(bool delivered){ this.Delivered = delivered; }

        public void SetDeliveryInstructions(string deliveryInstructions) { this.DeliveryInstructions = deliveryInstructions; }

        public void SetShoppingCart(clsShoppingCart shoppingCart) { this.ShoppingCart = shoppingCart; }
    }
}