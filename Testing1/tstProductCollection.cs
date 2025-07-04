﻿using System;
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
        [TestMethod]
        public void UpdateMethodOK()
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
            // modify the test data
            TestItem.ProductTitle = "HBlock 240e";
            TestItem.ProductDescription = "Safest PC";
            TestItem.Price = 1280f;
            TestItem.StockNumber = 2;
            TestItem.DateAdded = DateTime.Now;
            TestItem.IsPublished = false;
            // set thisproduct to the test data
            AllProducts.ThisProduct = TestItem;
            // update the record
            AllProducts.Update();
            // find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            // create a new instance of the data connection
            clsProductCollection AllProducts = new clsProductCollection();
            // create the item of test data
            clsProduct TestItem = new clsProduct();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.ItemID = 55;
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
            // delete the record
            AllProducts.Delete();
            // now find the record again
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            // test to see that it does not exist
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByProductTitleMethodOK()
        {
            // create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            // create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            // apply a blank string (should return all records)
            FilteredProducts.ReportByProductTitle("");
            // test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportByProductNoneFound()
        {
            // create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            // apply a product title that does not exist
            FilteredProducts.ReportByProductTitle("xxxx");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportByProductFound()
        {
            // create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            //variable to store outcome
            Boolean OK = true;
            // apply a product title that doesn't exist
            FilteredProducts.ReportByProductTitle("Ryzen 7");
            // check that the correct number of records are found
            if (FilteredProducts.Count == 2)
            {
                // check that the first record is ID 1
                if (FilteredProducts.ProductList[0].ItemID != 279)
                {
                    OK = false;
                }
                // check that the second record is ID 2
                if (FilteredProducts.ProductList[1].ItemID != 280)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that there is at least one record
            Assert.IsTrue(OK);
        }




    }

}
