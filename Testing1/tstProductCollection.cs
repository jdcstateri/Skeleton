using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Constraints;

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
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsPublished = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that it exists
            Assert.IsNotNull(AllProducts.ProductList);
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
            TestProduct.DateAdded = DateTime.Now;
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
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsPublished = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllProducts.Count, AllProducts.ProductList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            // create a new instance of the data connection
            clsProductCollection AllProducts = new clsProductCollection();
            // create the item of test data
            clsProduct TestItem = new clsProduct();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.ItemID = 1;
            TestItem.ProductTitle = "GMZ 480z";
            TestItem.ProductDescription = "Best Personal Computer";
            TestItem.Price = 1580f;
            TestItem.StockNumber = 3;
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsPublished = true;
            // set thisproduct to the test data
            AllProducts.ThisProduct = TestItem;
            // add the record
            PrimaryKey = AllProducts.Add();
            // set the primary key of the test data
            TestItem.ItemID = PrimaryKey;
            // find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            // Test to see if the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

    }

}
