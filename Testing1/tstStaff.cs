using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void instanceOK()
        {
            // Create an instance of the class we want to create.
            clsStaff staff = new clsStaff();
            // Test to see that it exists.
            Assert.IsNotNull(staff);
        }
    }
}
