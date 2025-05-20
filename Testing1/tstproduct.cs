using System;
using System.IO;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace Testing1
{
    [TestClass]
    public class tstproduct
    {
        // Goood Test Data
        // Create some test data to pass to the method
        string ProductTitle = "Product Title";
        string ProductDescription = "Product Description";
        string Price = "1299";
        string StockNumber = "1";
        string DateAdded = DateTime.Now.ToShortDateString();
        string IsPublished = "true";



        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AnProduct = new clsProduct();
            Assert.IsNotNull(AnProduct);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void ItemIDPropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            Int32 TestData = 1;
            AnProduct.ItemID = TestData;
            Assert.AreEqual(AnProduct.ItemID, TestData);
        }

        [TestMethod]
        public void ProductTitlePropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            string TestData = "MSI MAG Infinite S3";
            AnProduct.ProductTitle = TestData;
            Assert.AreEqual(AnProduct.ProductTitle, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            string TestData = "High-speed gaming desktop";
            AnProduct.ProductDescription = TestData;
            Assert.AreEqual(AnProduct.ProductDescription, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            float TestData = 1200;
            AnProduct.Price = TestData;
            Assert.AreEqual(AnProduct.Price, TestData);
        }

        [TestMethod]
        public void StockNumerPropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            Int32 TestData = 1;
            AnProduct.StockNumber = TestData;
            Assert.AreEqual(AnProduct.StockNumber, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            DateTime TestData = DateTime.Now.Date;
            AnProduct.DateAdded = TestData;
            Assert.AreEqual(AnProduct.DateAdded, TestData);
        }

        [TestMethod]
        public void IsPublishedPropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            bool TestData = true;
            AnProduct.IsPublished = TestData;
            Assert.AreEqual(AnProduct.IsPublished, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Int32 ItemID = 1;
            Found = AnProduct.Find(ItemID);
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestItemIDFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemID = 1;
            Found = AnProduct.Find(ItemID);
            if (AnProduct.ItemID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK() 
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // create a string variable to store the error message
            string Error = "";
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle,ProductDescription,Price,StockNumber,DateAdded,IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        /***Validation***/

        // Product Title
        [TestMethod]
        public void ProductTitleMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // create a string variable to store the error message
            string Error = "";
            // create some test data to pass to the method
            string ProductTitle = "";
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        

        [TestMethod]
        public void ProductTitleMin()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // String variable to strore any message
            String Error = "";
            // create some test data to pass to the method
            string ProductTitle = "a"; // This should be the minimum length
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void ProductTitleMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // String variable to strore any message
            String Error = "";
            // create some test data to pass to the method
            string ProductTitle = "aa"; // This should be the minimum length + 1
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductTitleMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // String variable to strore any message
            String Error = "";
            // create some test data to pass to the method
            string ProductTitle = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // This should be the maximum length - 1
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductTitleMax()
        {
            //  create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // String variable to strore any message
            String Error = "";
            // create some test data to pass to the method
            string ProductTitle = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // This should be the maximum length
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductTitleMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // String variable to strore any message
            String Error = "";
            // create some test data to pass to the method
            string ProductTitle = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // This should be the maximum length + 1
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductTitleMid()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // String variable to strore any message
            String Error = "";
            // create some test data to pass to the method
            string ProductTitle = "aaaaaaaaaaaaaaaaaaaaaaaaa"; // This should be the mid of max length
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductTitleExtremeMax()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to strore any message
            String Error = "";
            // create some test data to pass to the method
            string ProductTitle = "";
            ProductTitle = ProductTitle.PadLeft(500, 'a'); // This should be extreme max length
            // Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        // Product Description
        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            // create an instance of the class we want to create 
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string ProductDescription = "";
            //Invoke the method 
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMin()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string ProductDescription = "a"; // This should be the minimum length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string ProductDescription = "aa"; // This should be the minimum length + 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message 
            String Error = "";
            // Create some test data to pass to the method
            string ProductDescription = "".PadRight(249, 'a'); // This should be the maximum length - 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMax()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string ProductDescription = "".PadRight(250, 'a'); // This should be the maximum length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string ProductDescription = "".PadRight(251, 'a'); // This should be the maximum length + 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMid()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string ProductDescription = "".PadRight(125, 'a'); // This should be the mid of max length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string ProductDescription = "".PadRight(500, 'a'); // This should be extreme max length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string Price = "0"; // This should be the minimum length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string Price = "1"; // This should be the minimum length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string Price = "2"; // This should be the minimum length + 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string Price = "".PadRight(7, '9'); // This should be the maximum length - 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string Price = "".PadRight(8, '9'); // This should be the maximum length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string Price = "".PadRight(9, '9'); // This should be the maximum length + 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string Price = "".PadRight(4, '9'); // This should be the mid of max length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string Price = "".PadRight(500, '9'); // This should be extreme max length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNumberMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string StockNumber = "0"; // This should be the minimum length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNumberMin()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string StockNumber = "1"; // This should be the minimum length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNumberMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string StockNumber = "2"; // This should be the minimum length + 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNumberMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string StockNumber = "".PadRight(7, '9'); // This should be the maximum length - 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNumberMax()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string StockNumber = "".PadRight(8, '9'); // This should be the maximum length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNumberMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string StockNumber = "".PadRight(9, '9'); // This should be the maximum length + 1
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNumberMid()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string StockNumber = "".PadRight(4, '9'); // This should be the mid of max length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNumberExtremeMax()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create some test data to pass to the method
            string StockNumber = "".PadRight(500, '9'); // This should be extreme max length
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        // Date Added
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create a variable to store the date
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            // convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            // string variable to store any message
            String Error = "";
            // create a variable to store the date
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever date is less than 100 years
            TestDate = TestDate.AddYears(-100).AddDays(-1);
            // convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever date is less than 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to 1 day less than 100 years in the future
            TestDate = TestDate.AddYears(100).AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMax()
        {
            //create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever date is greater than 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever date is greater than 100 years
            TestDate = TestDate.AddYears(100).AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMid()
        {
            //create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever date is greater than 100 years
            TestDate = TestDate.AddYears(50);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct clsProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to 200 years in the future (well beyond the limit)
            TestDate = TestDate.AddYears(200);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
    
