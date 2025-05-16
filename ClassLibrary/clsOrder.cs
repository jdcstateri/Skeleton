using System;
using System.Runtime.ExceptionServices;
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

        public clsOrder()
        {

        }

        public void CreateNewOrder()
        {
            CalculateTotalCost();
            AddOrderToDatabase();
            AddOrderLinesToDatabase();
        }

        public void AddOrderToDatabase()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("AccountId", GetAccountId());
            db.AddParameter("TotalCost", GetTotalCost());
            db.AddParameter("DateOfDelivery", GetDateOfDelivery());
            db.AddParameter("Delivered", GetDelivered());
            db.AddParameter("DeliveryInstructions", GetDeliveryInstructions());
            db.Execute("sproc_tblOrder_Insert");

            // get OrderID through output somehow
        }

        public void AddOrderLinesToDatabase()
        {
            foreach (clsShoppingCartItem item in ShoppingCart.GetShoppingCart())
            {
                clsDataConnection db = new clsDataConnection();
                db.AddParameter("OrderId", GetOrderId());
                db.AddParameter("DateAdded", DateTime.Now);
                db.AddParameter("ItemId", item.ProductId);
                db.AddParameter("IsDiscounted", item.IsDiscounted);
                db.AddParameter("DiscountPercentage", item.DiscountPercentage);
                db.AddParameter("Status", "Pending");
                db.AddParameter("Quantity", item.Quantity);
                db.Execute("sproc_tblOrderLines_Insert");
            }
        }

        public float CalculateTotalCost()
        {
            float totalCost = 0f;

            foreach (clsShoppingCartItem item in ShoppingCart.GetShoppingCart())
            {
                totalCost += item.Cost * item.Quantity;
            }

            return totalCost;
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