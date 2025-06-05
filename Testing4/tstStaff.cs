using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        //Create some test data to assign to the property
        string Name = "John Doe";                // Only letters and a space — valid
        string Email = "john.doe@example.com";   // Valid email format
        string Password = "JohnDoe123!";       // No spaces, less than 50 characters, special characters included
        string IsAdmin = "true";
        string DateAdded = DateTime.Now.Date.ToString(); // Exactly today’s date
        string LastLogin = DateTime.Now.ToString(); // Exactly today’s date

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


        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create a string variable to store the error
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date`
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100); //should fail
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store test data
            DateTime TestDate;
            //Set time to todays date
            TestDate = DateTime.Now.Date; //should pass
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the DateRegistered to a non date value
            string DateAdded = "This is not a date!";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FindNonExistentStaff()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a variable to store the StaffId
            Int32 StaffId = -1; //assuming this ID does not exist
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see that the result is false
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void StaffIDExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            int TestData = int.MaxValue; // 2,147,483,647
            AStaff.StaffId = TestData;
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffIDMaxMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            int TestData = int.MaxValue - 1; // 2,147,483,646
            AStaff.StaffId = TestData;
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffIDZero()
        {
            clsStaff AStaff = new clsStaff();
            int TestData = 0; // Typically invalid for IDs
            AStaff.StaffId = TestData;
            Assert.AreEqual(AStaff.StaffId, TestData); // Still sets, but may fail in DB
        }


        [TestMethod]
        public void FindWithExtremeStaffID()
        {
            clsStaff AStaff = new clsStaff();
            bool Found = false;
            int StaffId = int.MaxValue; // Extremely unlikely to exist
            Found = AStaff.Find(StaffId);
            Assert.IsFalse(Found); // Should return false (not found)
        }



        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "a";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "ab";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "abc";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            Name = Name.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            Name = Name.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameWithInvalidCharacters()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name with invalid characters
            string Name = "John@Doe1";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameWithSQLInjection()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the name with SQL injection characters
            string Name = "John'; DROP TABLE Staff; --";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinValidFormat()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "a@b.c";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "aa@bb.cc"; //5 chars-valid format
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string localPart = new string('a', 39); // 39 chars
            string Email = $"{localPart}@test.com"; // 49 chars total
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLengthValid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            string domain = new string('a', 30);
            Email = $"test@{domain}.com"; //Exactly 50 characters
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            string tooLong = new string('a', 41);
            Email = $"{tooLong}@gmail.com"; //51 characters
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email
            string Email = "";
            string localPart = new string('a', 15); // 15 chars
            Email = $"{localPart}@test.com";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailInvalidMissingAt()
        {
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email with invalid format
            string Email = "johndoe.com"; //missing '@'
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailWithInvalidMissingDomain()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email with invalid format
            string Email = "invalidgmail@";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailInvalidWithSpaces()
        {
            clsStaff AStaff = new clsStaff();
            string badEmail = "john doe@gmail.com"; // Space in address
            string Error = AStaff.Valid(Name, badEmail, Password, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailWithSQLInjection()
        {
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Email with SQL injection characters
            string Email = "john'; DROP TABLE Staff; --@test.com";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "Abc123!"; //7 chars (below minimum
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "Abc123!@";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "Abc123!@x";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "A1!" + new string('a', 44) + "9Z"; //49 chars

            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "A1!" + new string('a', 45) + "9Z"; //50 chars
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "A1!" + new string('a', 46) + "9Z";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the Password
            string Password = "A1!" + new string('a', 20) + "9Z";
            //invoke the method
            Error = AStaff.Valid(Name, Email, Password, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
