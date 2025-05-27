using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing7
{
    [TestClass]
    public class tstShoppingCart
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create a instance of the class we want to create
            clsShoppingCart shoppingCart = new clsShoppingCart();

            //Test to see that is Exist
            Assert.IsNotNull(shoppingCart);
        }

        [TestMethod]
        public void ShoppingCartListPropertyOK()
        {
            // test items
            clsShoppingCartItem testItem1 = new clsShoppingCartItem(6, 1, 1200.0f);
            clsShoppingCartItem testItem2 = new clsShoppingCartItem(8, 2, 600.0f);
            
            List<clsShoppingCartItem> items = new List<clsShoppingCartItem>()
            {
                testItem1, testItem2
            };

            clsShoppingCart shoppingCart = new clsShoppingCart(items);

            Assert.AreEqual(shoppingCart.GetShoppingCart(), items);
        }

        [TestMethod]
        public void TestAddItem()
        {
            // test item
            clsShoppingCartItem testItem1 = new clsShoppingCartItem(6, 1, 1200.0f);

            List<clsShoppingCartItem> items = new List<clsShoppingCartItem>()
            {
                testItem1
            };

            clsShoppingCart shoppingCart = new clsShoppingCart(items);

            Assert.AreEqual(shoppingCart.GetShoppingCart(), items);
        }

        [TestMethod]
        public void TestRemoveItem()
        {
            // test items
            clsShoppingCartItem testItem1 = new clsShoppingCartItem(6, 1, 1200.0f);
            clsShoppingCartItem testItem2 = new clsShoppingCartItem(8, 2, 600.0f);

            List<clsShoppingCartItem> items = new List<clsShoppingCartItem>()
            { 
                testItem1 , testItem2
            };

            clsShoppingCart shoppingCart = new clsShoppingCart(items);

            shoppingCart.RemoveItem(testItem2);

            Assert.AreEqual(shoppingCart.GetShoppingCart(), items);
        }

    }
}
