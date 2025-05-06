using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstproduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AnProduct = new clsProduct();

            Assert.IsNotNull(AnProduct);
        }

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
            string TestData = "Test Title";
            AnProduct.ProductTitle = TestData;
            Assert.AreEqual(AnProduct.ProductTitle, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            string TestData = "Test Description";
            AnProduct.ProductDescription = TestData;
            Assert.AreEqual(AnProduct.ProductDescription, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsProduct AnProduct = new clsProduct();
            float TestData = 1299;
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
    }
}
