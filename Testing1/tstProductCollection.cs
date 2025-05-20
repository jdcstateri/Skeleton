using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }
        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ItemID = 1;
            TestItem.ProductTitle = "Test Title";
            TestItem.ProductDescription = "Test Description";
            TestItem.Price = 199.99f;
            TestItem.StockNumber = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.IsPublished = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.mProductList = TestList;
            //test to see that it exists
            Assert.IsNotNull(AllProducts.mProductList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllProducts.Count = SomeCount;
            //test to see that it exists
            Assert.AreEqual(AllProducts.Count, SomeCount); // Fix: Corrected the order of arguments
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //set its properties
            TestProduct.ItemID = 1;
            TestProduct.ProductTitle = "Test Title";
            TestProduct.ProductDescription = "Test Description";
            TestProduct.Price = 199.99f;
            TestProduct.StockNumber = 1;
            TestProduct.DateAdded = DateTime.Now.Date;
            TestProduct.IsPublished = true;
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that it exists
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ItemID = 1;
            TestItem.ProductTitle = "Test Title";
            TestItem.ProductDescription = "Test Description";
            TestItem.Price = 199.99f;
            TestItem.StockNumber = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.IsPublished = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.mProductList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllProducts.Count, AllProducts.mProductList.Count);
        }
        [TestMethod]
        public void TwoRecoredsPresent()
        {
            // create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that two values are same
            Assert.AreEqual(AllProducts.Count, 2);
        }
    }
}
