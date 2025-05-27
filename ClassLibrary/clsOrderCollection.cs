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

        public clsOrderCollection(){}

        // rename to AddOrder, after clsOrderLineCollection is made and InsertOrderLinesIntoDatabase() is migrated there
        // dont pass order as param, use the one set in the clsOrderCollection
        public void Add()
        {
            clsOrder order = GetThisOrder();

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

        public void Edit()
        {
            clsOrder order = GetThisOrder();

            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", order.GetOrderId());
            db.AddParameter("DateOfDelivery", order.GetDateOfDelivery());
            db.AddParameter("Delivered", order.GetDelivered());
            db.AddParameter("DeliveryInstructions", order.GetDeliveryInstructions());
            db.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsOrder order = GetThisOrder();

            clsDataConnection db = new clsDataConnection();
            db.AddParameter("OrderId", order.GetOrderId());
            db.Execute("sproc_tblOrder_Delete");
        }

        public void SetThisShoppingCart(clsShoppingCart cart)
        {
            this.cart = cart;
        }

        // tests not written for these yet
        public void SetThisOrder(clsOrder order) 
        {
            this.thisOrder = order;
        }

        public clsShoppingCart GetThisShoppingCart()
        {
            return this.cart;
        }

        public clsOrder GetThisOrder()
        {
            return this.thisOrder;
        }
    }
}
