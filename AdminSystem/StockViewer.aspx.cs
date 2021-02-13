using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates a new instance of clsStock
        clsStock AStock = new clsStock();

        //get the data from the session object 
        AStock = (clsStock)Session["AStock"];

        //PRODUCT ID
        Response.Write("Product ID: ");
        //display the ProductID for this entry
        Response.Write(AStock.ProductID);
        //next line
        Response.Write("<br>");

        //QUANTITY
        Response.Write("Quantity: ");
        //display the Quantity for this entry
        Response.Write(AStock.Quantity);
        //next line
        Response.Write("<br>");

        //LOCATION
        Response.Write("Location of the Stock: ");
        //display the Location for this entry 
        Response.Write(AStock.Location);
        //next line
        Response.Write("<br>");

        //PRICE
        Response.Write("Price: ");
        //display the Price for this entry 
        Response.Write(AStock.Price);
        //next line
        Response.Write("<br>");

        //AVAILABILITY 
        Response.Write("Availabilty: ");
        //display the Availability for this entry 
        Response.Write(AStock.Availability);
        //next line
        Response.Write("<br>");

        //DATE UPDATED
        //display the DateUpdated for this entry 
        Response.Write(AStock.DateUpdated);
    }
}