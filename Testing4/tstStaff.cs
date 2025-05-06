using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create a instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Test to see that is Exist
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create some test data to assign to the property
            String TestData = "John Doe";
            //Assign the data to the property
            AStaff.Name = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create some test data to assign to the property
            String TestData = "JohnDoe@gmail.com";
            //Assign the data to the property
            AStaff.Email = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create some test data to assign to the property
            string TestData = "JohnDoe";
            //Assign the data to the property
            AStaff.Password = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AStaff.Password, TestData);
        }

        [TestMethod]
        public void IsAdminPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create some test data to assign to the property
            bool TestData = true;
            //Assign the data to the property
            AStaff.IsAdmin = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AStaff.IsAdmin, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AStaff.DateAdded = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AStaff.DateAdded, TestData);
        }


        [TestMethod]
        public void LastLoginPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //Assign the data to the property
            AStaff.LastLogin = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AStaff.LastLogin, TestData);
        }
    }
}
