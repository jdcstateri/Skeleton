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
            NewOrder.SetOrderId(TestData);
            Assert.AreEqual(NewOrder.GetOrderId(), TestData);
        }

        [TestMethod]
        public void AccountIdPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            int TestData = 1;
            NewOrder.SetAccountId(TestData);
            Assert.AreEqual(NewOrder.GetAccountId(), TestData);
        }

        [TestMethod]
        public void TotalCostPropertyOK()
        {
            clsOrder NewOrder = new clsOrder();
            double TestData = 399.99f;
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
    }
}
