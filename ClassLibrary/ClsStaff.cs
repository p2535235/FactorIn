using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Private data member for the respective properties.
        private int staffID;
        private string staffName;
        private DateTime dateOfBirth;
        private double wage;
        private string email;
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
        public string Email
        {
            get
            {
                // Returns the staffID variable.
                return email;
            }
            set
            {
                // Assigns the value to the staffID variable.
                email = value;
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
        public DateTime DateOfBirth
        {
            get
            {
                // Returns the staffID variable.
                return dateOfBirth;
            }
            set
            {
                // Assigns the value to the staffID variable.
                dateOfBirth = value;
            }
        }
        public double Wage
        {
            get
            {
                // Returns the staffID variable.
                return wage;
            }
            set
            {
                // Assigns the value to the staffID variable.
                wage = value;
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
                dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                wage = Convert.ToDouble(DB.DataTable.Rows[0]["Wage"]);
                grantAccess = Convert.ToBoolean(DB.DataTable.Rows[0]["GrantAccess"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);

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
            dateOfBirth = Convert.ToDateTime("01/01/2020");
            return true;
        }

        public bool Find(double TotalCost)
        {
            wage = 2.2;
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

        public String Valid(string staffID, string staffName, string dateOfBirth, string wage, string grantAccess, string email)
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
                DateTime date = DateTime.Parse(dateOfBirth);

                // If the Date is within bounds.
                if (date.Date.CompareTo(DateTime.Today.AddYears(-13)) > 0) Error += "The employee must be at least 13 years old : ";
                if (date.Date.CompareTo(DateTime.Today.AddYears(-150)) < 0) Error += "The employee must be no older than 150 years old : ";
            } catch
            {
                Error += "The date must be in the format of: \"DD/MM/YYYY\" : ";
            }

            try
            {
                // Double variable to store the emloyeeWage.
                Double emloyeeWage = Double.Parse(wage);

                // If the variable is within bounds.
                if (emloyeeWage > 100000000000) Error += "The wage must not exceed 100000000000 : ";
                if (emloyeeWage < 4.15) Error += "The wage must no lower than 4.15 : ";
            } catch
            {
                Error += "Invalid value, must be a decimal number of atleast 4.15 and no greater than 100000000000 : ";
            }

            try
            {
                // Bool for determining if access is granted.
                bool access = Boolean.Parse(grantAccess);
            } catch
            {
                Error += "Value must be either True, False, 1, or 0 : ";
            }

            // If the email is valid.
            if (!email.Contains("@") || email.Length < 5 || email.Length > 30) Error += "Invalid email : ";

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