using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //creates a new instance of clsStock
        clsStock AStock = new clsStock();

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
        Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);

        if (Error == "")
        {
            //capture the productID
            AStock.ProductID = Convert.ToInt32(ProductID);
            //capture the quantity
            AStock.Quantity = Convert.ToInt32(Quantity);
            //capture the Location
            AStock.Location = Location;
            //capture the Price
            AStock.Price = double.Parse(Price);
            //capture the Date updated
            AStock.DateUpdated = Convert.ToDateTime(DateUpdated);
            //capture availibility
            AStock.Availability = chkAvailability.Checked;

            //create a new instance of the stock collection 
            clsStockCollection StockList = new clsStockCollection();

            // If this is a new record then add the data
            if (AStock.ProductID == -1)
            {
                // Set the thisStock property
                StockList.ThisStock = AStock;
                // Add the new record
                StockList.Add();
            }

            else // Otherwise it must be updated
            {
                // Find the record to update.
                StockList.ThisStock.Find(AStock.ProductID);
                // Set the currentStaff property
                StockList.ThisStock = AStock;
                // Update the record
                StockList.Update();
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
        clsStock AStock = new clsStock();

        //variable to store the primary key
        Int32 ProductID;

        //variable to store the result of thew find operation
        Boolean Found = false;

        //get the primary key entered by the user 
        ProductID = Convert.ToInt32(txtProductID.Text);

        //find the record
        Found = AStock.Find(ProductID);

        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtProductID.Text = AStock.ProductID.ToString();
            txtQuantity.Text = AStock.Quantity.ToString();
            txtLocation.Text = AStock.Location;
            txtPrice.Text = AStock.Price.ToString();
            txtDateUpdated.Text = AStock.DateUpdated.ToString();

        }
    }
}