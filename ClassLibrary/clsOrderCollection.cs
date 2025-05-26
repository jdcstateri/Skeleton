using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassLibrary
{
    class clsOrderCollection
    {
        private List<clsOrder> orderList = new List<clsOrder>();
        private clsShoppingCart cart = new clsShoppingCart();
        private int count = 0;
        private clsOrder thisOrder = new clsOrder();

        // consider setting a shopping cart instance optional
        public clsOrderCollection(clsShoppingCart ShoppingCart) 
        { 
            cart = ShoppingCart;
        }

        // consider removing
        // inside AdminSystem script, do
        // clsOrderCollection.Add()
        // clsOrder.clsOrderLineCollection.Add()
        public void InsertNewOrderInfo(int AccountId, DateTime DateOfDelivery, string DeliveryInstructions)
        {
            thisOrder = new clsOrder(AccountId, DateOfDelivery, false, DeliveryInstructions);
            InsertOrderIntoDatabase(thisOrder); // change to AddOrder()
            InsertOrderLinesIntoDatabase(thisOrder); // change to ThisOrder.OrderLineCollection.AddOrderLines()
        }

        // rename to AddOrder, after clsOrderLineCollection is made and InsertOrderLinesIntoDatabase() is migrated there
        // dont pass order as param, use the one set in the clsOrderCollection
        public void InsertOrderIntoDatabase(clsOrder order)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("AccountId", order.GetAccountId());
            db.AddParameter("DateOfDelivery", order.GetDateOfDelivery());
            db.AddParameter("Delivered", order.GetDelivered());
            db.AddParameter("DeliveryInstructions", order.GetDeliveryInstructions());
            db.AddOutputParameter("OrderId", System.Data.SqlDbType.Int);
            db.Execute("sproc_tblOrder_Insert");

            order.SetOrderId(Convert.ToInt32(db.GetOutputParameterValue("OrderId")));
        }

        // needs moving to clsOrderLinesCollection when its created on tuesday
        // do something like ThisOrder.OrderLineCollection.AddOrderLines()
        public void InsertOrderLinesIntoDatabase(clsOrder order)
        {
            foreach (clsShoppingCartItem item in cart.GetShoppingCart())
            {
                clsDataConnection db = new clsDataConnection();
                db.AddParameter("OrderId", order.GetOrderId());
                db.AddParameter("DateAdded", DateTime.Now);
                db.AddParameter("ItemId", item.ProductId);
                db.AddParameter("Status", "Pending");
                db.AddParameter("Quantity", item.Quantity);
                db.Execute("sproc_tblOrderLines_Insert");
            }
        }

        public void UpdateOrder(clsOrder order)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", order.GetOrderId());
            db.AddParameter("DateOfDelivery", order.GetDateOfDelivery());
            db.AddParameter("Delivered", order.GetDelivered());
            db.AddParameter("DeliveryInstructions", order.GetDeliveryInstructions());
            db.Execute("sproc_tblOrder_Update");
        }

        public void DeleteOrder(clsOrder order)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", order.GetOrderId());
            db.Execute("sproc_tblOrder_Delete");
        }

        public bool FindOrderById(clsOrder order)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", order.GetOrderId());
            db.Execute("sproc_tblOrder_FilterByOrderId");

            if (db.Count == 1)
            {
                order.SetAccountId(Convert.ToInt32(db.DataTable.Rows[0]["AccountId"]));
                order.SetDateOfDelivery(Convert.ToDateTime(db.DataTable.Rows[0]["DateOfDelivery"]));
                order.SetDelivered(Convert.ToBoolean(db.DataTable.Rows[0]["Delivered"]));
                order.SetDeliveryInstructions(Convert.ToString(db.DataTable.Rows[0]["DeliveryInstructions"]));

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FindOrderlinesByOrderId(clsOrder order)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", order.GetOrderId());
            db.Execute("sproc_tblOrderLines_FilterByOrderId");

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
                    order.AddOrderline(line);

                    index++;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        // no longer works as intended due to Order and Orderlines database table rework
        // consider moving inside clsOrder or clsOrderLineCollection (when added on Tuesday)
        public double CalculateTotalCost()
        {
            double totalCost = 0f;

            foreach (clsShoppingCartItem item in cart.GetShoppingCart())
            {
                totalCost += item.Cost * item.Quantity;
            }

            return totalCost;
        }

        // tests not written for these yet
        public void SetThisOrder(clsOrder order) 
        {
            this.thisOrder = order;
        }

        public clsOrder GetThisOrder()
        {
            return this.thisOrder;
        }
    }
}
