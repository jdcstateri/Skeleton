using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AccountID = 1;
            TestItem.IsVerified = true;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.Name = "John";
            TestItem.Email = "Email@email.com";
            TestItem.Password = "password";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //set the properties to test object
            TestItem.AccountID = 1;
            TestItem.IsVerified = true;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.Name = "John";
            TestItem.Email = "Email@email.com";
            TestItem.Password = "password";
            //Assign the data to the property
            AllCustomers.ThisCustomer = TestItem;
            //test to see if the two values are teh same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AccountID = 1;
            TestItem.IsVerified = true;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.Name = "John";
            TestItem.Email = "Email@email.com";
            TestItem.Password = "password";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountID = 1;
            TestItem.IsVerified = true;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.Name = "John";
            TestItem.Email = "Email@email.com";
            TestItem.Password = "password";
            //set ThisData to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.AccountID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsVerified = true;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.Name = "John";
            TestItem.Email = "Email@email.com";
            TestItem.Password = "password";
            //set ThisData to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.AccountID = PrimaryKey;
            //modify the test record
            TestItem.IsVerified = false;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.Name = "notJohn";
            TestItem.Email = "no@email.com";
            TestItem.Password = "nopassword";
            //set ThisData to the test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisData matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountID = 1;
            TestItem.IsVerified = true;
            TestItem.DateRegistered = DateTime.Now;
            TestItem.Name = "John";
            TestItem.Email = "Email@email.com";
            TestItem.Password = "password";
            //set ThisData to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.AccountID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if the record was found
            Assert.IsFalse(Found);
        }

    }
}
