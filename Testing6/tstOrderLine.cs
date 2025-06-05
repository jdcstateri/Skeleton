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
            // Create an instance of clsOrderLine
            clsOrderLine NewOrderLine = new clsOrderLine();
            Assert.IsNotNull(NewOrderLine);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            // Create an instance of clsOrderLine and check the OrderId property is initialized
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 1;
            NewOrderLine.SetOrderId(TestData);
            Assert.AreEqual(NewOrderLine.GetOrderId(), TestData);
        }

        [TestMethod]
        public void ItemIdPropertyOK()
        {
            // Create an instance of clsOrderLine and check the ItemId property is initialized
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 1;
            NewOrderLine.SetItemId(TestData);
            Assert.AreEqual(NewOrderLine.GetItemId(), TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            // Create an instance of clsOrderLine and check the DateAdded property is initialized
            clsOrderLine NewOrderLine = new clsOrderLine();
            DateTime TestData = DateTime.Now.Date;
            NewOrderLine.SetDateAdded(TestData);
            Assert.AreEqual(NewOrderLine.GetDateAdded(), TestData);
        }

        [TestMethod]
        public void AgreedPricePropertyOK()
        {
            // Create an instance of clsOrderLine and check the AgreedPrice property is initialized
            clsOrderLine NewOrderLine = new clsOrderLine();
            double TestData = 499.99;
            NewOrderLine.SetAgreedPrice(TestData);
            Assert.AreEqual(NewOrderLine.GetAgreedPrice(), TestData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            // Create an instance of clsOrderLine and check the Status property is initialized
            clsOrderLine NewOrderLine = new clsOrderLine();
            string TestData = "Out for delivery";
            NewOrderLine.SetStatus(TestData);
            Assert.AreEqual(NewOrderLine.GetStatus(), TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            // Create an instance of clsOrderLine and check the Quantity property is initialized
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 5;
            NewOrderLine.SetQuantity(TestData);
            Assert.AreEqual(NewOrderLine.GetQuantity(), TestData);
        }

        [TestMethod]
        public void FindOrderLineByIdOK()
        {
            // Create an instance of clsOrderLineCollection and add a test order line
            clsOrderLineCollection TestCollection = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1);
            TestOrderLine.SetOrderId(6);
            TestCollection.AddOrderline(TestOrderLine);

            // Find the order lines by OrderId
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.FindAll(6);

            Boolean collectionsMatch = TestCollection.Equals(found);

            Assert.AreEqual(true, collectionsMatch);
        }

        [TestMethod]
        public void FindOrderLineByOrderIdItemIdOK()
        {
            // Create an instance of clsOrderLineCollection and add a test order line
            clsOrderLineCollection TestCollection = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine(55, new DateTime(2025, 06, 02), "Pending", 2799.99, 1);
            TestOrderLine.SetOrderId(6);
            TestCollection.AddOrderline(TestOrderLine);

            // Find the order lines by OrderId
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.FindOrderLine(6, 55);

            Boolean collectionsMatch = TestCollection.Equals(found);

            Assert.AreEqual(true, collectionsMatch);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            // Create an instance of clsOrderline and find order lines by OrderId
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.FindAll(6);

            Boolean foundOK = true;

            // Check if the OrderId of each found order line matches the expected value
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
            // Create an instance of clsOrderLine and find order lines by OrderId
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.FindAll(6);

            Boolean foundOK = true;

            // Check if the ItemId of each found order line matches the expected value
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
            // Create an instance of clsOrderLine and find order lines by OrderId
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.FindAll(6);

            Boolean foundOK = true;

            // Check if the DateAdded of each found order line matches the expected value
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
            // Create an instance of clsOrderLine and find order lines by OrderId
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.FindAll(6);

            Boolean foundOK = true;

            // Check if the AgreedPrice of each found order line matches the expected value
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
            // Create an instance of clsOrderLine and find order lines by OrderId
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.FindAll(6);

            Boolean foundOK = true;

            // Check if the Status of each found order line matches the expected value
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
            // Create an instance of clsOrderLine and find order lines by OrderId
            clsOrderLine NewOrderLine = new clsOrderLine();
            clsOrderLineCollection found = NewOrderLine.FindAll(6);

            Boolean foundOK = true;

            // Check if the Quantity of each found order line matches the expected value
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
            // Create an instance of clsOrderLine and validate the properties
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 2);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdExtremeLessThanMin()
        {
            // Create an instance of clsOrderLine and validate the OrderId with an extreme value less than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(-100, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdOneLessThanMin()
        {
            // Create an instance of clsOrderLine and validate the OrderId with a value one less than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(0, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdMin()
        {
            // Create an instance of clsOrderLine and validate the OrderId with the minimum value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdMinPlusOne()
        {
            // Create an instance of clsOrderLine and validate the OrderId with a value one greater than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(2, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdMid()
        {
            // Create an instance of clsOrderLine and validate the OrderId with a mid-range value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(int.MaxValue / 2, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidOrderIdMax()
        {
            // Create an instance of clsOrderLine and validate the OrderId with the maximum possible value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(int.MaxValue, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdExtremeLessThanMin()
        {
            // Create an instance of clsOrderLine and validate the ItemId with an extreme value one less than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, -100, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdOneLessThanMin()
        {
            // Create an instance of clsOrderLine and validate the ItemId with a value one less than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 0, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdMin()
        {
            // Create an instance of clsOrderLine and validate the ItemId with the minimum value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdMinPlusOne()
        {
            // Create an instance of clsOrderLine and validate the ItemId with a value one greater than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 2, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdMid()
        {
            // Create an instance of clsOrderLine and validate the ItemId with a mid-range value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, int.MaxValue / 2, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidItemIdMax()
        {
            // Create an instance of clsOrderLine and validate the ItemId with the maximum possible value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, int.MaxValue, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceExtremeLessThanMin()
        {
            // Create an instance of clsOrderLine and validate the AgreedPrice with an extreme value less than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, -100.00, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceSmallLessThanMin()
        {
            // Create an instance of clsOrderLine and validate the AgreedPrice with a small value less than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, -0.01, "Pending", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceZero()
        {
            // Create an instance of clsOrderLine and validate the AgreedPrice with zero
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 0.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceMinPlusSmall()
        {
            // Create an instance of clsOrderLine and validate the AgreedPrice with a small value greater than zero
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 0.01, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceMid()
        {
            // Create an instance of clsOrderLine and validate the AgreedPrice with a mid-range value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, double.MaxValue / 2, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidAgreedPriceMax()
        {
            // Create an instance of clsOrderLine and validate the AgreedPrice with the maximum possible value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, double.MaxValue, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidStatusEmpty()
        {
            // Create an instance of clsOrderLine and validate the Status with an empty string
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "", 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidStatusMax()
        {
            // Create an instance of clsOrderLine and validate the Status with the maximum length
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, new string('a', 50), 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidStatusMaxPlusOne()
        {
            // Create an instance of clsOrderLine and validate the Status with a string longer than the maximum length
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, new string('a', 51), 2);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityExtremeLessThanMin()
        {
            // Create an instance of clsOrderLine and validate the Quantity with an extreme value less than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", -100);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityOneLessThanMin()
        {
            // Create an instance of clsOrderLine and validate the Quantity with a value one less than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 0);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityMin()
        {
            // Create an instance of clsOrderLine and validate the Quantity with the minimum value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 1);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityMinPlusOne()
        {
            // Create an instance of clsOrderLine and validate the Quantity with a value one greater than the minimum
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityMid()
        {
            // Create an instance of clsOrderLine and validate the Quantity with a mid-range value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", int.MaxValue / 2);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ValidQuantityMax()
        {
            // Create an instance of clsOrderLine and validate the Quantity with the maximum possible value
            clsOrderLine NewOrderLine = new clsOrderLine();
            string error = NewOrderLine.Valid(1, 1, DateTime.Now, 100.00, "Pending", int.MaxValue);
            Assert.AreEqual(error, "");
        }
    }
}
