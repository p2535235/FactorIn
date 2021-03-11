using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        public clsStaffCollection()
        {
            // Var to store the record count.
            Int32 RecordCount = 0;
            // Object for data connection.
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure.
            DB.Execute("sproc_tblStaff_SelectAll");
            // Get the count of records.
            RecordCount = DB.Count;

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

        // Private data type for the list.
        List<clsStaff> mStaffList = new List<clsStaff>();
        int count;

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
    }
}
