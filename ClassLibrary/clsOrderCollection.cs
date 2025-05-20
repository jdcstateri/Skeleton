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

        public clsOrderCollection(clsShoppingCart ShoppingCart) 
        { 
            cart = ShoppingCart;
        }

        public void CreateNewOrder(int AccountId, DateTime DateOfDelivery, string DeliveryInstructions)
        {
            clsOrder order = new clsOrder(AccountId, DateOfDelivery, false, DeliveryInstructions);
            order.SetTotalCost(CalculateTotalCost());
            AddOrderToDatabase(order);
            AddOrderLinesToDatabase(order);
        }

        public void AddOrderToDatabase(clsOrder order)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("AccountId", order.GetAccountId());
            db.AddParameter("TotalCost", order.GetTotalCost());
            db.AddParameter("DateOfDelivery", order.GetDateOfDelivery());
            db.AddParameter("Delivered", order.GetDelivered());
            db.AddParameter("DeliveryInstructions", order.GetDeliveryInstructions());
            db.AddOutputParameter("OrderId", System.Data.SqlDbType.Int);
            db.Execute("sproc_tblOrder_Insert");

            order.SetOrderId(Convert.ToInt32(db.GetOutputParameterValue("OrderId")));
        }

        public void AddOrderLinesToDatabase(clsOrder order)
        {
            foreach (clsShoppingCartItem item in cart.GetShoppingCart())
            {
                clsDataConnection db = new clsDataConnection();
                db.AddParameter("OrderId", order.GetOrderId());
                db.AddParameter("DateAdded", DateTime.Now);
                db.AddParameter("ItemId", item.ProductId);
                db.AddParameter("IsDiscounted", item.IsDiscounted);
                db.AddParameter("DiscountPercentage", item.DiscountPercentage);
                db.AddParameter("Status", "Pending");
                db.AddParameter("Quantity", item.Quantity);
                db.Execute("sproc_tblOrderLines_Insert");
            }
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0f;

            foreach (clsShoppingCartItem item in cart.GetShoppingCart())
            {
                totalCost += item.Cost * item.Quantity;
            }

            return totalCost;
        }


        public bool FindOrderById(clsOrder order)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", order.GetOrderId());
            db.Execute("sproc_tblOrder_FilterByOrderId");

            if (db.Count == 1)
            {
                order.SetAccountId(Convert.ToInt32(db.DataTable.Rows[0]["AccountId"]));
                order.SetTotalCost(Convert.ToDouble(db.DataTable.Rows[0]["TotalCost"]));
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
                    line.SetIsDiscounted(Convert.ToBoolean(db.DataTable.Rows[index]["DateOfDelivery"]));
                    line.GetDiscountPercentage(Convert.ToInt32(db.DataTable.Rows[index]["Delivered"]));
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
    }
}
