using System;
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
            int TestData = 1;
            NewOrder.OrderId = TestData;
            Assert.AreEqual(NewOrder.OrderId, TestData);
        }

        [TestMethod]
        public void AccountIdPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            int TestData = 1;
            NewOrder.AccountId = TestData;
            Assert.AreEqual(NewOrder.AccountId, TestData);
        }

        [TestMethod]
        public void TotalCostPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            float TestData = 399.99f;
            NewOrder.TotalCost = TestData;
            Assert.AreEqual(NewOrder.TotalCost, TestData);
        }

        [TestMethod]
        public void DateOfDeliveryPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            NewOrder.DateOfDelivery = TestData;
            Assert.AreEqual(NewOrder.DateOfDelivery, TestData);
        }

        [TestMethod]
        public void DeliveredPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            bool TestData = true;
            NewOrder.Delivered = TestData;
            Assert.AreEqual(NewOrder.Delivered, TestData);
        }

        [TestMethod]
        public void DeliveryInstructionsPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            string TestData = "Knock on the window";
            NewOrder.DeliveryInstructions = TestData;
            Assert.AreEqual(NewOrder.DeliveryInstructions, TestData);
        }
    }
}
