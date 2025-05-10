using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstActivityLog
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create a instance of the class we want to create
            clsActivityLog AnActivityLog = new clsActivityLog();

            //Test to see that is Exist
            Assert.IsNotNull(AnActivityLog);
        }
        [TestMethod]
        public void ActivityIDPropertyOK()
        {
            clsActivityLog AnActivitiesLog = new clsActivityLog();
            int TestData = 1;
            AnActivitiesLog.ActivityId = TestData;
            Assert.AreEqual(AnActivitiesLog.ActivityId, TestData);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsActivityLog AnActivityLog = new clsActivityLog();
            int TestData = 1;
            AnActivityLog.UserId = TestData;
            Assert.AreEqual(AnActivityLog.UserId, TestData);
        }

        [TestMethod]
        public void ActionPropertyOK()
        {

            clsActivityLog AnActivityLog = new clsActivityLog();
            String TestData = "This is an Action";
            AnActivityLog.Action = TestData;
            Assert.AreEqual(AnActivityLog.Action, TestData);
        }

        [TestMethod]
        public void TimeStampPropertyOK()
        {

            clsActivityLog AnActivityLog = new clsActivityLog();
            DateTime TestData = DateTime.Now;
            AnActivityLog.TimeStamp = TestData;
            Assert.AreEqual(AnActivityLog.TimeStamp, TestData);
        }

        public void DetailsPropertyOK()
        {

            clsActivityLog AnActivityLog = new clsActivityLog();
            String TestData = "This is an action in detail";
            AnActivityLog.Detail = TestData;
            Assert.AreEqual(AnActivityLog.Detail, TestData);
        }



        [TestMethod]
        public void TestActivityIdFound()
        {
            //create an instance of the class we want to create
            clsActivityLog AnActivityLog = new clsActivityLog();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 ActivityId = 21;

            //invoke the method
            Found = AnActivityLog.Find(ActivityId);

            //Check the Staff Id
            if (AnActivityLog.ActivityId != 21)
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLogUserIDFound()
        {
            //create an instance of the class we want to create
            clsActivityLog AnActivityLog = new clsActivityLog();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 ActivityId = 21;

            //invoke the method
            Found = AnActivityLog.Find(ActivityId);

            //Check the Staff Id
            if (AnActivityLog.UserId != 21)
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLogActionFound()
        {
            //create an instance of the class we want to create
            clsActivityLog AnActivityLog = new clsActivityLog();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 ActivityId = 21;

            //invoke the method
            Found = AnActivityLog.Find(ActivityId);

            //Check the Staff Id
            if (AnActivityLog.Action != "This is an Action")
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLogDetail()
        {
            //create an instance of the class we want to create
            clsActivityLog AnActivityLog = new clsActivityLog();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 ActivityId = 21;

            //invoke the method
            Found = AnActivityLog.Find(ActivityId);

            //Check the Staff Id
            if (AnActivityLog.Detail != "This is an action in detail")
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLogDateAdded()
        {
            //create an instance of the class we want to create
            clsActivityLog AnActivityLog = new clsActivityLog();

            //Create a Boolean variable to store the results of the search
            Boolean Found = false;

            //Create a Boolean variable to record of the data is OK
            Boolean OK = true;

            //Create Some test data to use with the method
            Int32 ActivityId = 21;

            //invoke the method
            Found = AnActivityLog.Find(ActivityId);

            //Check the Staff Id
            if (AnActivityLog.TimeStamp != Convert.ToDateTime("25/12/2025"))
            {
                OK = false;
            }

            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
