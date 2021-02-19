using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
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
    }
}
