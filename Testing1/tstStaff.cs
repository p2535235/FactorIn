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
        string dateOfBirth = DateTime.Today.AddYears(-22).Date.ToString();
        string wage = "4.3";
        string grantAccess = "False";
        string email = "email@example.com";

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
        public void DateOfBirthPropertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // DateTime to be assigned to the DateOfBirth property.
            DateTime TestData = DateTime.Now.Date;
            // Assign data to the property.
            Staff.DateOfBirth = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.DateOfBirth, TestData);
        }

        [TestMethod]
        public void WagePorpertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // double to be assigned to the Wage property.
            Double TestData = 1.32;
            // Assign data to the property.
            Staff.Wage = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.Wage, TestData);
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
        public void EmailPropertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // int to be assigned to the ProductID property.
            string TestData = "example@email.com";
            // Assign data to the property.
            Staff.Email = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.Email, TestData);
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
            // Check if the provided staff name is present
            if (!Staff.StaffName.Equals(StaffName))
            {
                OK = false;
            }
            // Test to see if the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            // Instance of the clsStaff Class.
            clsStaff Staff = new clsStaff();
            // Boolean to store the results of the validation.
            Boolean Found = false;
            // Boolean to test if the data is ok (assume that it is).
            Boolean OK = true;
            // Test data to use with the method.
            DateTime DateOfBirth = Convert.ToDateTime("01/01/2020");
            // Invoke the method.
            Found = Staff.Find(DateOfBirth);
            // Check if the provided date of birth is present
            if (Staff.DateOfBirth != DateOfBirth)
            {
                OK = false;
            }
            // Test to see if the result is correct.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestWageFound()
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
            if (Staff.Wage != TotalCost)
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
            // Check if the provided boolean is present
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
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(StaffID, staffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
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
            Error = staff.Valid(staffID, StaffName, dateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = DateTime.Today.AddYears(1000).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = DateTime.Today.AddYears(-12).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = DateTime.Today.AddYears(-13).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = DateTime.Today.AddYears(-14).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = DateTime.Today.AddYears(-149).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = DateTime.Today.AddYears(-150).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = DateTime.Today.AddYears(-151).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = DateTime.Today.AddYears(-1000).Date.ToString();
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirth()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string DateOfBirth = "Today";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, DateOfBirth, wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WageExtremeMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "-1000.1234";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WageMinMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "3.15";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WageMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "4.15";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WageMinPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "5.15";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WageMaxMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "99999999999";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WageMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "100000000000";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WageMaxPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "100000000001";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WageMid()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "5000000";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void WageExtremeMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "99999999999999999.34657456";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void WageInvalidVal()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Wage = "Seventy Five Dollars";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, Wage, grantAccess, email);
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
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, GrantAccess, email);
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
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, GrantAccess, email);
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
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, GrantAccess, email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "e@f.";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "e@f.uk";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "e@f.com";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxMinusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "example.fmglfdsasde@email.com";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "example.fmglfdsasade@email.com";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "example.fmgsddfdsasde@email.com";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "examp@email.com";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHH@AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHH.ugh";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailInvalidVal()
        {
            // Create an instance of the Staff class.
            clsStaff staff = new clsStaff();
            // String to store any error messages.
            String Error = "";
            // Test data to pass through the method.
            string Email = "email";
            // Invoke Valid method.
            Error = staff.Valid(staffID, staffName, dateOfBirth, wage, grantAccess, Email);
            // Test to see if the results are correct.
            Assert.AreNotEqual(Error, "");
        }
    }
}
