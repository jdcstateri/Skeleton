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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressID = 15;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressIDFound()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressID = 15;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.AddressID != 15)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountIDFound()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressID = 15;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.AccountID != 15)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressID = 15;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.DateAdded != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressID = 15;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.IsActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressID = 15;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.Address != "Road Street 15")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressID = 15;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.PostCode != "LE3 9ET")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
