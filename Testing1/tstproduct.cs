using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //test to see that it exists
            Assert.IsNotNull(AnProduct);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void ItemIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnProduct.ItemID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.ItemID, TestData);
        }

        [TestMethod]
        public void ProductTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "Test Title";
            //assign the data to the property
            AnProduct.ProductTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.ProductTitle, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "Test Description";
            //assign the data to the property
            AnProduct.ProductDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.ProductDescription, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            float TestData = 1299;
            //assign the data to the property
            AnProduct.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Price, TestData);
        }

        [TestMethod]
        public void StockNumerPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnProduct.StockNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.StockNumber, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnProduct.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.DateAdded, TestData);
        }

        [TestMethod]
        public void IsPublishedPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AnProduct.IsPublished = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.IsPublished, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ItemID = 21;
            //invoke the method
            Found = AnProduct.Find(ItemID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestItemIDFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemID = 21;
            //invoke the method
            Found = AnProduct.Find(ItemID);
            //check the ItemID property
            if (AnProduct.ItemID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
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
        public void DateAddedMinLessTwo()
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
            TestDate = TestDate.AddYears(-100).AddDays(2);
            // convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = clsProduct.Valid(ProductTitle, ProductDescription, Price, StockNumber, DateAdded, IsPublished);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
    
