using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the product id property
        private Int32 mProductID;
        //ProductID public property
        public int ProductID
        {
            get
            {
                //sends data out of this property
                return mProductID;
            }
            set
            {
                //allows data into this property
                mProductID = value;
            }
        }

        //private data member for the quantity property
        private Int32 mQuantity;
        //Quantity public property
        public int Quantity
        {
            get
            {
                //sends data out of this property
                return mQuantity;
            }
            set
            {
                //allows data into this property
                mQuantity = value;
            }
        }

        //private data member for the location property
        private string mLocation;
        //Location public property
        public string Location
        {
            get
            {
                //sends data out of this property
                return mLocation;
            }
            set
            {
                //allows data into this property
                mLocation = value;
            }
        }

        //private data member for the price property
        private Double mPrice;
        //Price public property
        public double Price
        {
            get
            {
                //sends data out of this property
                return mPrice;
            }
            set
            {
                //allows data into this property
                mPrice = value;
            }
        }

        //private data member for the Availability property
        private Boolean mAvailability;
        //Availability public property
        public bool Availability
        {
            get
            {
                //sends data out of this property
                return mAvailability;
            }
            set
            {
                //allows data into this property
                mAvailability = value;
            }
        }

        //private data member for the DateUpdated property
        private DateTime mDateUpdated;
        //DateUpdated public property
        public DateTime DateUpdated
        {
            get
            {
                //sends data out of this property
                return mDateUpdated;
            }
            set
            {
                //allows data into this property
                mDateUpdated = value;
            }
        }

        public bool Find(int productID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the product id to search for 
            DB.AddParameter("@ProductID", ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByProductID");

            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mLocation = Convert.ToString(DB.DataTable.Rows[0]["Location"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mDateUpdated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateUpdated"]);

                //return that everything worked OK
                return true;
            }

            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        

            //sets the private data members to the test data value of Product ID
            //mProductID = 21;
            //mQuantity = 10;
            //mLocation = "Factory Outlet";
            //mPrice = 15.0;
            //mAvailability = true;
            //mDateUpdated = Convert.ToDateTime("12/02/2021");

            //always return true
            //return true;
        }

        public string Valid(string productID, string quantity, string location, string price, string dateUpdated)
        {
            //creates a String variable to store the error 
            String Error = "";
            //creates a temporary DateTime variable to store date values
            DateTime DateTemp;

            //if the Location is blank
            if (location.Length == 0)
            {
                //record the error 
                Error = Error + "The location may not be blank :";
            }
            //if the Location is greater than 30 characters
            if (location.Length > 30)
            {
                //record the error 
                Error = Error + "The location must be greater than 30 characters :";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateUpdated);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date is not a valid date :";
            }

                //return any error messages 
                return Error;
        }
    }
}