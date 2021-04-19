using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        //private data member for the list 
        List<clsStock> mStockList = new List<clsStock>();
        //private data member thisStock
        clsStock mThisStock = new clsStock();

        //contructor
        public clsStockCollection()
        {

            //object for data connection 
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");

            //populate the array list with the dta table 
            PopulateArray(DB);
            

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the rray list based on the data table in the parameter DB 
            //var for the index 
            Int32 Index = 0;
            //var to store the recprd count 
            Int32 RecordCount;

            //get the count of records 
            RecordCount = DB.Count;

            //clear the pivate array list 
            mStockList = new List<clsStock>();

            //While there are records to process 
            while (Index > RecordCount)
            {
                //create a blank Stock
                clsStock AStock = new clsStock();

                //read in the fields from the current record.
                AStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AStock.DateUpdated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateUpdated"]);

                //adding the record to the private data member 
                mStockList.Add(AStock);
                //point at hte next record 
                Index++;

            }
        }
        

        public List<clsStock> StockList
        {
            get
            {
                //return the private data 
                return mStockList;
            }
            set
            {
                //set the private data 
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count6 of the list 
                return mStockList.Count;
            }
            set
            {
                //LATER
            }
        }
        public clsStock ThisStock
        {
            get
            {
                //return the private data 
                return mThisStock;
            }
            set
            {
                //setting the private data 
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //setting the parameters for the stored procedure
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Location", mThisStock.Location);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@DateUpdated", mThisStock.DateUpdated);
            DB.AddParameter("@Availability", mThisStock.Availability);

            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblStock_Insert");

        }

        public void Update()
        {
            //update an eisting rcord based on the values of thisStock 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Location", mThisStock.Location);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@DateUpdated", mThisStock.DateUpdated);
            DB.AddParameter("@Availability", mThisStock.Availability);

            //execute the stored procedure 
            DB.Execute("sproc_tblStock_Update");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock 
            //connect ot the database 
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure 
            DB.AddParameter("ProductID", mThisStock.ProductID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByQuantity(int Quantity)
        {
            //filters the records based on a full or partial location
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();

            //send the quantity parameter to the database 
            DB.AddParameter("@Quantity", Quantity);

            //execute the stored procedure 
            DB.Execute("sproc_tblStock_FilterByQuantity");

            //populate the array list with the data table 
            PopulateArray(DB);
        }
    }
}