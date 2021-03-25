using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // Private data type for the list.
        List<clsStaff> mStaffList = new List<clsStaff>();
        // Private data type.
        clsStaff mStaff = new clsStaff();

        int count;

        public clsStaffCollection()
        {
            // Var to store the record count.
            Int32 RecordCount = 0;
            // Object for data connection.
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure.
            DB.Execute("sproc_tblStaff_SelectAll");
            // Populate the array list with the data table.
            populateArray(DB);

            // For loop to iterate to each record in the database.
            for(Int32 i = 0; i < RecordCount; i++)
            {
                // Create a staff Object.
                clsStaff staff = new clsStaff();
                // Read in the fields from the current record.
                staff.StaffID = Convert.ToInt32(DB.DataTable.Rows[i]["StaffID"]);
                staff.StaffName = Convert.ToString(DB.DataTable.Rows[i]["StaffName"]);
                staff.Wage = Convert.ToInt32(DB.DataTable.Rows[i]["Wage"]);
                staff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[i]["DOB"]);
                staff.Email = Convert.ToString(DB.DataTable.Rows[i]["Email"]);
                staff.GrantAccess = Convert.ToBoolean(DB.DataTable.Rows[i]["GrantAccess"]);
                // Add the record to the staff list.
                mStaffList.Add(staff);
            }
        }

        // Public property for the staff list.
        public List<clsStaff> StaffList
        {
            get
            {
                // Return the private data.
                return mStaffList;
            }

            set
            {
                // Set the private data.
                mStaffList = value;
            }
        }

        // Public property for count.
        public int Count
        {
            get
            {
                // Return the count of the list.
                return mStaffList.Count;
            }

            set
            {

            }
        }

        public clsStaff CurrentStaff
        {
            get
            {
                // Return current staff.
                return mStaff;
            }

            set
            {
                // Set the current staff.
                mStaff = value;
            }
        }

        public int Add()
        {
            // Adds a new record to the database based on the values of mStaff.
            // Conect to the database.
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure.
            DB.AddParameter("@StaffName", mStaff.StaffName);
            DB.AddParameter("@DOB", mStaff.DateOfBirth);
            DB.AddParameter("@Wage", mStaff.Wage);
            DB.AddParameter("@Email", mStaff.Email);
            DB.AddParameter("@GrantAccess", mStaff.GrantAccess);
            // Execute the query return the primary key value.
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            // Update an existing record based on the values of the currentStaff.
            // Connect to the database.
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure.
            DB.AddParameter("@StaffID", mStaff.StaffID);
            DB.AddParameter("@StaffName", mStaff.StaffName);
            DB.AddParameter("@DOB", mStaff.DateOfBirth);
            DB.AddParameter("@Wage", mStaff.Wage);
            DB.AddParameter("@Email", mStaff.Email);
            DB.AddParameter("@GrantAccess", mStaff.GrantAccess);
            // Execute the query return the primary key value.
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            // Deletes the record pointed to by the currentStaff.
            // Connect to the database.
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure.
            DB.AddParameter("@StaffID", CurrentStaff.StaffID);
            // Execute the stored procedure.
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffName(string StaffName)
        {
            // Filters the records based on a full or partial staff name.
            // Connect to the database.
            clsDataConnection DB = new clsDataConnection();
            // Send the Staff name parameter to the database.
            DB.AddParameter("@StaffName", StaffName);
            // Execute the procedure.
            DB.Execute("sproc_tblStaff_FilterByStaffName");
            // Populate the array list with the data table.
            populateArray(DB);
        }

        void populateArray(clsDataConnection DB)
        {
            // Populates the array list based on the data table in the parameter DB.
            // Var to store the record count.
            Int32 RecordCount = DB.Count;
            // Clear the array list.
            mStaffList = new List<clsStaff>();
            // Iterate through the records.
            for(Int32 i = 0; i < RecordCount; i++)
            {
                // Create a blank address.
                clsStaff Staff = new clsStaff();
                // Set the fields from the current records.
                Staff.StaffID = Convert.ToInt32(DB.DataTable.Rows[i]["StaffID"]);
                Staff.StaffName = Convert.ToString(DB.DataTable.Rows[i]["StaffName"]);
                Staff.Wage = Convert.ToInt32(DB.DataTable.Rows[i]["Wage"]);
                Staff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[i]["DOB"]);
                Staff.Email = Convert.ToString(DB.DataTable.Rows[i]["Email"]);
                Staff.GrantAccess = Convert.ToBoolean(DB.DataTable.Rows[i]["GrantAccess"]);
                // Add the record to the list.
                mStaffList.Add(Staff);
            }
        }
    }
}
