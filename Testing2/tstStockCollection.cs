using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //test5 to see it exists 
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the Stock Collection class 
            clsStockCollection AllStock = new clsStockCollection();

            //creating some test data to assign to the property in the form of list
            List<clsStock> TestList = new List<clsStock>();

            //adds an item to the list 
            //create item of test data 
            clsStock TestItem = new clsStock();

            //setting its properties 
            TestItem.Availability = true;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.Location = "Fact1";
            TestItem.Price = 30.1;
            TestItem.DateUpdated = DateTime.Now.Date;

            //adding the item to the list
            TestList.Add(TestItem);

            //assigning the data to the property 
            AllStock.StockList = TestList;

            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.StockList, TestList);

        }
        

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the Stock Collection class 
            clsStockCollection AllStock = new clsStockCollection();

            //creates test data to assign to the property 
            clsStock TestStock = new clsStock();

            //set the properties of the test object 
            TestStock.Availability = true;
            TestStock.ProductID = 1;
            TestStock.Quantity = 1;
            TestStock.Location = "Fact1";
            TestStock.Price = 30.1;
            TestStock.DateUpdated = DateTime.Now.Date;

            //assign the data to the property 
            AllStock.ThisStock = TestStock;

            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the Stock Collection class 
            clsStockCollection AllStock = new clsStockCollection();

            //creating some test data to assign to the property in the form of list
            List<clsStock> TestList = new List<clsStock>();

            //adds an item to the list 
            //create item of test data 
            clsStock TestItem = new clsStock();

            //setting its properties 
            TestItem.Availability = true;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.Location = "Fact1";
            TestItem.Price = 30.1;
            TestItem.DateUpdated = DateTime.Now.Date;

            //adding the item to the list
            TestList.Add(TestItem);

            //assigning the data to the property 
            AllStock.StockList = TestList;

            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.StockList.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the Stock Collection class 
            clsStockCollection AllStock = new clsStockCollection();

            //create item of test data 
            clsStock TestItem = new clsStock();

            //var to store the primary key 
            Int32 PrimaryKey = 0;

            //setting its properties 
            TestItem.Availability = true;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.Location = "Fact1";
            TestItem.Price = 30.1;
            TestItem.DateUpdated = DateTime.Now.Date;

            //setting ThsStock to the test data
            AllStock.ThisStock = TestItem;

            //add the record 
            PrimaryKey = AllStock.Add();

            //setting the primary ket of the test data
            TestItem.ProductID = PrimaryKey;
            // find the record 
            AllStock.ThisStock.Find(PrimaryKey);

            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }


        [TestMethod]
        public void UpdateMethodOK()
        {

            //create an instance of the Stock Collection class 
            clsStockCollection AllStock = new clsStockCollection();

            //create item of test data 
            clsStock TestItem = new clsStock();

            //var to store the primary key 
            Int32 PrimaryKey = 0;

            //setting its properties 
            TestItem.Availability = true;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.Location = "Fact1";
            TestItem.Price = 30.1;
            TestItem.DateUpdated = DateTime.Now.Date;

            //setting ThsStock to the test data
            AllStock.ThisStock = TestItem;

            //add the record 
            PrimaryKey = AllStock.Add();

            //setting the primary ket of the test data
            TestItem.ProductID = PrimaryKey;

            //modify the test data 
            TestItem.Availability = false;
            TestItem.ProductID = 4;
            TestItem.Quantity = 7;
            TestItem.Location = "Fact4";
            TestItem.Price = 40.1;
            TestItem.DateUpdated = DateTime.Now.Date;

            //setting ThsStock based on new test data
            AllStock.ThisStock = TestItem;

            //update the record 
            AllStock.Update();
            //find the record 
            AllStock.ThisStock.Find(PrimaryKey);

            //Test to see ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the Stock Collection class 
            clsStockCollection AllStock = new clsStockCollection();

            //create item of test data 
            clsStock TestItem = new clsStock();

            //var to store the primary key 
            Int32 PrimaryKey = 0;

            //setting its properties 
            TestItem.Availability = true;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.Location = "Fact1";
            TestItem.Price = 30.1;
            TestItem.DateUpdated = DateTime.Now.Date;

            //setting ThsStock to the test data
            AllStock.ThisStock = TestItem;

            //add the record 
            PrimaryKey = AllStock.Add();

            //setting the primary ket of the test data
            TestItem.ProductID = PrimaryKey;

            //find the record 
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record 
            AllStock.Delete();

            //find the record 
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was found 
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByQuantityOK()
        {
            //create an instance of the Stock Collection class containing unfilterd results 
            //clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the Stock Collection class containing filterd results 
            clsStockCollection FilteredStock = new clsStockCollection();

            //apply a blank string
            FilteredStock.ReportByQuantity(0);

            //test to see that the two values are the same
            //Test to see no fields show up 
            Assert.AreEqual(0, FilteredStock.Count);

        }

        //As the filter is for an Int, the ReportByQuantityNoneFound is not applicable

        /*[TestMethod]
        public void ReportByQuantityNoneFound()
        {
            //create an instance of the filtered data 
            clsStockCollection FilteredStock = new clsStockCollection();

            //apply a Quantity that doesnt exist
            FilteredStock.ReportByQuantity(300);

            //test to see that there are no records 
            Assert.AreEqual(0, FilteredStock.Count);
        }*/


        [TestMethod]
        public void ReportByQuantityTestDataFound()
        {
            //create an instance of the filtered data 
            clsStockCollection FilteredStock = new clsStockCollection();

            //var to store the outcome
            Boolean OK = true;

            //apply a Quantity tht doesnt exist 
            FilteredStock.ReportByQuantity(4);

            //check that the correct number of records are found 
            if(FilteredStock.Count == 2)
            {
                // check that the first record ID 1234
                if (FilteredStock.StockList[0].ProductID != 1234)
                {
                    OK = false;
                }
                //check that the first record ID 1235
                if (FilteredStock.StockList[1].ProductID != 1235)
                {
                    OK = false;
                }
            }

            else
            {
                    OK = false;
            }

            //test to see th there are no records 
            Assert.IsTrue(OK);
                
            
        }

    }
}

