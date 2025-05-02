using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstproduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AnProduct = new clsProduct();

            Assert.IsNotNull(AnProduct);
        }
    }
}
