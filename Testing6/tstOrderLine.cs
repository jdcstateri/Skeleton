using System;
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
            NewOrderLine.OrderId = TestData;
            Assert.AreEqual(NewOrderLine.OrderId, TestData);
        }

        [TestMethod]
        public void ItemIdPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 1;
            NewOrderLine.ItemId = TestData;
            Assert.AreEqual(NewOrderLine.ItemId, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            DateTime TestData = DateTime.Now.Date;
            NewOrderLine.DateAdded = TestData;
            Assert.AreEqual(NewOrderLine.DateAdded, TestData);
        }

        [TestMethod]
        public void IsDiscountedPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            bool TestData = true;
            NewOrderLine.IsDiscounted = TestData;
            Assert.AreEqual(NewOrderLine.IsDiscounted, TestData);
        }

        [TestMethod]
        public void DiscountPercentagePropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 20;
            NewOrderLine.DiscountPercentage = TestData;
            Assert.AreEqual(NewOrderLine.DiscountPercentage, TestData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string TestData = "Out for delivery";
            NewOrderLine.Status = TestData;
            Assert.AreEqual(NewOrderLine.Status, TestData);
        }
    }
}
