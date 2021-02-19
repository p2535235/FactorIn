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
           //ProductID = 21;
            //uantity = 10;
            //ocation = "Factory Outlet";
            //mPrice = 15.0;
            //mAvailability = true;
            //mDateUpdated = Convert.ToDateTime("12/02/2021");

            //always return true
            //return true;
        }

        
    }
}