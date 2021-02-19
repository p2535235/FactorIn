using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Private data member for the respective properties.
        private int staffID;
        private string staffName;
        private DateTime dateAccessed;
        private double totalCost;
        private int productID;
        private bool grantAccess;

        // StaffID public property.
        public int StaffID
        {
            get
            {
                // Returns the staffID variable.
                return staffID;
            }
            set
            {
                // Assigns the value to the staffID variable.
                staffID = value;
            }
        }
        public int ProductID
        {
            get
            {
                // Returns the staffID variable.
                return productID;
            }
            set
            {
                // Assigns the value to the staffID variable.
                productID = value;
            }
        }
        public string StaffName
        {
            get
            {
                // Returns the staffID variable.
                return staffName;
            }
            set
            {
                // Assigns the value to the staffID variable.
                staffName = value;
            }
        }
        public DateTime DateAccessed
        {
            get
            {
                // Returns the staffID variable.
                return dateAccessed;
            }
            set
            {
                // Assigns the value to the staffID variable.
                dateAccessed = value;
            }
        }
        public double TotalCost
        {
            get
            {
                // Returns the staffID variable.
                return totalCost;
            }
            set
            {
                // Assigns the value to the staffID variable.
                totalCost = value;
            }
        }
        public bool GrantAccess
        {
            get
            {
                // Returns the staffID variable.
                return grantAccess;
            }
            set
            {
                // Assigns the value to the staffID variable.
                grantAccess = value;
            }
        }

        // Method to find staff with the corresponding ID.
        public bool Find(int StaffID)
        {
            // Establish database connection.
            clsDataConnection DB = new clsDataConnection();

            // Set up and execute the filter by staff id procedure.
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");

            // If there is one
            if (DB.Count == 1)
            {
                // Assign the field variables the corresponding columns.
                staffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                staffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                dateAccessed = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAccessed"]);
                totalCost = Convert.ToDouble(DB.DataTable.Rows[0]["TotalCost"]);
                grantAccess = Convert.ToBoolean(DB.DataTable.Rows[0]["GrantAccess"]);

                if (DB.DataTable.Rows[0]["ProductID"] == DBNull.Value) productID = 0;
                else productID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);

                // Return true.
                return true;
            }
            else
            {
                // Else return false.
                return false;
            }
        }

        public bool Find(string StaffName)
        {
            staffName = "Boop";
            return true;
        }

        public bool Find(DateTime DateAccessed)
        {
            dateAccessed = Convert.ToDateTime("01/01/2020");
            return true;
        }

        public bool Find(double TotalCost)
        {
            totalCost = 2.2;
            return true;
        }

        public bool Find(bool GrantAccess)
        {
            grantAccess = true;
            return true;
        }

        // This cannot be implemented.
        /*public bool Find(int ProductID)
        {
            staffID = 34;
            return true;
        }*/
    }
}
