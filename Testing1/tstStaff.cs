using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class UnitTest1
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
        public void ActivePropertyOK()
        {
            // Instance of the Staff class.
            clsStaff Staff = new clsStaff();
            // Boolean to be assigned to the Active property.
            Boolean TestData = true;
            // Assign data to the property.
            Staff.Active = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.Active, TestData);
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
            Int32 TestData = 1;
            // Assign data to the property.
            Staff.ProductID = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(Staff.ProductID, TestData);
        }
    }
}
