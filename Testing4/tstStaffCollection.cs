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
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to seet it exist
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //Create Instance of Staff Class
            clsStaffCollection AllStaff = new clsStaffCollection();

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
            clsStaffCollection AllStaff = new clsStaffCollection();

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
            clsStaffCollection AllStaff = new clsStaffCollection();

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
            clsStaffCollection AllStaff = new clsStaffCollection();
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
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create the item of the test data
            clsStaff TestItem = new clsStaff();
            //Variable to store the primary key
            Int32 PrimaryKey = 0;

            //Set its properties
            TestItem.Name = "John Doe";
            TestItem.Email = "JohnDoe@gmail.com";
            TestItem.Password = "john1234";
            TestItem.IsAdmin = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.LastLogin = DateTime.Now;

            //Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;

            //Add the record and get the Primary Key
            PrimaryKey = AllStaff.Add();  // This should return a valid Primary Key from the insert
            TestItem.StaffId = PrimaryKey;

            //Find the record (or retrieve it after insertion)
            TestItem.Name = "NoName";
            TestItem.Email = "NoEmail";
            TestItem.Password = "noPassword";
            TestItem.DateAdded = DateTime.Now;
            TestItem.LastLogin = DateTime.Now;

            //set ThisData to the test data
            AllStaff.ThisStaff = TestItem;

            //update the record
            AllStaff.Update();

            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);

            //test to see if ThisData matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]

        public void ReportByStaffNameMethodOK()
        {
            //create an instance of Staff Name Method
            clsStaffCollection AllStaff = new clsStaffCollection();

            //create an instance of a filter Name data
            clsStaffCollection FilteredName = new clsStaffCollection();

            //apply blank string (should return all the records);
            FilteredName.ReportByName("");

            //test to see that two value are equal
            Assert.AreEqual(AllStaff.Count, FilteredName.Count);
        }

        [TestMethod]
        public void ReportByStaffNameNoneFound()
        {

            //Create instance of the class we want to create
            clsStaffCollection FilteredName = new clsStaffCollection();

            //Apply the name that doesn't exist
            FilteredName.ReportByName("xxxxxx");

            //Test to see that there are no records
            Assert.AreEqual(0, FilteredName.Count);
        }

        [TestMethod]
        public void ReportByStaffNameTestDataFound()
        {
            //Create an instance of a filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            //variable to store the outcome
            Boolean OK = true;

            //apply the name that doesn't Exist
            FilteredStaff.ReportByName("Alice");

            //Check the data correct number of records are found
            if(FilteredStaff.Count == 1)
            {
                //Check to see the first record is 6
                if (FilteredStaff.StaffList[0].StaffId != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }


}
