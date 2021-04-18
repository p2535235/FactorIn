﻿using System;
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
        //AStock.ProductID = int.Parse(txtProductID.Text);
        //capture the Quantity
        string Quantity = txtQuantity.Text;
        //AStock.Quantity = int.Parse(txtQuantity.Text);
        //capture the Location
        string Location = txtLocation.Text;
        //AStock.Location = txtLocation.Text;
        //capture the Price 
        string Price = txtPrice.Text;
        //AStock.Price = Double.Parse(txtPrice.Text);
        //capture the Availability
        AStock.Availability = chkAvailability.Checked;
        //capture the DateUpdated 
        string DateUpdated = txtDateUpdated.Text;
        //AStock.DateUpdated = Convert.ToDateTime(txtDateUpdated.Text);

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AStock.Valid(ProductID, Quantity, Location, Price, DateUpdated);
        if (Error == "")
        {
            //capture the productID
            AStock.ProductID = Convert.ToInt32(ProductID);
            //capture the productID
            AStock.Quantity = Convert.ToInt32(Quantity);
            //capture the productID
            AStock.Location = Location;
            //capture the productID
            AStock.Price = double.Parse(Price);
            //capture the productID
            AStock.DateUpdated = Convert.ToDateTime(DateUpdated);

            //store the address in the session object 
            Session["AStock"] = AStock;

            //navigate to viewer
            Response.Redirect("StockViewer.aspx");

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