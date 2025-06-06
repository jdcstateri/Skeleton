using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// Removed NUnit.Framework.Constraints if not used.

namespace Testing1
{
    [TestClass]
    public class tstProductUser // Keeping the original class name as requested
    {
        // No TestContext property provided in your snippet, but recommended for cleanup.

        [TestMethod]
        public void InstanceOk()
        {
            clsProductUser productUser = new clsProductUser();
            Assert.IsNotNull(productUser);
        }

        [TestMethod]
        public void StaffIDPropertyOk()
        {
            clsProductUser productUser = new clsProductUser();
            int testStaffID = 1;
            productUser.StaffID = testStaffID;
            Assert.AreEqual(productUser.StaffID, testStaffID);
        }

        [TestMethod]
        public void NamePropertyOk()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "John Doe";
            AnUser.Name = TestData;
            Assert.AreEqual(AnUser.Name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOk()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "JohnDoe@gmail.com";
            AnUser.Email = TestData;
            Assert.AreEqual(AnUser.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            string TestData = "john1234";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void IsAdminPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            bool testIsAdmin = true;
            AnUser.IsAdmin = testIsAdmin;
            Assert.AreEqual(AnUser.IsAdmin, testIsAdmin);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            DateTime TestDate = DateTime.Parse("23/05/2025");
            AnUser.DateAdded = TestDate;
            Assert.AreEqual(AnUser.DateAdded, TestDate);
        }

        [TestMethod]
        public void LastLoginPropertyOK()
        {
            clsProductUser AnUser = new clsProductUser();
            DateTime TestDate = DateTime.Parse("23/05/2025");
            AnUser.LastLogin = TestDate;
            Assert.AreEqual(AnUser.LastLogin, TestDate);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsProductUser AnUser = new clsProductUser(); // Correct class
            Boolean Found = false;
            string Email = "johndoe@gmail.com";
            string Password = "johndoe1234"; // Confirm this is the actual password in DB for this email

            Found = AnUser.FindUser(Email, Password);
            Assert.IsTrue(Found, "It should return true for valid login details.");
        }

        [TestMethod]
        public void TestUserPropertiesPopulatedAfterFind() // Renamed for clarity on purpose
        {
            clsProductUser AnUser = new clsProductUser(); // FIX: CRITICAL - Instantiate clsProductUser, not clsCustomer
            Boolean Found = false;
            // No need for 'OK' flag if asserting directly

            // Test data MUST match a record in your tblStaff
            string TestEmail = "Johndoe@gmail.com";
            string TestPassword = "johndoe1234";
            int ExpectedStaffID = 2; // From your image, for JohnDoe@gmail.com, john1234
            string ExpectedName = "John Doe"; // From your image
            bool ExpectedIsAdmin = true; // From your image
            DateTime ExpectedDateAdded = DateTime.Parse("2024-12-25"); // From your image
            DateTime ExpectedLastLogin = DateTime.Parse("2024-12-25 00:20:00.000"); // From your image

            Found = AnUser.FindUser(TestEmail, TestPassword);
            Assert.IsTrue(Found, "User should be found with valid credentials.");

            // FIX: Assert directly that the retrieved properties match expected values
            Assert.AreEqual(ExpectedStaffID, AnUser.StaffID, "StaffID mismatch after find.");
            Assert.AreEqual(ExpectedName, AnUser.Name, "Name mismatch after find.");
            Assert.AreEqual(TestEmail, AnUser.Email, "Email mismatch after find.");
            Assert.AreEqual(TestPassword, AnUser.Password, "Password mismatch after find.");
            Assert.AreEqual(ExpectedIsAdmin, AnUser.IsAdmin, "IsAdmin mismatch after find.");
            // For DateTime, compare dates only or be very precise with time
            Assert.AreEqual(ExpectedDateAdded.Date, AnUser.DateAdded.Date, "DateAdded mismatch after find (date part).");
            // For LastLogin, float comparisons can be tricky, check if time component is also stored
            Assert.AreEqual(ExpectedLastLogin, AnUser.LastLogin, "LastLogin mismatch after find.");
        }

        [TestMethod]
        public void FindUserMethodNotFound()
        {
            clsProductUser AnUser = new clsProductUser(); // FIX: Instantiate clsProductUser
            bool Found = AnUser.FindUser("nonexistent@gmail.com", "wrongpassword"); // Using clearly non-existent data
            Assert.IsFalse(Found, "It should return false for non-existent login details.");
        }

        [TestMethod]
        public void FindUserMethodInvalidPassword() // Renamed for clarity
        {
            clsProductUser AnUser = new clsProductUser(); // FIX: Instantiate clsProductUser
            // Use a valid email but an incorrect password for a known user
            bool Found = AnUser.FindUser("JohnDoe@gmail.com", "incorrectpassword");
            Assert.IsFalse(Found, "It should return false for invalid password.");
        }

        // Test method for incorrect email (assuming the SP returns false for wrong email, regardless of password)
        [TestMethod]
        public void FindUserMethodInvalidEmail() // Renamed for clarity
        {
            clsProductUser AnUser = new clsProductUser(); // FIX: Instantiate clsProductUser
            // Use an incorrect email but a correct password (if exists) for a known user
            bool Found = AnUser.FindUser("incorrectmail@gmail.com", "john1234");
            Assert.IsFalse(Found, "It should return false for invalid email.");
        }

        
    }
}