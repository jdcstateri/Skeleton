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
        public void IsDiscountedPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            bool TestData = true;
            NewOrderLine.SetIsDiscounted(TestData);
            Assert.AreEqual(NewOrderLine.GetIsDiscounted(), TestData);
        }

        [TestMethod]
        public void DiscountPercentagePropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            int TestData = 20;
            NewOrderLine.GetDiscountPercentage(TestData);
            Assert.AreEqual(NewOrderLine.GetDiscountPercentage(), TestData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            clsOrderLine NewOrderLine = new clsOrderLine();
            string TestData = "Out for delivery";
            NewOrderLine.SetStatus(TestData);
            Assert.AreEqual(NewOrderLine.GetStatus(), TestData);
        }
    }
}
