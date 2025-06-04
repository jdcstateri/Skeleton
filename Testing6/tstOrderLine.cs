using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Security.Policy;
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
        public void TestItemIdFound()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.Find(6);

            Boolean foundOK = true;
            foreach (clsOrderLine line in found.GetOrderLines())
            {
                if (line.GetItemId() != 55)
                {
                    foundOK = false;
                }
            }

            Assert.AreEqual(true, foundOK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.Find(6);
            Boolean foundOK = true;
            foreach (clsOrderLine line in found.GetOrderLines())
            {
                if (line.GetDateAdded() != new DateTime(2025, 06, 02))
                {
                    foundOK = false;
                }
            }

            Assert.AreEqual(true, foundOK);
        }

        [TestMethod]
        public void TestAgreedPriceFound()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.Find(6);
            Boolean foundOK = true;
            foreach (clsOrderLine line in found.GetOrderLines())
            {
                if (line.GetAgreedPrice() != 2799.99)
                {
                    foundOK = false;
                }
            }
            Assert.AreEqual(true, foundOK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.Find(6);
            Boolean foundOK = true;
            foreach (clsOrderLine line in found.GetOrderLines())
            {
                if (line.GetStatus() != "Pending")
                {
                    foundOK = false;
                }
            }
            Assert.AreEqual(true, foundOK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.Find(6);
            Boolean foundOK = true;
            foreach (clsOrderLine line in found.GetOrderLines())
            {
                if (line.GetQuantity() != 1)
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
        public void ValidOrderIdExtremeLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(-100, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdOneLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(0, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdMinPlusOne()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(2, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdMid()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(int.MaxValue / 2, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdMax()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(int.MaxValue, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdExtremeLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, -100, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdOneLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 0, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdMinPlusOne()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 2, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdMid()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, int.MaxValue / 2, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdMax()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, int.MaxValue, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceExtremeLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, -100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceSmallLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, -0.01, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceZero()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 0.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceMinPlusSmall()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 0.01, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceMid()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, double.MaxValue / 2, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceMax()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, double.MaxValue, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidStatusEmpty()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidStatusMax()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, new string('a', 50), 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidStatusMaxPlusOne()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, new string('a', 51), 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityExtremeLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", -100);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityOneLessThanMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 0);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityMin()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 1);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityMinPlusOne()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityMid()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", int.MaxValue / 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityMax()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", int.MaxValue);
            Assert.AreEqual(error, "");
        }
    }
}
