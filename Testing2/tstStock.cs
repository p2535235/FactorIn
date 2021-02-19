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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of Stock class
            clsStock AStock = new clsStock();

            //Boolean variable to store the results of the validation
            Boolean Found = false;

            //creates a test data to use with the method
            Int32 ProductID = 1235;

            //invokes the method
            Found = AStock.Find(ProductID);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        
        [TestMethod]
        public void TestProductIDFound()
        {
            //creates an instance of the Stock class 
            clsStock AStock = new clsStock();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if the data is OK 
            Boolean OK = true;

            //creates a test data to use with the method 
            Int32 ProductID = 1235;

            //invoke the method
            Found = AStock.Find(ProductID);

            //checks the product id
            if (AStock.ProductID != 1235)
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //creates an instance of the Stock class 
            clsStock AStock = new clsStock();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if the data is OK 
            Boolean OK = true;

            //creates a test data to use with the method 
            Int32 ProductID = 1235;

            //invoke the method
            Found = AStock.Find(ProductID);

            //checks the quantity 
            if (AStock.Quantity != 4)
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLocationFound()
        {
            //creates an instance of the Stock class 
            clsStock AStock = new clsStock();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if the data is OK 
            Boolean OK = true;

            //creates a test data to use with the method 
            Int32 ProductID = 1235;

            //invoke the method
            Found = AStock.Find(ProductID);

            //checks the location
            if (AStock.Location != "Fact1")
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //creates an instance of the Stock class 
            clsStock AStock = new clsStock();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if the data is OK 
            Boolean OK = true;

            //creates a test data to use with the method 
            Int32 ProductID = 1235;

            //invoke the method
            Found = AStock.Find(ProductID);

            //checks the price 
            if (AStock.Price != 30)
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            //creates an instance of the Stock class 
            clsStock AStock = new clsStock();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if the data is OK 
            Boolean OK = true;

            //creates a test data to use with the method 
            Int32 ProductID = 1235;

            //invoke the method
            Found = AStock.Find(ProductID);

            //checks the availability 
            if (AStock.Availability != true)
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateUpdatedFound()
        {
            //creates an instance of the Stock class 
            clsStock AStock = new clsStock();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if the data is OK 
            Boolean OK = true;

            //creates a test data to use with the method 
            Int32 ProductID = 1235;

            //invoke the method
            Found = AStock.Find(ProductID);

            //checks the date updated
            if (AStock.DateUpdated != Convert.ToDateTime("02/02/2021"))
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

    }
}
