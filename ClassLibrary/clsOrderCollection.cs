using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        private List<clsOrder> orderList = new List<clsOrder>();
        public int count = 0;
        private clsOrder thisOrder = new clsOrder();

        public clsOrderCollection(){}

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

        public bool Equals(clsOrderCollection other)
        {
            if (this.GetCount() != other.GetCount())
            {
                return false;
            }

            for (int i = 0; i < this.GetCount(); i++)
            {
                clsOrder thisLine = this.orderList[i];
                clsOrder otherLine = other.orderList[i];

                if (thisLine.GetOrderId() != otherLine.GetOrderId() ||
                    thisLine.GetDateOfDelivery() != otherLine.GetDateOfDelivery() ||
                    thisLine.GetDelivered() != otherLine.GetDelivered() ||
                    thisLine.GetDeliveryInstructions() != otherLine.GetDeliveryInstructions())
                {
                    return false;
                }
            }

            return true;
        }

        public void AddOrder(clsOrder order)
        {
            orderList.Add(order);
            count++;
        }

        public void RemoveOrder(clsOrder order)
        {
            orderList.Remove(order);
            count--;
        }

        public clsOrder GetThisOrder()
        {
            return thisOrder;
        }

        public void SetThisOrder(clsOrder order) 
        {
            thisOrder = order;
        }

        public List<clsOrder> GetOrderList()
        {
            return orderList;
        }

        public void SetOrderList(List<clsOrder> orders)
        {
            orderList = orders;
            count = orders.Count;
        }

        public int GetCount()
        {
            return count;
        }

        public void SetCount(int value)
        {
            count = value;
        }

        // for debugging, do not use in production code
        public void GetOrderCollectionByText()
        {
            foreach (clsOrder order in orderList)
            {
                Console.WriteLine("Order ID: " + order.GetOrderId());
                Console.WriteLine("Date Of Delivery: " + order.GetDateOfDelivery());
                Console.WriteLine("Delivered: " + order.GetDelivered());
                Console.WriteLine("Delivery Instructions: " + order.GetDeliveryInstructions());

                Console.WriteLine("-----------------------------");
            }
        }
    }
}
