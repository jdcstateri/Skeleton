using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of th class we want to crete
            clsStaffColletion AllStaff = new clsStaffColletion();
            //test to seet it exist
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //Create Instance of Staff Class
            clsStaffColletion AllStaff = new clsStaffColletion();

            //Create test data to assign the property
            //In this case data has to be list of objects

            List<clsStaff> TestList = new List<clsStaff>();

            //Add an Item to the list
            clsStaff TestItem = new clsStaff();
            
            //Set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "John Doe"; 
            TestItem.Email = "johndoe@gmail.com";
            TestItem.Password = "john1234";
            TestItem.IsAdmin = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.LastLogin = DateTime.Now;

            //Addd items to the Test List
            TestList.Add(TestItem);

            //Assign the data to the property
            AllStaff.StaffList = TestList;

            //Test to see the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //Create an instance of a staff class
            clsStaffColletion AllStaff = new clsStaffColletion();

            //Create some test data
            clsStaff TestStaff= new clsStaff();

            //Set the property to test object
            TestStaff.StaffId = 1;
            TestStaff.Name = "John Doe";
            TestStaff.Email = "johndoe@gmail.com";
            TestStaff.Password = "john1234";
            TestStaff.IsAdmin = true;
            TestStaff.DateAdded = DateTime.Now;
            TestStaff.LastLogin = DateTime.Now; 

            //Assign the date to the property
            AllStaff.ThisStaff = TestStaff;

            //Test to see two values are same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of staff class
            clsStaffColletion AllStaff = new clsStaffColletion();

            //Create some test data
            List<clsStaff> TestList = new List<clsStaff>();

            //Add Item to the list
            //Create the item of the test data
            clsStaff TestItem = new clsStaff();

            //Set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "John Doe";
            TestItem.Email = "johndoe@gmail.com";
            TestItem.Password = "john1234";
            TestItem.IsAdmin = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.LastLogin = DateTime.Now;

            //Addd items to the Test List
            TestList.Add(TestItem);

            //Assign the data to the property
            AllStaff.StaffList = TestList;

            //Test to see the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }

   
}
