using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AStaffUser = new clsStaffUser();
            //create some test data to assign to the property
            Assert.IsNotNull(AStaffUser);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AStaffUser = new clsStaffUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaffUser.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffUser.StaffID, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AStaffUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "johndoe@gmail.com";
            //assign the data to the property
            AStaffUser.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffUser.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK() 
        {
            //create an instance of the class we want to create
            clsStaffUser AStaffUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "johndoe1234";
            //assign the data to the property
            AStaffUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaffUser.Password, TestData);
        }

        [TestMethod]
        public void FindStaffUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AStaffUser = new clsStaffUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string Email = "johndoe@gmail.com";
            string Password = "johndoe1234";
            //invoke the method
            Found = AStaffUser.FindUser(Email, Password);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffUserEmailPWFound()
        {
            //create an instance of the class we want to create
            clsStaffUser AStaffUser = new clsStaffUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string Email = "johndoe@gmail.com";
            string Password = "johndoe1234";
            //invoke the method
            Found = AStaffUser.FindUser(Email, Password);
            //check the account id property
            if (AStaffUser.Email != Email && AStaffUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the results are correct
            Assert.IsTrue(OK);
        }
    }
}
