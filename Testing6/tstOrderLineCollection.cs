using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of clsOrderLineCollection
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();
            Assert.IsNotNull(orderLineCollection);
        }

        [TestMethod]
        public void OrderlineListOK()
        {
            // Create an instance of clsOrderLineCollection
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();

            Assert.IsNotNull(orderLineCollection.GetOrderLines());
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            // Create an instance of clsOrderLineCollection
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();

            Assert.AreEqual(0, orderLineCollection.GetCount());
        }

        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            // Create an instance of clsOrderLineCollection
            clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();
            clsOrderLine orderLine = new clsOrderLine(1, DateTime.Now, "Pending", 100.0, 2);
            orderLineCollection.SetThisOrderLine(orderLine);

            Assert.AreEqual(orderLine, orderLineCollection.GetThisOrderLine());
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of clsOrderLineCollection, clsShoppingCart and clsOrder
            clsOrderLineCollection testOrderLineCollection = new clsOrderLineCollection();
            clsShoppingCart cart = new clsShoppingCart();
            clsOrder testOrder = new clsOrder(1, new DateTime(2025, 6, 16), false, "Go to backdoor");
            testOrder.SetOrderId(6);

            // Add a shopping cart item to the cart 
            cart.AddItem(new clsShoppingCartItem(56, 1, 950.00));

            // Create the test order line
            clsOrderLine testOrderLine = new clsOrderLine(56, DateTime.Now.Date, "Pending", 950.00, 1);   
            testOrderLine.SetOrderId(testOrder.GetOrderId());

            // Validate the order line 
            string error = testOrderLine.Valid(testOrder.GetOrderId(), testOrderLine.GetItemId(), testOrderLine.GetDateAdded(), testOrderLine.GetAgreedPrice(), testOrderLine.GetStatus(), testOrderLine.GetQuantity());
            
            bool addOk = true;

            if (error != "")
            {
                addOk = false;
            }
            else
            {
                // Add the order line to the collection and database
                testOrderLineCollection.AddOrderline(testOrderLine);
                testOrderLineCollection.SetThisOrderLine(testOrderLine);
                testOrderLineCollection.Add(cart, testOrder);

                clsOrderLine temp = new clsOrderLine();
                clsOrderLineCollection result = temp.FindOrderLine(testOrderLine.GetOrderId(), testOrderLine.GetItemId());

                // Check if the order lines was found in the database
                if (result.GetOrderLines().Count == 0)
                {
                    addOk = false;
                    Console.WriteLine("Order not found in database after adding.");
                }

                // Checks that the found order's values match the temporary test order
                if (!result.Equals(testOrderLineCollection))
                {
                    addOk = false;
                    Console.WriteLine("Order found does not match the temporary test order.");
                    result.GetOrderLineCollectionByText();
                    testOrderLineCollection.GetOrderLineCollectionByText();
                }
            }

            testOrderLineCollection.Delete();
            Assert.AreEqual(true, addOk);
        }

        [TestMethod]
        public void EditMethodOK()
        {
            // Create an instance of clsOrderLineCollection, clsShoppingCart and clsOrder
            clsOrderLineCollection testOrderLineCollection = new clsOrderLineCollection();
            clsShoppingCart cart = new clsShoppingCart();
            clsOrder testOrder = new clsOrder(1, new DateTime(2025, 6, 16), false, "Go to backdoor");
            testOrder.SetOrderId(6);

            // Add a shopping cart item to the cart 
            cart.AddItem(new clsShoppingCartItem(57, 1, 950.00));

            // Create the test order line
            clsOrderLine testOrderLine = new clsOrderLine(57, DateTime.Now.Date, "Pending", 950.00, 2);
            testOrderLine.SetOrderId(testOrder.GetOrderId());

            // Validate the order line 
            string error = testOrderLine.Valid(testOrder.GetOrderId(), testOrderLine.GetItemId(), testOrderLine.GetDateAdded(), testOrderLine.GetAgreedPrice(), testOrderLine.GetStatus(), testOrderLine.GetQuantity());

            bool addOk = true;
    
            if (error != "")
            {
                addOk = false;
            }
            else
            {

                // Add the order line to the collection and database
                testOrderLineCollection.AddOrderline(testOrderLine);
                testOrderLineCollection.SetThisOrderLine(testOrderLine);
                testOrderLineCollection.Add(cart, testOrder);

                // Create a new order line which will be used to insert new values, overwriting old ones
                clsOrderLine testOrderLine2 = new clsOrderLine(57, DateTime.Now.Date, "Updated Status Test", 850.00, 2);
                testOrderLine2.SetOrderId(testOrder.GetOrderId());

                // removes the first test order line from the test order line collection, and sets the second test order line as the current order line
                testOrderLineCollection.SetOrderLines(new List<clsOrderLine>());
                testOrderLineCollection.SetThisOrderLine(testOrderLine2);
                testOrderLineCollection.AddOrderline(testOrderLine2);

                // Edit the order line in the database
                testOrderLineCollection.Edit();

                // Find the order line in the database to verify it was edited correctly
                clsOrderLineCollection result = testOrderLine2.FindOrderLine(testOrderLine.GetOrderId(), testOrderLine.GetItemId());

                // Check if the order was found in the database
                if (result.GetOrderLines().Count == 0)
                {
                    addOk = false;
                    Console.WriteLine("Order not found in database after adding.");
                }

                // Checks that the found order's values match tempory test order 2
                if (!result.Equals(testOrderLineCollection))
                {
                    addOk = false;
                    Console.WriteLine("Order found does not match the temporary test order.");
                    result.GetOrderLineCollectionByText();
                    testOrderLineCollection.GetOrderLineCollectionByText();
                }
            }

            testOrderLineCollection.Delete();
            Assert.AreEqual(true, addOk);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of clsOrderLineCollection, clsShoppingCart and clsOrder
            clsOrderLineCollection testOrderLineCollection = new clsOrderLineCollection();
            clsShoppingCart cart = new clsShoppingCart();
            clsOrder testOrder = new clsOrder(1, new DateTime(2025, 6, 16), false, "Go to backdoor");
            testOrder.SetOrderId(6);

            // Add a shopping cart item to the cart 
            cart.AddItem(new clsShoppingCartItem(58, 1, 950.00));

            // Create the test order line
            clsOrderLine testOrderLine = new clsOrderLine(58, DateTime.Now.Date, "Pending", 950.00, 1);
            testOrderLine.SetOrderId(testOrder.GetOrderId());

            // Validate the order line 
            string error = testOrderLine.Valid(testOrder.GetOrderId(), testOrderLine.GetItemId(), testOrderLine.GetDateAdded(), testOrderLine.GetAgreedPrice(), testOrderLine.GetStatus(), testOrderLine.GetQuantity());
            bool addOk = true;

            if (error != "")
            {
                addOk = false;
            }
            else
            {
                // Add the order line to the collection and database
                testOrderLineCollection.AddOrderline(testOrderLine);
                testOrderLineCollection.SetThisOrderLine(testOrderLine);
                testOrderLineCollection.Add(cart, testOrder);

                // Delete the order line from the collection and database
                testOrderLineCollection.Delete();

                // Find the order line in the database to verify it was deleted correctly
                clsOrderLineCollection result = testOrderLine.FindOrderLine(testOrderLine.GetOrderId(), testOrderLine.GetItemId());

                // Check if the order was found in the database
                if (result.GetCount() > 0)
                {
                    addOk = false;
                    Console.WriteLine("Deleted order found in database after deletion.");
                }
            }

            Assert.AreEqual(true, addOk);
        }
    }
}