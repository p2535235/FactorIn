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

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the class.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create the test data.
            clsStaff TestItem = new clsStaff();
            // Var to store the primary key.
            Int32 PrimaryKey = 0;
            // Set its properties.
            TestItem.StaffName = "Bob";
            TestItem.Wage = 72.4;
            TestItem.GrantAccess = true;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-60);
            TestItem.Email = "bob@gmail.com";
            // Set the current staff to the test object.
            AllStaff.CurrentStaff = TestItem;
            // Add the record.
            PrimaryKey = AllStaff.Add();
            // Set the primary key of the test data.
            TestItem.StaffID = PrimaryKey;
            // Find the record.
            AllStaff.CurrentStaff.Find(PrimaryKey);
            // Test to see the two values are the same.
            Assert.AreEqual(AllStaff.CurrentStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create the test data.
            clsStaff TestItem = new clsStaff();
            // Var to store the primary key.
            Int32 PrimaryKey = 0;
            // Set its properties.
            TestItem.StaffName = "Bob";
            TestItem.Wage = 72.4;
            TestItem.GrantAccess = true;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-60);
            TestItem.Email = "bob@gmail.com";
            // Set the current staff to the test object.
            AllStaff.CurrentStaff = TestItem;
            // Add the record.
            PrimaryKey = AllStaff.Add();
            // Set the primary key of the test data.
            TestItem.StaffID = PrimaryKey;
            // modify the test data.
            TestItem.StaffName = "Bobby";
            TestItem.Wage = 72.4;
            TestItem.GrantAccess = true;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-60);
            TestItem.Email = "bobby@gmail.com";
            // Set the record based on the new test data.
            AllStaff.CurrentStaff = TestItem;
            // Update the record.
            AllStaff.Update();
            // Find the record.
            AllStaff.CurrentStaff.Find(PrimaryKey);
            // Test to see if the currentStaff matches the TestItem.
            Assert.AreEqual(AllStaff.CurrentStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create the test data.
            clsStaff TestItem = new clsStaff();
            // Var to store the primary key.
            Int32 PrimaryKey = 0;
            // Set its properties.
            TestItem.StaffName = "Bob";
            TestItem.Wage = 72.4;
            TestItem.GrantAccess = true;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-60);
            TestItem.Email = "bob@gmail.com";
            // Set the current staff to the test object.
            AllStaff.CurrentStaff = TestItem;
            // Add the record.
            PrimaryKey = AllStaff.Add();
            // Set the primary key of the test data.
            TestItem.StaffID = PrimaryKey;
            // Find the record.
            AllStaff.CurrentStaff.Find(PrimaryKey);
            // Delete the record.
            AllStaff.Delete();
            // Find the record.
            Boolean Found = AllStaff.CurrentStaff.Find(PrimaryKey);
            // Test to see that the record was not found.
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStaffNameFound()
        {
            // Create an instance of the filtered data.
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // Var to store the outcome.
            Boolean OK = true;
            // Apply a Staff Name that doesn't exist.
            FilteredStaff.ReportByStaffName("Foo Bar");
            // Check that the correct number of records are found.
            if (FilteredStaff.Count == 2)
            {
                // Check if the Staff ID's of the records are 2 and 3 respectively.
                if (FilteredStaff.StaffList[0].StaffID != 1) OK = false;
                if (FilteredStaff.StaffList[1].StaffID != 2) OK = false;
            }
            else OK = false;
            // Test to see that there are no records.
            Assert.IsTrue(OK);
        }
    }
}
