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

        public String Valid(string staffID, string staffName, string dateAccessed, string totalCost, string grantAccess, string productID)
        {
            // Create a string variable to store the error(s).
            String Error = "";

            // If the staffID is blank.
            if (staffID.Length == 0) Error += "The Staff ID must not be blank : ";

            // Try to convert the Staff ID to a 32 bit Integer.
            try
            {
                // Integer variable to store StaffID as a number.
                int ID = Int32.Parse(staffID);

                // If the Staff ID is less than 1.
                if (ID <= 0) Error = Error + "The Staff ID must be greater than 0 : ";
                // If the Staff ID is already in use.
                if (Find(ID)) Error = Error + "The Staff ID must be unique : ";
            } catch (OverflowException)
            {
                Error += "The staff ID is too small/large : ";
            } catch 
            {
                Error += "The Staff ID must be a number : ";
            }
            
            // If Staff name is within bounds and does not contain any invalid values.
            if (staffName.Length == 0) Error += "The Staff name must contain at least one character : ";
            if (staffName.Length > 30) Error += "The Staff name must not exceed 30 characters : ";
            if (HasInvalidChars(staffName)) Error += "The staff name must not contain: \"\\, \", \'\" : ";

            try
            {
                // DateTime variable to store the date accessed.
                DateTime date = DateTime.Parse(dateAccessed);

                // If the Date is within bounds.
                if (date.Date.CompareTo(DateTime.Today.AddDays(-3).Date) < 0) Error += "The date accessed must be recorded within a 72 hours of accessing the factory : ";
                if (date.Date.CompareTo(DateTime.Today.Date) > 0) Error += "The date accessed must not exceed todays date. : ";
            } catch
            {
                Error += "The date must be in the format of: \"DD/MM/YYYY\" : ";
            }

            try
            {
                // Double variable to store the cost.
                Double cost = Double.Parse(totalCost);

                // If the variable is within bounds.
                if (cost > 1000000000000000.99) Error += "Cost must not exceed 1000000000000000.99 : ";
                if (cost < 0) Error += "Cost must no lower than 0 : ";
            } catch
            {
                Error += "invalid value, must be a decimal number of atleast 0 and no greater than 1000000000000000.99 : ";
            }

            try
            {
                // Bool for determining if access is granted.
                bool access = Boolean.Parse(grantAccess);
            } catch
            {
                Error += "Value must be either True, False, 1, or 0 : ";
            }

            try
            {
                // Int for storing the Product ID.
                int ID = Int32.Parse(productID);

                // clsStock for finding the relevant product in stock.
                clsStock stock = new clsStock();

                // If the Product ID is negative or zero or is not in the stock table
                if (ID < 1) Error += "Product ID must be greater than 0 : ";
                // This cannot be implemented until clsStock's Find method is fully operational.
                //if (!stock.Find(ID)) Error += "The product ID must exist.";

            } catch
            {
                Error += "Product ID must be a valid integer : ";
            }

            // Return any error messages.
            return Error;
        }

        // Private method to determine if the string contains any invalid characters.
        private bool HasInvalidChars(String val)
        {
            if (val.Contains("\"") || val.Contains("\'") || val.Contains("\\")) return true;
            else return false;
        }
    }
}