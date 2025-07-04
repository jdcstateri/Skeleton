﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstAddressesCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAddressesCollection AllAddresses = new clsAddressesCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAddresses);
        }

        [TestMethod]
        public void AddressListOK()
        {
            //create an instance of the class we want to create
            clsAddressesCollection AllAddresses = new clsAddressesCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsAddresses> TestList = new List<clsAddresses>();
            //Add an item to the list
            //create the item of test data
            clsAddresses TestItem = new clsAddresses();
            //set its properties
            TestItem.AddressID = 1;
            TestItem.AccountID = 1;
            TestItem.IsActive = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.PostCode = "LE3 2ET";
            TestItem.Address = "Leicester Sreet Road 21";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAddresses.AddressesList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.AddressesList, TestList);
        }

        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddressesCollection AllAddresses = new clsAddressesCollection();
            //create some test data to assign to the property
            clsAddresses TestItem = new clsAddresses();
            //set the properties to test object
            TestItem.AddressID = 1;
            TestItem.AccountID = 1;
            TestItem.IsActive = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.PostCode = "LE3 2ET";
            TestItem.Address = "Leicester Sreet Road 21";
            //Assign the data to the property
            AllAddresses.ThisAddress = TestItem;
            //test to see if the two values are teh same
            Assert.AreEqual(AllAddresses.ThisAddress, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsAddressesCollection AllAddresses = new clsAddressesCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsAddresses> TestList = new List<clsAddresses>();
            //Add an item to the list
            //create the item of test data
            clsAddresses TestItem = new clsAddresses();
            //set its properties
            TestItem.AddressID = 1;
            TestItem.AccountID = 1;
            TestItem.IsActive = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.PostCode = "LE3 2ET";
            TestItem.Address = "Leicester Sreet Road 21";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAddresses.AddressesList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsAddressesCollection AllAddresses = new clsAddressesCollection();
            //create the item of test data
            clsAddresses TestItem = new clsAddresses();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AddressID = 1;
            TestItem.AccountID = 3;
            TestItem.IsActive = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.PostCode = "LE3 2ET";
            TestItem.Address = "Leicester Sreet Road 21";
            //set ThisData to the test data
            AllAddresses.ThisAddress = TestItem;
            //add the record
            PrimaryKey = AllAddresses.Add();
            //set the primary key of the test data
            TestItem.AddressID = PrimaryKey;
            //find the record
            AllAddresses.ThisAddress.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.ThisAddress, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsAddressesCollection AllAddresses = new clsAddressesCollection();
            //create the item of test data
            clsAddresses TestItem = new clsAddresses();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountID = 3;
            TestItem.IsActive = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.PostCode = "LE3 2ET";
            TestItem.Address = "Leicester Sreet Road 21";
            //set ThisData to the test data
            AllAddresses.ThisAddress = TestItem;
            //add the record
            PrimaryKey = AllAddresses.Add();
            //set the primary key of the test data
            TestItem.AddressID = PrimaryKey;
            //modify the test record
            TestItem.AccountID = 3;
            TestItem.IsActive = false;
            TestItem.DateAdded = DateTime.Now;
            TestItem.PostCode = "le1 e52";
            TestItem.Address = "nomans street";
            //set ThisData to the test data
            AllAddresses.ThisAddress = TestItem;
            //update the record
            AllAddresses.Update();
            //find the record
            AllAddresses.ThisAddress.Find(PrimaryKey);
            //test to see if ThisData matches the test data
            Assert.AreEqual(AllAddresses.ThisAddress, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsAddressesCollection AllAddresses = new clsAddressesCollection();
            //create the item of test data
            clsAddresses TestItem = new clsAddresses();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AddressID = 1;
            TestItem.AccountID = 3;
            TestItem.IsActive = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.PostCode = "LE3 2ET";
            TestItem.Address = "Leicester Sreet Road 21";
            //set ThisData to the test data
            AllAddresses.ThisAddress = TestItem;
            //add the record
            PrimaryKey = AllAddresses.Add();
            //set the primary key of the test data
            TestItem.AddressID = PrimaryKey;
            //find the record
            AllAddresses.ThisAddress.Find(PrimaryKey);
            //delete the record
            AllAddresses.Delete();
            //now find the record
            Boolean Found = AllAddresses.ThisAddress.Find(PrimaryKey);
            //test to see if the record was found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK ()
        {
            //create an instance of the class we want to create
            clsAddressesCollection AllAddresses = new clsAddressesCollection();
            //create an instance of filtered data
            clsAddressesCollection FilteredAddresses = new clsAddressesCollection();
            //apply a blank string (should return all records);
            FilteredAddresses.ReportByPostCode("");
            //test to see that the two are the same
            Assert.AreEqual(AllAddresses.Count, FilteredAddresses.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the class we want to create
            clsAddressesCollection FilteredAddresses = new clsAddressesCollection();
            FilteredAddresses.ReportByPostCode("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredAddresses.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the class we want to create
            clsAddressesCollection FilteredAddresses = new clsAddressesCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredAddresses.ReportByPostCode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredAddresses.Count == 2)
            {
                //check to see that the first record is 38
                if (FilteredAddresses.AddressesList[0].AddressID != 38)
                {
                    OK = false;
                }
                //check to see that the first record is 39
                if (FilteredAddresses.AddressesList[1].AddressID != 39)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }


    }
}
