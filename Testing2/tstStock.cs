using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class we want to create 
            clsStock aStock = new clsStock();

            //test to see that exists 
            Assert.IsNotNull(aStock);

        }
    }
}
