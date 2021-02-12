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
                return ProductID;
            }
            set
            {
                // Assigns the value to the staffID variable.
                ProductID = value;
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

        public bool Find(int StaffID)
        {
            staffID = 34;
            return true;
        }

        public bool Find(string StaffName)
        {
            staffName = "bloop";
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

        /*public bool Find(int ProductID)
        {
            staffID = 34;
            return true;
        }*/
    }
}