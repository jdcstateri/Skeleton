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
    }
}
