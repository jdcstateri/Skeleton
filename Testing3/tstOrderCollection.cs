using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();
            Assert.IsNotNull(orderCollection);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();
            List<clsOrder> testList = new List<clsOrder>();
            orderCollection.SetOrderList(testList);

            Assert.AreEqual(testList, orderCollection.GetOrderList());
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();
            int testCount = 0;
            orderCollection.count = testCount;

            Assert.AreEqual(testCount, orderCollection.count);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();
            clsOrder testOrder = new clsOrder();
            orderCollection.SetThisOrder(testOrder);
            Assert.AreEqual(testOrder, orderCollection.GetThisOrder());
        }

        [TestMethod]
        public void AddOrderMethodOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();
            clsOrder testOrder = new clsOrder();
            orderCollection.AddOrder(testOrder);

            Assert.IsTrue(orderCollection.GetOrderList().Contains(testOrder));
        }

        [TestMethod]
        public void RemoveOrderMethodOK()
        {
            clsOrderCollection orderCollection = new clsOrderCollection();
            clsOrder testOrder = new clsOrder();
            orderCollection.AddOrder(testOrder);
            orderCollection.RemoveOrder(testOrder);

            Assert.IsFalse(orderCollection.GetOrderList().Contains(testOrder));
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection testOrderCollection = new clsOrderCollection();
            clsOrder testOrder = new clsOrder(1, DateTime.Now.Date, false, "Call on arrival");
            clsOrderLineCollection testOrderLineCollection = new clsOrderLineCollection();
            clsOrderLine testOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 05), "Pending", 2799.99, 1);

            testOrderLineCollection.AddOrderline(testOrderLine);
            testOrder.SetOrderLineCollection(testOrderLineCollection);

            string orderError = testOrder.Valid(testOrder.GetAccountId(), testOrder.GetDateOfDelivery(), testOrder.GetDelivered(), testOrder.GetDeliveryInstructions(), testOrder.GetOrderLineCollection());

            bool addOk = true;

            if (orderError != "")
            {
                addOk = false;
            }
            else
            {
                testOrderCollection.AddOrder(testOrder);
                testOrderCollection.SetThisOrder(testOrder);
                testOrderCollection.Add();

                clsOrder temp = new clsOrder();
                clsOrderCollection result = temp.Find(testOrder.GetOrderId(), "OrderId");

                if (result.GetOrderList().Count == 0 || result.GetThisOrder() == null)
                {
                    addOk = false;
                    Console.WriteLine("Order not found in database after adding.");
                }

                result.SetThisOrder(result.GetOrderList().First());

                if (result.GetThisOrder().GetOrderId() != testOrder.GetOrderId())
                {
                    addOk = false;
                    Console.WriteLine("Order ID mismatch after adding to database.");
                    Console.WriteLine("Expected: " + testOrder.GetOrderId() + ", Found: " + result.GetThisOrder().GetOrderId());
                }
            }

            Console.WriteLine("Order error: " + orderError);
            Assert.AreEqual(true, addOk);
        }
    }
}
