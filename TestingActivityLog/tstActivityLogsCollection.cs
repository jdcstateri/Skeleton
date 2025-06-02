using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingActivityLog
{
    public class tstActivityLogsCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of th class we want to crete
            clsActivityLogCollection AllActivityLogs = new clsActivityLogCollection();
            //test to seet it exist
            Assert.IsNotNull(AllActivityLogs);
        }

        [TestMethod]
        public void ActivityLogListOK()
        {
            //Create Instance of Staff Class
            clsActivityLogCollection AllActivityLogs = new clsActivityLogCollection();

            //Create test data to assign the property
            //In this case data has to be list of objects

            List<clsActivityLog> TestList = new List<clsActivityLog>();

            //Add an Item to the list
            clsActivityLog TestItem = new clsActivityLog();

            //Set its properties
            TestItem.ActivityId = 1;
            TestItem.UserId = 1;
            TestItem.Action = "This is an action";
            TestItem.TimeStamp = DateTime.Now;
            TestItem.Detail = "This is an action in detail";

            //Addd items to the Test List
            TestList.Add(TestItem);

            //Assign the data to the property
            AllActivityLogs.ActivityLogList = TestList;

            //Test to see the two values are the same
            Assert.AreEqual(AllActivityLogs.ActivityLogList, TestList);

        }

        [TestMethod]
        public void ThisActivityLogPropertyOK()
        {
            //Create an instance of a staff class
            clsActivityLogCollection AllActivityLogs = new clsActivityLogCollection();

            List<clsActivityLog> TestList = new List<clsActivityLog>();

            //Add an Item to the list
            clsActivityLog TestItem = new clsActivityLog();

            //Set its properties
            TestItem.ActivityId = 1;
            TestItem.UserId = 1;
            TestItem.Action = "This is an action";
            TestItem.TimeStamp = DateTime.Now;
            TestItem.Detail = "This is an action in detail";

            //Assign the data to the property
            AllActivityLogs.ActivityLogList = TestList;

            //Test to see the two values are the same
            Assert.AreEqual(AllActivityLogs.ActivityLogList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of staff class
            clsActivityLogCollection AllActivityLogs = new clsActivityLogCollection();

            //Create some test data
            List<clsActivityLog> TestList = new List<clsActivityLog>();

            //Add Item to the list
            //Create the item of the test data
            clsActivityLog TestItem = new clsActivityLog();

            //Set its properties
            TestItem.ActivityId = 1;
            TestItem.UserId = 1;
            TestItem.Action = "This is an action";
            TestItem.TimeStamp = DateTime.Now;
            TestItem.Detail = "This is an action in detail";

            //Addd items to the Test List
            TestList.Add(TestItem);

            //Assign the data to the property
            AllActivityLogs.ActivityLogList = TestList;

            //Test to see the two values are the same
            Assert.AreEqual(AllActivityLogs.Count, TestList.Count);
        }       

        [TestMethod]

        public void ReportByActionMethodOK()
        {
            //create an instance of Staff Name Method
            clsActivityLogCollection AllActivityLogs = new clsActivityLogCollection();

            //create an instance of a filter Name data
            clsActivityLogCollection FilteredAction = new clsActivityLogCollection();

            //apply blank string (should return all the records);
            FilteredAction.ReportByAction("");

            //test to see that two value are equal
            Assert.AreEqual(AllActivityLogs.Count, FilteredAction.Count);
        }

        [TestMethod]
        public void ReportByActionNoneFound()
        {

            //Create instance of the class we want to create
            clsActivityLogCollection FilteredName = new clsActivityLogCollection();

            //Apply the name that doesn't exist
            FilteredName.ReportByAction("xxxxxx");

            //Test to see that there are no records
            Assert.AreEqual(0, FilteredName.Count);
        }

        [TestMethod]
        public void ReportByActionTestDataFound()
        {
            //Create an instance of a filtered data
            clsActivityLogCollection FilteredStaff = new clsActivityLogCollection();

            //variable to store the outcome
            Boolean OK = true;

            //apply the name that doesn't Exist
            FilteredStaff.ReportByAction("This is an action");

            //Check the data correct number of records are found
            if (FilteredStaff.Count == 1)
            {
                //Check to see the first record is 6
                if (FilteredStaff.ActivityLogList[0].ActivityId != 6)
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
