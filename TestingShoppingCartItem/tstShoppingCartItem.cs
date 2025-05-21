using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingShoppingCartItem
{
    [TestClass]
    public class tstShoppingCartItem
    {
        [TestMethod]
        public void InstanceOK()
        {
            int testId = 1;
            int testQuantity = 1;
            float testCost = 499.99f;
            bool testIsDiscounted = false;
            float testDiscountPercentage = 0f;

            //Create a instance of the class we want to create
            clsShoppingCartItem item = new clsShoppingCartItem(testId, testQuantity, testCost, testIsDiscounted, testDiscountPercentage);

            //Test to see that is Exist
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void TestProductIdPropertyOK()
        {
            int testId = 1;
            int testQuantity = 1;
            float testCost = 499.99f;
            bool testIsDiscounted = false;
            float testDiscountPercentage = 0f;

            //Create a instance of the class we want to create
            clsShoppingCartItem item = new clsShoppingCartItem(testId, testQuantity, testCost, testIsDiscounted, testDiscountPercentage);

            Assert.AreEqual(testId, item.ProductId);
        }

        [TestMethod]
        public void TestQuantityPropertyOK()
        {
            int testId = 1;
            int testQuantity = 1;
            float testCost = 499.99f;
            bool testIsDiscounted = false;
            float testDiscountPercentage = 0f;

            //Create a instance of the class we want to create
            clsShoppingCartItem item = new clsShoppingCartItem(testId, testQuantity, testCost, testIsDiscounted, testDiscountPercentage);

            Assert.AreEqual(testQuantity, item.Quantity);
        }

        [TestMethod]
        public void TestCostPropertyOK()
        {
            int testId = 1;
            int testQuantity = 1;
            float testCost = 499.99f;
            bool testIsDiscounted = false;
            float testDiscountPercentage = 0f;

            //Create a instance of the class we want to create
            clsShoppingCartItem item = new clsShoppingCartItem(testId, testQuantity, testCost, testIsDiscounted, testDiscountPercentage);

            Assert.AreEqual(testCost, item.Cost);
        }

        [TestMethod]
        public void TestIsDiscountedPropertyOK()
        {
            int testId = 1;
            int testQuantity = 1;
            float testCost = 499.99f;
            bool testIsDiscounted = false;
            float testDiscountPercentage = 0f;

            //Create a instance of the class we want to create
            clsShoppingCartItem item = new clsShoppingCartItem(testId, testQuantity, testCost, testIsDiscounted, testDiscountPercentage);

            Assert.AreEqual(testIsDiscounted, item.IsDiscounted);
        }

        [TestMethod]
        public void TestDiscountPercentagePropertyOK()
        {
            int testId = 1;
            int testQuantity = 1;
            float testCost = 499.99f;
            bool testIsDiscounted = false;
            float testDiscountPercentage = 0f;

            //Create a instance of the class we want to create
            clsShoppingCartItem item = new clsShoppingCartItem(testId, testQuantity, testCost, testIsDiscounted, testDiscountPercentage);

            Assert.AreEqual(testDiscountPercentage, item.DiscountPercentage);
        }
    }
}
