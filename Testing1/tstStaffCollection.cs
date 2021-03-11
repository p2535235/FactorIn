using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstStaffCollection
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instances of the class we want to create.
            clsStaffCollection AllStaffMembers = new clsStaffCollection();
            // Test to see that it exists.
            Assert.IsNotNull(AllStaffMembers);
        }

        [TestMethod]
        public void StaffListOK()
        {
            // Create an instance of the class we want to create.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create some test data to assign to the property.
            // In this case the data needs to be a list of objects.
            List<clsStaff> TestList = new List<clsStaff>();
            // Add an item to the list.
            // Create the item of test data.
            clsStaff TestItem = new clsStaff();
            // Set its properties.
            TestItem.StaffID = 2;
            TestItem.StaffName = "Bob";
            TestItem.Wage = 72.4;
            TestItem.GrantAccess = true;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-60);
            TestItem.Email = "bob@gmail.com";
            // Add the item to the test list.
            TestList.Add(TestItem);
            // Assign the data to the property.
            AllStaff.StaffList = TestList;
            // Test to see that the two values are the same.
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the class.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create some test data to assign to the property.
            List<clsStaff> TestList = new List<clsStaff>();
            // Create the test data.
            clsStaff TestItem = new clsStaff();
            // Set its properties.
            TestItem.StaffID = 2;
            TestItem.StaffName = "Bob";
            TestItem.Wage = 72.4;
            TestItem.GrantAccess = true;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-60);
            TestItem.Email = "bob@gmail.com";
            // Add the item to the test list.
            TestList.Add(TestItem);
            // Assign the data to the property.
            AllStaff.StaffList = TestList;
            // Test to see that the two values are the same.
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }
}
