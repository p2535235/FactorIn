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
            //creates an instance of Stock class
            clsStock aStock = new clsStock();

            //test to see Stock class exists 
            Assert.IsNotNull(aStock);

        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //creates an instance of the Stock class
            clsStock AStock = new clsStock();

            //creates an Int test data to assign to the ProductID property
            Int32 TestData = 1;

            //assigns the data to the ProductID property
            AStock.ProductID = TestData;

            //tests to see that the two values are the same
            Assert.AreEqual(AStock.ProductID, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //creates an instance of the Stock class
            clsStock AStock = new clsStock();

            //creates an Int test data to assign to the Quantity property
            Int32 TestData = 1;

            //assigns the data to the Quantity property
            AStock.Quantity = TestData;

            //tests to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void LocationPropertyOK()
        {
            //creates an instance of the Stock class
            clsStock AStock = new clsStock();

            //creates a string test data to assign to the Location property
            string TestData = "Random Location 123";

            //assigns the data to the Location property
            AStock.Location = TestData;

            //tests to see that the two values are the same
            Assert.AreEqual(AStock.Location, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //creates an instance of the Stock class
            clsStock AStock = new clsStock();

            //creates a Double test data to assign to the Price property.
            Double TestData = 1.32;

            //assigns the data to the Price property
            AStock.Price = TestData;

            //tests to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            //creates an instance of the Stock class
            clsStock AStock = new clsStock();

            //creates a Boolean test data to assign to the Availability property
            Boolean TestData = true;

            //assigns the data to the Availability property 
            AStock.Availability = TestData;

            //tests to see that the two values are the same 
            Assert.AreEqual(AStock.Availability, TestData);
        }

        [TestMethod]
        public void DateUpdatedPropertyOK()
        {
            //creates an instance of the Stock class
            clsStock AStock = new clsStock();

            //creates a DateTime test data to assign to the DateUpdated property 
            DateTime TestData = DateTime.Now.Date;

            //assigns the data to the DateUpdated property 
            AStock.DateUpdated = TestData;

            //tests to see that the two values are the same 
            Assert.AreEqual(AStock.DateUpdated, TestData);
        }

        

    }
}
