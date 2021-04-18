using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //creates some test data to pass the method
        string ProductID = "1239";
        string Quantity = "13";
        string Location = "Factory 1";
        string Price = "7";
        string DateUpdated = DateTime.Now.Date.ToString();
         
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
            int ProductID = 1235;

            //invoke the method
            Found = AStock.Find(ProductID);

            //checks the price 
            if (AStock.Price != 30.0)
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //creates an instance of Stock class
            clsStock AStock = new clsStock();

            //string variable to store any error message 
            String Error = "";

            //invoke the method 
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //creates an instance of Stock class 
            clsStock AStock = new clsStock();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method 
            string Quantity = "-1";

            //invoke the method 
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "0"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "1"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "1999"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "2000"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "1000"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "2001";
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "4000";

            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationMinLessOne()
        {
            //creates an instance of Stock class 
            clsStock AStock = new clsStock();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method 
            string Location = "";

            //invoke the method 
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LocationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LocationMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LocationMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LocationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "";
            Location = Location.PadRight(500, 'a');

            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PriceMinLessOne()
        {
            //creates an instance of Stock class 
            clsStock AStock = new clsStock();

            //string variable to store any error message 
            String Error = "";

            //create some test data to pass to the method 
            string Price = "-1";

            //invoke the method 
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "0"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "1"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "4999"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "5000"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "2500"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "5001";
            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "10000";

            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateUpdatedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();


            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateUpdatedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateUpdatedMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();


            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateUpdatedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(1);

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateUpdatedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateUpdatedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";

            string DateUpdated = "this is not a date!";

            //invoke the method
            Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
}
