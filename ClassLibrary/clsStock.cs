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

        //private data member for the Location property
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
        
            
        }

        

        public string Valid(string productID, string quantity, string Location, string price, string dateUpdated)
        {
            //creates a String variable to store the error 
            String Error = "";
            //creates a temporary DateTime variable to store date values
            DateTime DateTemp;

            int stockQuantity = Int32.Parse(quantity);
            //if the Quantity is less than 0
            if (stockQuantity < 0)
            {
                //record the error 
                Error = Error + "The Quantity cannot be less than 0 :";
            }
            //if the Quantity is greater than 2000 characters
            if (stockQuantity > 2000)
            {
                //record the error 
                Error = Error + "The Quantity should be less than 2000 :";
            }

            Double stockPrice = Double.Parse(price);
            //if the Quantity is less than 0
            if (stockPrice < 0)
            {
                //record the error 
                Error = Error + "The Price cannot be less than 0 :";
            }
            //if the Quantity is greater than 2000 characters
            if (stockPrice > 5000)
            {
                //record the error 
                Error = Error + "The Price should be less than 5000 :";
            }

            //if the Location is blank
            if (Location.Length == 0)
            {
                //record the error 
                Error = Error + "The Location may not be blank :";
            }
            //if the Location is greater than 30 characters
            if (Location.Length > 30)
            {
                //record the error 
                Error = Error + "The Location must be smaller than 30 characters :";
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