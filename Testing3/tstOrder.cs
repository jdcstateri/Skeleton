using System;
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
            clsOrder NewOrder = new clsOrder();
            Assert.IsNotNull(NewOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            int testOrderId = 6;
            NewOrder.SetOrderId(testOrderId);
            Assert.AreEqual(NewOrder.GetOrderId(), testOrderId);
        }

        [TestMethod]
        public void AccountIdPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            int testOrderId = 6;
            NewOrder.SetAccountId(testOrderId);
            Assert.AreEqual(NewOrder.GetAccountId(), testOrderId);
        }

        [TestMethod]
        public void TotalCostPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            double TestData = 499.99;
            NewOrder.SetTotalCost(TestData);
            Assert.AreEqual(NewOrder.GetTotalCost(), TestData);
        }

        [TestMethod]
        public void DateOfDeliveryPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            NewOrder.SetDateOfDelivery(TestData);
            Assert.AreEqual(NewOrder.GetDateOfDelivery(), TestData);
        }

        [TestMethod]
        public void DeliveredPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            bool TestData = true;
            NewOrder.SetDelivered(TestData);
            Assert.AreEqual(NewOrder.GetDelivered(), TestData);
        }

        [TestMethod]
        public void DeliveryInstructionsPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            string TestData = "Knock on the window";
            NewOrder.SetDeliveryInstructions(TestData);
            Assert.AreEqual(NewOrder.GetDeliveryInstructions(), TestData);
        }

        [TestMethod]
        public void OrderLineCollectionPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection TestData = new clsOrderLineCollection();
            NewOrder.SetOrderLineCollection(TestData);
            Assert.AreEqual(NewOrder.GetOrderLineCollection(), TestData);
        }

        [TestMethod]
        public void FindOrderMethodOK()
        {
            clsOrder NewOrder = new clsOrder();
            NewOrder.SetOrderId(6);
            bool found = NewOrder.Find();
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestValidMethodOK()
        {
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestAccountIdFound()
        {
            clsOrder NewOrder = new clsOrder();
            bool OK = true;
            NewOrder.SetOrderId(6);
            bool found = NewOrder.Find();

            if (NewOrder.GetAccountId() != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfDeliveryFound()
        {
            clsOrder NewOrder = new clsOrder();
            bool OK = true;
            NewOrder.SetOrderId(6);
            bool found = NewOrder.Find();
            DateTime testDate = new DateTime(2025, 6, 16);

            if (NewOrder.GetDateOfDelivery() != testDate)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveredFound()
        {
            clsOrder NewOrder = new clsOrder();
            bool OK = true;
            NewOrder.SetOrderId(6);
            bool found = NewOrder.Find();

            if (NewOrder.GetDelivered() != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryInstructionsFound()
        {
            clsOrder NewOrder = new clsOrder();
            bool OK = true;
            NewOrder.SetOrderId(6);
            bool found = NewOrder.Find();
            string testInstructions = "Go to backdoor";

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
            clsOrder NewOrder = new clsOrder();
            clsOrderLine testOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1);
            testOrderLine.SetOrderId(6);
            bool OK = true;
            NewOrder.SetOrderId(6);
            bool found = NewOrder.Find();
            NewOrder.SetOrderLineCollection(testOrderLine.Find(NewOrder.GetOrderId()));

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
            clsOrder NewOrder = new clsOrder();
            string error = NewOrder.Valid(0, DateTime.Now.AddDays(14), false, "Knock on the window", new clsOrderLineCollection());
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TestValidAccountIdMin()
        {
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(1, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidAccountIdMinPlusOne()
        {
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(2, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidAccountIdMax()
        {
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid(int.MaxValue, DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TestValidAccountIdMid()
        {
            clsOrder NewOrder = new clsOrder();
            clsOrderLineCollection tempCollection = new clsOrderLineCollection();
            tempCollection.AddOrderline(new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1));

            string error = NewOrder.Valid((int.MaxValue / 2), DateTime.Now.AddDays(14), false, "Knock on the window", tempCollection);
            Assert.AreEqual(error, "");
        }
    }
}