using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstAddresses
    {
        //good test date
        //create some test data to pass the method
        string DateAdded = DateTime.Now.ToShortDateString();
        string Address = "Road Street 9";
        string PostCode = "LE2 9FR";
        string AccountID = "1";

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
            Int32 AddressID = 2;
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
            Int32 AddressID = 2;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.AddressID != 2)
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
            Int32 AddressID = 2;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.AccountID != 1)
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
            Int32 AddressID = 2;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.DateAdded != Convert.ToDateTime("30/04/2025"))
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
            Int32 AddressID = 2;
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
            Int32 AddressID = 2;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.Address != "Random 1")
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
            Int32 AddressID = 2;
            //invoke the method
            Found = anAddress.Find(AddressID);
            //check the account id
            if (anAddress.PostCode != "LE7 2AD")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100); //should fail
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1); //should fail
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date; //should pass
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1); //should fail
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100); //should fail
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "This is not a date!";
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the Address
            string Address = "";
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the Address
            string Address = "a";
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the Address
            string Address = "aa";
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the Address
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the Address
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the Address
            string Address = "";
            Address = Address.PadRight(51, 'a');
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the Address
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the PostCode
            string PostCode = "";
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the PostCode
            string PostCode = "a";
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the PostCode
            string PostCode = "aa";
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the PostCode
            string PostCode = "";
            PostCode = PostCode.PadRight(49, 'a');
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the PostCode
            string PostCode = "";
            PostCode = PostCode.PadRight(50, 'a');
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the PostCode
            string PostCode = "";
            PostCode = PostCode.PadRight(51, 'a');
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsAddresses anAddress = new clsAddresses();
            //string variable to store any error message
            String Error = "";
            //set the PostCode
            string PostCode = "";
            PostCode = PostCode.PadRight(25, 'a');
            //invoke the method
            Error = anAddress.Valid(DateAdded, Address, PostCode, AccountID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
