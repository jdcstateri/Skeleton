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
        public void StaffIDPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            int TestData = 1;
            AStaff.StaffId = TestData;
            Assert.AreEqual(AStaff.StaffId, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //Create some test data to use with the method
            Int32 StaffId = 2;

            //Invoke the method
            Found = AStaff.Find(StaffId);

            //Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 StaffId = 2;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //Check the Staff Id
            if (AStaff.StaffId != 2)
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 StaffId = 2;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //Check the Staff Id
            if (AStaff.Name != "John Doe")
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 StaffId = 2;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //Check the Staff Id
            if (AStaff.Email != "Johndoe@gmail.com")
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPassword()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 StaffId = 2;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //Check the Staff Id
            if (AStaff.Password != "johndoe1234")
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIsAdmin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 StaffId = 2;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //Check the Staff Id
            if (AStaff.IsAdmin != true)
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDateAdded()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 StaffId = 2;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //Check the Staff Id
            if (AStaff.DateAdded != Convert.ToDateTime("25/12/2024"))
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffLastLogin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 StaffId = 2;

            //invoke the method
            Found = AStaff.Find(StaffId);

            //Check the Staff Id
            if (AStaff.LastLogin != Convert.ToDateTime("25/12/2024 00:20:00"))
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
