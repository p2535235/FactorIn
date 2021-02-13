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
        AStock.ProductID = int.Parse(txtProductID.Text);
        //capture the Quantity
        AStock.Quantity = int.Parse(txtQuantity.Text);
        //capture the Location
        AStock.Location = txtLocation.Text;
        //capture the Price 
        AStock.Price = Double.Parse(txtPrice.Text);
        //capture the Availability
        AStock.Availability = chkAvailability.Checked;
        //capture the DateUpdated 
        AStock.DateUpdated = Convert.ToDateTime(txtDateUpdated.Text);



        //store the address in the session object 
        Session["AStock"] = AStock;

        //navigate to viewer
        Response.Redirect("StockViewer.aspx");
    }


}