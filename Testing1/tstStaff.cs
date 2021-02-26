using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {

        // Good test data.
        string staffID = "2";
        string staffName = "John";
        string dateAccessed = DateTime.Today.Date.ToString();
        string totalCost = "4.3";
        string grantAccess = "False";
        string productID = "1235";

        [TestMethod]
        public void InstanceOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // Test to see that it exists.
            Assert.IsNotNull(Staff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // int to be assigned to the StaffID property.
            Int32 TestData = 1;
            // Assign data to the property.
            Staff.StaffID = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // String to be assigned to the StaffName property.
            string TestData = "John Smith";
            // Assign data to the property.
            Staff.StaffName = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.StaffName, TestData);
        }

        [TestMethod]
        public void DateAccessedPropertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // DateTime to be assigned to the DateAccessed property.
            DateTime TestData = DateTime.Now.Date;
            // Assign data to the property.
            Staff.DateAccessed = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.DateAccessed, TestData);
        }

        [TestMethod]
        public void TotalCostPorpertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // double to be assigned to the TotalCost property.
            Double TestData = 1.32;
            // Assign data to the property.
            Staff.TotalCost = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.TotalCost, TestData);
        }

        [TestMethod]
        public void GrantAccessPropertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // Boolean to be assigned to the GrantAccess property.
            Boolean TestData = true;
            // Assign data to the property.
            Staff.GrantAccess = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.GrantAccess, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // int to be assigned to the ProductID property.
            Int32 TestData = 0;
            // Assign data to the property.
            Staff.ProductID = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.ProductID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // Instance of the clsStaff Class.
            clsStaff Staff = new clsStaff();
            // Boolean to store the results of the validation.
            Boolean Found = false;
            // Test data to use with the method.
            Int32 StaffID = 1;
            // Invoke the method.
            Found = Staff.Find(StaffID);
            // Test to see if the result is true.
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            // Instance of the clsStaff Class.
            clsStaff Staff = new clsStaff();
            // Boolean to store the results of the validation.
            Boolean Found = false;
            // Boolean to test if the data is ok (assume that it is).
            Boolean OK = true;
            // Test data to use with the method.
            Int32 StaffID = 1;
            // Invoke the method.
            Found = Staff.Find(StaffID);
            // Check if the provided StaffID is present
            if (Staff.StaffID != StaffID)
            {
                OK = false;
            }
            // Test to see if the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            // Instance of the clsStaff Class.
            clsStaff Staff = new clsStaff();
            // Boolean to store the results of the validation.
            Boolean Found = false;
            // Boolean to test if the data is ok (assume that it is).
            Boolean OK = true;
            // Test data to use with the method.
            String StaffName = "Boop";
            // Invoke the method.
            Found = Staff.Find(StaffName);
            // Check if the provided StaffID is present
            if (!Staff.StaffName.Equals(StaffName))
            {
                OK = false;
            }
            // Test to see if the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAccessedFound()
        {
            // Instance of the clsStaff Class.
            clsStaff Staff = new clsStaff();
            // Boolean to store the results of the validation.
            Boolean Found = false;
            // Boolean to test if the data is ok (assume that it is).
            Boolean OK = true;
            // Test data to use with the method.
            DateTime DateAccessed = Convert.ToDateTime("01/01/2020");
            // Invoke the method.
            Found = Staff.Find(DateAccessed);
            // Check if the provided StaffID is present
            if (Staff.DateAccessed != DateAccessed)
            {
                OK = false;
            }
            // Test to see if the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalCostFound()
        {
            // Instance of the clsStaff Class.
            clsStaff Staff = new clsStaff();
            // Boolean to store the results of the validation.
            Boolean Found = false;
            // Boolean to test if the data is ok (assume that it is).
            Boolean OK = true;
            // Test data to use with the method.
            double TotalCost = 2.2;
            // Invoke the method.
            Found = Staff.Find(TotalCost);
            // Check if the provided StaffID is present
            if (Staff.TotalCost != TotalCost)
            {
                OK = false;
            }
            // Test to see if the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGrantAccessFound()
        {
            // Instance of the clsStaff Class.
            clsStaff Staff = new clsStaff();
            // Boolean to store the results of the validation.
            Boolean Found = false;
            // Boolean to test if the data is ok (assume that it is).
            Boolean OK = true;
            // Test data to use with the method.
            bool GrantAccess = true;
            // Invoke the method.
            Found = Staff.Find(GrantAccess);
            // Check if the provided StaffID is present
            if (Staff.GrantAccess != GrantAccess)
            {
                OK = false;
            }
            // Test to see if the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create.
            clsStaff staff = new clsStaff();
            // String method to store any error message.
            String Error = "";
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, productID);
        }


        [TestMethod]
        public void StaffIDExtremeMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinLessOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "0";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "1";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            if(staff.Find(1)) Assert.AreEqual(Error, "The Staff ID must be unique : ");
            else Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "2";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "2147483646";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "2147483647";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "2147483648";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "1073741823";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDExtremeMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "2232147483647";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDInvalidType()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "Twenty";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDIsUnique()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffID = "2";
            // Invoke Valid method.
            Error = staff.Valid(StaffID, staffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "O";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "Ol";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "Name goes here, akjhsdftgajkd";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "Name goes here, akjhsdftgajkda";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "Name goes here, akjhsdftgajkdas";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "Name goes here,";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaawhyaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaareaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaayouaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaareadingaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaathis?aaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameInvalidVals()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string StaffName = "Oh look, an invalid value: \"";
            // Invoke Valid method.
            Error = staff.Valid(staffID, StaffName, dateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessedExtremeMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = DateTime.Today.AddYears(-100).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessedMinMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = DateTime.Today.AddDays(-4).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessedMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = DateTime.Today.AddDays(-3).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessedMinPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = DateTime.Today.AddDays(-2).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessedMaxMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = DateTime.Today.AddDays(-1).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessedMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = DateTime.Today.Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessedMaxPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = DateTime.Today.AddDays(1).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessedExtremeMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = DateTime.Today.AddYears(100).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAccessed()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateAccessed = "Today";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateAccessed, totalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostExtremeMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "-1000.1234";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMinMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "-1";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "0";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMinPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "1";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMaxMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "999999999999999.99";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "1000000000000000.99";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMaxPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "1000000000000001.99";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMid()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "50000000";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostExtremeMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "99999999999999999.34657456";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostInvalidVal()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string TotalCost = "Seventy Five Dollars";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, TotalCost, grantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GrantAccessIsTrue()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string GrantAccess = "True";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, GrantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GrantAccessIsFalse()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string GrantAccess = "False";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, GrantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GrantAccessInvalidVal()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string GrantAccess = "This is true";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, GrantAccess, productID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "-50";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "0";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "1";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "2";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "2147483646";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "2147483647";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "2147483648";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMid()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "1073741823";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "2122147483648";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDInvalidVal()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "One hundred and five";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDIsInStockTable()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string ProductID = "1236";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateAccessed, totalCost, grantAccess, ProductID);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }
    }
}
