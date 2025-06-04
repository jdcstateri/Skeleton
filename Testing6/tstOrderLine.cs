using System;
using System.Collections.Generic;
using System.IO.Ports;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            Assert.IsNotNull(NewOrderLine);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 1;
            NewOrderLine.SetOrderId(TestData);
            Assert.AreEqual(NewOrderLine.GetOrderId(), TestData);
        }

        [TestMethod]
        public void ItemIdPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 1;
            NewOrderLine.SetItemId(TestData);
            Assert.AreEqual(NewOrderLine.GetItemId(), TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            DateTime TestData = DateTime.Now.Date;
            NewOrderLine.SetDateAdded(TestData);
            Assert.AreEqual(NewOrderLine.GetDateAdded(), TestData);
        }

        [TestMethod]
        public void AgreedPricePropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            double TestData = 499.99;
            NewOrderLine.SetAgreedPrice(TestData);
            Assert.AreEqual(NewOrderLine.GetAgreedPrice(), TestData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string TestData = "Out for delivery";
            NewOrderLine.SetStatus(TestData);
            Assert.AreEqual(NewOrderLine.GetStatus(), TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 5;
            NewOrderLine.SetQuantity(TestData);
            Assert.AreEqual(NewOrderLine.GetQuantity(), TestData);
        }

        [TestMethod]
        public void FindOrderLineByIdOK()
        {
            clsOrderLineCollection TestCollection = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1);
            TestOrderLine.SetOrderId(6);
            TestCollection.AddOrderline(TestOrderLine);

            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.Find(6);

            Boolean collectionsMatch = TestCollection.Equals(found);

            Assert.AreEqual(true, collectionsMatch);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.Find(6);
            
            Boolean foundOK = true;

            foreach (clsOrderLine line in found.GetOrderLines())
            {
                if (line.GetOrderId() != 6)
                {
                    foundOK = false;
                }
            }

            Assert.AreEqual(true, foundOK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 2);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidMethodExtremeLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(-100, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidMethodInvalidLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(0, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }
    }
}
