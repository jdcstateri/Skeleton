using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
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
        public void UserIDPropertyOK()
        {
            clsActivityLog AnActivityLog = new clsActivityLog();
            int TestData = 1;
            AnActivityLog.UserID = TestData;
            Assert.AreEqual(AnActivityLog.UserID, TestData);
        }

        [TestMethod]
        public void ActionPropertyOK()
        {

            clsActivityLog AnActivityLog = new clsActivityLog();
            String TestData = "Test Action";
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
            String TestData = "Action In Detail";
            AnActivityLog.Detail = TestData;
            Assert.AreEqual(AnActivityLog.Detail, TestData);
        }


    }
}
