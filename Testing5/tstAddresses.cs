using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstAddresses
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //test to see that it exists
            Assert.IsNotNull(anAddress);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            anAddress.IsActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anAddress.IsActive, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            anAddress.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anAddress.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            anAddress.AddressID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anAddress.AddressID, TestData);
        }

        [TestMethod]
        public void AccountIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            anAddress.AccountID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anAddress.AccountID, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create some test data to assign to the property
            string TestData = "Road Strret 21";
            //assign the data to the property
            anAddress.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anAddress.Address, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create some test data to assign to the property
            string TestData = "LE6 9ET";
            //assign the data to the property
            anAddress.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anAddress.PostCode, TestData);
        }
    }
}
