using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create a instance of the class we want to create
            clsStaff AStaff = new clsStaff();

            //Test to see that is Exist
            Assert.IsNotNull(AStaff);
        }
    }
}
