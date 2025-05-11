using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstproduct
    {
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
    }
}
