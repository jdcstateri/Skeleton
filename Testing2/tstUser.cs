using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnUser = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void AccountIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnUser = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.AccountID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.AccountID, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnUser = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Joe@email.com";
            //assign the data to the property
            AnUser.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnUser = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "JoePassword#1";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnUser = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string Email = "jsmith@email.com";
            string Password = "PasswordOfJoe1";
            //invoke the method
            Found = AnUser.FindUser(Email, Password);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserEmailPWFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnUser = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string Email = "jsmith@email.com";
            string Password = "PasswordOfJoe1";
            //invoke the method
            Found = AnUser.FindUser(Email, Password);
            //check the account id property
            if (AnUser.Email != Email && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
    }
}
