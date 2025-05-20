using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test date
        //create some test data to pass the method
        string DateRegistered = DateTime.Now.ToShortDateString();
        string Name = "Joe";
        string Email = "Joe@gmail.com";
        string Password = "JoePassword1";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void IsVerifiedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aCustomer.IsVerified = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.IsVerified, TestData);
        }

        [TestMethod]
        public void DateRegisteredPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aCustomer.DateRegistered = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.DateRegistered, TestData);
        }

        [TestMethod]
        public void AccountIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aCustomer.AccountID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.AccountID, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Joe";
            //assign the data to the property
            aCustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Joe@email.com";
            //assign the data to the property
            aCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "JoePassword#1";
            //assign the data to the property
            aCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Password, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AccountID = 2;
            //invoke the method
            Found = aCustomer.Find(AccountID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAccountIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AccountID = 2;
            //invoke the method
            Found = aCustomer.Find(AccountID);
            //check the account id
            if (aCustomer.AccountID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateRegisteredFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AccountID = 2;
            //invoke the method
            Found = aCustomer.Find(AccountID);
            //check the property
            if (aCustomer.DateRegistered != Convert.ToDateTime("30/04/2025"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsVerifiedFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AccountID = 2;
            //invoke the method
            Found = aCustomer.Find(AccountID);
            //check the property
            if (aCustomer.IsVerified != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AccountID = 2;
            //invoke the method
            Found = aCustomer.Find(AccountID);
            //check the property
            if (aCustomer.Name != "Travis Webber")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AccountID = 2;
            //invoke the method
            Found = aCustomer.Find(AccountID);
            //check the property
            if (aCustomer.Email != "tweb@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AccountID = 2;
            //invoke the method
            Found = aCustomer.Find(AccountID);
            //check the property
            if (aCustomer.Password != "twebbb23")
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
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100); //should fail
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1); //should fail
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date; //should pass
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1); //should fail
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100); //should fail
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateRegistered to a non date value
            string DateRegistered = "This is not a date!";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "a";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "aa";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            Name = Name.PadRight(49, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            Name = Name.PadRight(51, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "a";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "aa";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "a";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "aa";
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "";
            Password = Password.PadRight(49, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "";
            Password = Password.PadRight(50, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "";
            Password = Password.PadRight(51, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "";
            Password = Password.PadRight(25, 'a');
            //invoke the method
            Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
