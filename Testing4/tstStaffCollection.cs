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

        [TestMethod]
        public void AddMethodOK()
        {
            //Create a instance of a class we want to create
            clsStaffColletion AllStaff = new clsStaffColletion();
            //Create the item of the test data
            clsStaff TestItem = new clsStaff();
            //Variable to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "John Doe";
            TestItem.Email = "JohnDoe@gmail.com";
            TestItem.Password = "john1234";
            TestItem.IsAdmin = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.LastLogin = DateTime.Now;
            //Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.Add();
            //Set the primary key to the test data
            TestItem.StaffId = PrimaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create a instance of a class we want to create
            clsStaffColletion AllStaff = new clsStaffColletion();
            //Create the item of the test data
            clsStaff TestItem = new clsStaff();
            //Variable to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.StaffId = PrimaryKey;
            TestItem.Name = "John Doe";
            TestItem.Email = "JohnDoe@gmail.com";
            TestItem.Password = "john1234";
            TestItem.IsAdmin = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.LastLogin = DateTime.Now;
            //Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.Update();
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

    }

   
}
