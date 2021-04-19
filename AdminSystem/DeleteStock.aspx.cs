using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteStock : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 ProductID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from te session object 
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book 
        clsStockCollection Stock = new clsStockCollection();
        //find the record to delete 
        Stock.ThisStock.Find(ProductID);
        //delete the record 
        Stock.Delete();

        //redirect back to the main page 
        Response.Redirect("StockList.aspx");
    }
}