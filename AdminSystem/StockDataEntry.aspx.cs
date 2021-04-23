using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockDataEntry : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);

        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductID != -1)
            {
                //display the current data for the record
                DisplayStocks();
            }
        }
    }

    void DisplayStocks()
    {
        //creates an intance of the Stock collection 
        clsStockCollection Stocks = new clsStockCollection();

        //find record to update 
        Stocks.ThisStock.Find(ProductID);

        //display the data for this record 
        txtQuantity.Text = Stocks.ThisStock.Quantity.ToString();
        txtLocation.Text = Stocks.ThisStock.Location;
        txtPrice.Text = Stocks.ThisStock.Price.ToString();
        txtDateUpdated.Text = Stocks.ThisStock.DateUpdated.ToString();
        chkAvailability.Checked = Stocks.ThisStock.Availability;
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //creates a new instance of clsStock
        clsStockCollection Stocks = new clsStockCollection();

        //capture the ProductID
        string ProductID = txtProductID.Text;
        //capture the Quantity
        string Quantity = txtQuantity.Text;
        //capture the Location
        string Location = txtLocation.Text;
        //capture the Price 
        string Price = txtPrice.Text;
        //capture the Availability
        string Availability = chkAvailability.Checked.ToString();
        //capture the DateUpdated 
        string DateUpdated = txtDateUpdated.Text;

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = Stocks.ThisStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
        
         if (Error == "")
         {
            //capture the productID
            Stocks.ThisStock.ProductID = Convert.ToInt32(ProductID);
            //capture the quantity
            Stocks.ThisStock.Quantity = Convert.ToInt32(Quantity);
            //capture the Location
            Stocks.ThisStock.Location = Location;
            //capture the Price
            Stocks.ThisStock.Price = double.Parse(Price);
            //capture the Date updated
            Stocks.ThisStock.DateUpdated = Convert.ToDateTime(DateUpdated);
            //capture availibility
            Stocks.ThisStock.Availability = chkAvailability.Checked;

            //create a new instance of the stock collection 
            clsStockCollection StockList = new clsStockCollection();

            try
            {
                // If this is a new record then add the data
                if (Stocks.ThisStock.ProductID == -1)
                {
                      // Add the new record
                        Stocks.Add();
               
                }

                else // Otherwise it must be updated
                {
                     // Find the record to update.
                        Stocks.ThisStock.Find(Stocks.ThisStock.ProductID);
                        // Update the record
                        Stocks.Update();
               
                }
            }

            catch
            {
                lblError.Text = "There was a problem with the data entered" + Error;
            }

            // Redirect to the list page
            Response.Redirect("StockList.aspx");
            
         }

        else
        {
            //display the error message
            lblError.Text = Error;
        }

        

    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        //creates an instance of Stock class
        clsStockCollection AStock = new clsStockCollection();

        //variable to store the primary key
        Int32 ProductID;

        //variable to store the result of thew find operation
        Boolean Found = false;

        //get the primary key entered by the user 
        ProductID = Convert.ToInt32(txtProductID.Text);

        //find the record
        Found = AStock.ThisStock.Find(ProductID);

        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtProductID.Text = AStock.ThisStock.ProductID.ToString();
            txtQuantity.Text = AStock.ThisStock.Quantity.ToString();
            txtLocation.Text = AStock.ThisStock.Location;
            txtPrice.Text = AStock.ThisStock.Price.ToString();
            txtDateUpdated.Text = AStock.ThisStock.DateUpdated.ToString();

        }
        else
        {
            lblError.Text = "Invalid ProductID";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to main 
        Response.Redirect("StockList.aspx");
    }
}