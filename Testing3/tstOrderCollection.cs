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
        public void EqualsMethodOK()
        {
            // Create two identical order collections
            clsOrderCollection orderCollection1 = new clsOrderCollection();
            clsOrderCollection orderCollection2 = new clsOrderCollection();

            // Populate both collections with the same order
            clsOrder testOrder1 = new clsOrder(1, DateTime.Now.Date, false, "Call on arrival");
            clsOrder testOrder2 = new clsOrder(1, DateTime.Now.Date, false, "Call on arrival");

            // Add the orders to both collections
            orderCollection1.AddOrder(testOrder1);
            orderCollection2.AddOrder(testOrder2);

            // Check if the two collections are equal
            Assert.IsTrue(orderCollection1.Equals(orderCollection2));
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create a new order collection, order, order line collection, and order line
            clsOrderCollection testOrderCollection = new clsOrderCollection();
            clsOrder testOrder = new clsOrder(1, DateTime.Now.Date, false, "Call on arrival");
            clsOrderLineCollection testOrderLineCollection = new clsOrderLineCollection();
            clsOrderLine testOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 05), "Pending", 2799.99, 1);

            // Add the order line to the order line collection and set it in the order
            testOrderLineCollection.AddOrderline(testOrderLine);
            testOrder.SetOrderLineCollection(testOrderLineCollection);

            // Validate the order
            string orderError = testOrder.Valid(testOrder.GetAccountId(), testOrder.GetDateOfDelivery(), testOrder.GetDelivered(), testOrder.GetDeliveryInstructions(), testOrder.GetOrderLineCollection());

            bool addOk = true;

            if (orderError != "")
            {
                addOk = false;
            }
            else
            {
                // Add the order to the collection and database
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

                if (!result.Equals(testOrderCollection))
                {
                    addOk = false;
                    Console.WriteLine("Order found does not match the temporary test order.");
                    testOrderCollection.GetOrderCollectionByText();
                }
            }

            Assert.AreEqual(true, addOk);
        }

        [TestMethod]
        public void EditMethodOK()
        {
            // Create a new order collection, order, order line collection, and order line
            clsOrderCollection testOrderCollection = new clsOrderCollection();
            clsOrder testOrder = new clsOrder(1, DateTime.Now.Date, false, "Call on arrival");
            clsOrderLineCollection testOrderLineCollection = new clsOrderLineCollection();
            clsOrderLine testOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 05), "Pending", 2799.99, 1);

            // Add the order line to the order line collection and set it in the order
            testOrderLineCollection.AddOrderline(testOrderLine);
            testOrder.SetOrderLineCollection(testOrderLineCollection);

            // Validate the order
            string orderError = testOrder.Valid(testOrder.GetAccountId(), testOrder.GetDateOfDelivery(), testOrder.GetDelivered(), testOrder.GetDeliveryInstructions(), testOrder.GetOrderLineCollection());

            bool addOk = true;
            clsOrderCollection result = new clsOrderCollection();

            if (orderError != "")
            {
                addOk = false;
            }
            else
            {
                // Add the order to the collection and database
                testOrderCollection.AddOrder(testOrder);
                testOrderCollection.SetThisOrder(testOrder);
                testOrderCollection.Add();

                // Create a new order which will be used to insert new values, overwriting old ones
                clsOrder testOrder2 = new clsOrder();
                testOrder2.SetOrderId(testOrder.GetOrderId());
                testOrder2.SetDateOfDelivery(testOrder.GetDateOfDelivery());
                testOrder2.SetDelivered(true);
                testOrder2.SetDeliveryInstructions("Updated delivery instructions");

                // removes the first test order from the test order collection, and sets the second test order as the current order
                testOrderCollection.SetOrderList(new List<clsOrder>());
                testOrderCollection.SetThisOrder(testOrder2);
                testOrderCollection.AddOrder(testOrder2);

                // Edit the order in the database
                testOrderCollection.Edit();

                // Find the order in the database to verify it was edited correctly
                result = testOrder2.Find(testOrder2.GetOrderId(), "OrderId");

                // Check if the order was found in the database
                if (result.GetOrderList().Count == 0 || result.GetThisOrder() == null)
                {
                    addOk = false;
                    Console.WriteLine("Order not found in database after adding.");
                }

                // Checks that the found order's values match tempory test order 2
                if (!result.Equals(testOrderCollection))
                {
                    addOk = false;
                    Console.WriteLine("Order found does not match the temporary test order.");
                    testOrderCollection.GetOrderCollectionByText();
                }
            }

            Assert.AreEqual(true, addOk);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create a new order collection, order, order line collection, and order line
            clsOrderCollection testOrderCollection = new clsOrderCollection();
            clsOrder testOrder = new clsOrder(1, DateTime.Now.Date, false, "Call on arrival");
            clsOrderLineCollection testOrderLineCollection = new clsOrderLineCollection();
            clsOrderLine testOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 05), "Pending", 2799.99, 1);

            // Add the order line to the order line collection and set it in the order
            testOrderLineCollection.AddOrderline(testOrderLine);
            testOrder.SetOrderLineCollection(testOrderLineCollection);

            // Validate the order
            string orderError = testOrder.Valid(testOrder.GetAccountId(), testOrder.GetDateOfDelivery(), testOrder.GetDelivered(), testOrder.GetDeliveryInstructions(), testOrder.GetOrderLineCollection());
            bool addOk = true;

            clsOrderCollection result = new clsOrderCollection();

            if (orderError != "")
            {
                addOk = false;
            }
            else
            {
                // Add the order to the collection and database
                testOrderCollection.AddOrder(testOrder);
                testOrderCollection.SetThisOrder(testOrder);
                testOrderCollection.Add();

                // Delete the order from the database
                testOrderCollection.Delete();

                // Find the order in the database to verify it was deleted correctly
                result = testOrder.Find(testOrder.GetOrderId(), "OrderId");
                // Check if the order was found in the database

                if (result.GetCount() > 0)
                {
                    addOk = false;
                    Console.WriteLine("Found orders in database after deletion.");
                }
            }

            Assert.AreEqual(true, addOk);
        }
    }
}
