using System;
using System.Collections.Generic;
using System.IO.Ports;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of clsOrder
            clsOrder NewOrder = new clsOrder();
            Assert.IsNotNull(NewOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            // Create an instance of clsOrder and check if the OrderId property is initialized 
            clsOrder NewOrder = new clsOrder();
            int testOrderId = 6;
            NewOrder.SetOrderId(testOrderId);
            Assert.AreEqual(NewOrder.GetOrderId(), testOrderId);
        }

        [TestMethod]
        public void AccountIdPropertyOK()
        {
            // Create an instance of clsOrder and check if the AccountId property is initialized
            clsOrder NewOrder = new clsOrder();
            int testOrderId = 6;
            NewOrder.SetAccountId(testOrderId);
            Assert.AreEqual(NewOrder.GetAccountId(), testOrderId);
        }

        [TestMethod]
        public void TotalCostPropertyOK()
        {
            // Create an instance of clsOrder and check if the TotalCost property is initialized
            clsOrder NewOrder = new clsOrder();
            double TestData = 499.99;
            NewOrder.SetTotalCost(TestData);
            Assert.AreEqual(NewOrder.GetTotalCost(), TestData);
        }

        [TestMethod]
        public void DateOfDeliveryPropertyOK()
        {
            // Create an instance of clsOrder and check if the DateOfDelivery property is initialized
            clsOrder NewOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            NewOrder.SetDateOfDelivery(TestData);
            Assert.AreEqual(NewOrder.GetDateOfDelivery(), TestData);
        }

        [TestMethod]
        public void DeliveredPropertyOK()
        {
            // Create an instance of clsOrder and check if the Delivered property is initialized
            clsOrder NewOrder = new clsOrder();
            bool TestData = true;
            NewOrder.SetDelivered(TestData);
            Assert.AreEqual(NewOrder.GetDelivered(), TestData);
        }

        [TestMethod]
        public void DeliveryInstructionsPropertyOK()
        {
            // Create an instance of clsOrder and check if the DeliveryInstructions property is initialized
            clsOrder NewOrder = new clsOrder();
            string TestData = "Knock on the window";
            NewOrder.SetDeliveryInstructions(TestData);
            Assert.AreEqual(NewOrder.GetDeliveryInstructions(), TestData);
        }

        [TestMethod]
        public void OrderLineCollectionPropertyOK()
        {
            // Create an instance of clsOrder and check if the OrderLineCollection property is initialized
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection TestData = new clsOrderLineCollection();
            NewOrder.SetOrderLineCollection(TestData);
            Assert.AreEqual(NewOrder.GetOrderLineCollection(), TestData);
        }

        [TestMethod]
        public void FindOrderMethodOK_ByOrderId()
        {
            // Create an instance of clsOrder and use the Find method to retrieve an order by OrderId
            clsOrder NewOrder = new clsOrder();
            NewOrder.SetOrderId(6);
            clsOrderCollection found = NewOrder.Find(NewOrder.GetOrderId(), "OrderId");

            if (found.count == 1)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void FindOrderMethodOK_ByAccountId()
        {
            // Create an instance of clsOrder and use the Find method to retrieve an order by AccountId
            clsOrder NewOrder = new clsOrder();
            NewOrder.SetAccountId(1);
            clsOrderCollection found = NewOrder.Find(NewOrder.GetAccountId(), "AccountId");

            if (found.count >= 1)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestValidMethodOK()
        {
            // Create an instance of clsOrder and validate it with valid parameters
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestAccountIdFound()
        {
            // Create an instance of clsOrder and check if the AccountId is found correctly using existing order
            clsOrder NewOrder = new clsOrder();
            bool OK = true;
            NewOrder.SetOrderId(6);
            clsOrderCollection found = NewOrder.Find(NewOrder.GetOrderId(), "OrderId");

            List<clsOrder> orderList = found.GetOrderList();
            NewOrder = orderList[0];

            if (NewOrder.GetAccountId() != 1)
            {
                OK = false;
            }

            Console.WriteLine("Database value: " + NewOrder.GetAccountId());
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfDeliveryFound()
        {
            // Create an instance of clsOrder and check if the DateOfDelivery is found correctly using existing order
            clsOrder NewOrder = new clsOrder();
            bool OK = true;
            NewOrder.SetOrderId(6);
            clsOrderCollection found = NewOrder.Find(NewOrder.GetOrderId(), "OrderId");
            DateTime testDate = new DateTime(2025, 6, 16);

            List<clsOrder> orderList = found.GetOrderList();
            NewOrder = orderList[0];

            if (NewOrder.GetDateOfDelivery() != testDate)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveredFound()
        {
            // Create an instance of clsOrder and check if the Delivered status is found correctly using existing order
            clsOrder NewOrder = new clsOrder();
            bool OK = true;
            NewOrder.SetOrderId(6);
            clsOrderCollection found = NewOrder.Find(NewOrder.GetOrderId(), "OrderId");

            List<clsOrder> orderList = found.GetOrderList();
            NewOrder = orderList[0];

            if (NewOrder.GetDelivered() != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryInstructionsFound()
        {
            // Create an instance of clsOrder and check if the DeliveryInstructions are found correctly using existing order
            clsOrder NewOrder = new clsOrder();
            bool OK = true;
            NewOrder.SetOrderId(6);
            clsOrderCollection found = NewOrder.Find(NewOrder.GetOrderId(), "OrderId");
            string testInstructions = "Go to backdoor";

            List<clsOrder> orderList = found.GetOrderList();
            NewOrder = orderList[0];

            if (NewOrder.GetDeliveryInstructions() != testInstructions)
            {
                OK = false;
            }

            Console.WriteLine("Database value: " + NewOrder.GetDeliveryInstructions());

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderLineCollectionFound()
        {
            // Create an instance of clsOrder and check if the OrderLineCollection is found correctly using existing order and orderlines
            clsOrder NewOrder = new clsOrder();
            clsOrderLine testOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1);
            testOrderLine.SetOrderId(6);
            bool OK = true;
            NewOrder.SetOrderId(6);
            clsOrderCollection found = NewOrder.Find(NewOrder.GetOrderId(), "OrderId");
            NewOrder.SetOrderLineCollection(testOrderLine.FindAll(NewOrder.GetOrderId()));

            clsOrderLineCollection testCollection = new clsOrderLineCollection();

            testCollection.AddOrderline(testOrderLine);

            if (!NewOrder.GetOrderLineCollection().Equals(testCollection))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestValidAccountIdLessThanOne()
        {
            // Create an instance of clsOrder and validate with an AccountId less than 1
            clsOrder NewOrder = new clsOrder();
            string error = NewOrder.Valid(0, DateTime.Now.AddDays(14), false, "Knock on the window", new clsOrderLineCollection());
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestValidAccountIdMin()
        {
            // Create an instance of clsOrder and validate with an AccountId of 1
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidAccountIdMinPlusOne()
        {
            // Create an instance of clsOrder and validate with an AccountId of 2
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(2, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidAccountIdMid()
        {
            // Create an instance of clsOrder and validate with a mid-range AccountId
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid((int.MaxValue / 2), DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidAccountIdMax()
        {
            // Create an instance of clsOrder and validate with the maximum possible AccountId
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(int.MaxValue, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidDateOfDeliveryExtremeLessThanMin()
        {
            // Create an instance of clsOrder and validate with a DateOfDelivery in the past
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(-100), false, "Knock on the window", tempCollection);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestValidDateOfDeliveryOneLessThanMin()
        {
            // Create an instance of clsOrder and validate with a DateOfDelivery one day in the past
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(-1), false, "Knock on the window", tempCollection);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestValidDateOfDeliveryMin()
        {
            // Create an instance of clsOrder and validate with a DateOfDelivery set to today
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.Date, false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidDateOfDeliveryMinPlusOne()
        {
            // Create an instance of clsOrder and validate with a DateOfDelivery one day in the future
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(1), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidDateOfDeliveryExtremeMax()
        {
            // Create an instance of clsOrder and validate with a DateOfDelivery set to 180 days in the future
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(180), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidDateOfDeliveryMaxPlusOne()
        {
            // Create an instance of clsOrder and validate with a DateOfDelivery set to 181 days in the future
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(181), false, "Knock on the window", tempCollection);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestDeliveryInstructionsEmpty()
        {
            // Create an instance of clsOrder and validate with empty DeliveryInstructions 
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, "", tempCollection);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestDeliveryInstructionsMin()
        {
            // Create an instance of clsOrder and validate with minimum DeliveryInstructions length
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, "a", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestDeliveryInstructionsExtremeMax()
        {
            // Create an instance of clsOrder and validate with maximum DeliveryInstructions length
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, new string('a', 50), tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestDeliveryInstructionsMaxPlusOne()
        {
            // Create an instance of clsOrder and validate with DeliveryInstructions exceeding maximum length
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, new string('a', 51), tempCollection);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestDeliveredAtCreation()
        {
            // Create an instance of clsOrder and validate with Delivered set to true at creation
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), true, "Knock on the window", tempCollection);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestOrderLineCollectionEmpty()
        {
            // Create an instance of clsOrder and validate with an empty OrderLineCollection
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestOrderLineCollectionMin()
        {
            // Create an instance of clsOrder and validate with a minimum OrderLineCollection containing one order line
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }
    }
}