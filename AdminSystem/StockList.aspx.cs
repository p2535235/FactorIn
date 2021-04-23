using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class StockList : System.Web.UI.Page
{
    
    //this function hndles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //if thisis the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        //creates an intance of the Stock collection 
        clsStockCollection Stocks = new clsStockCollection();
        
        //set the data source to the list of the stocks in the collection
        lstStockList.DataSource = Stocks.StockList;
        //setting the name of the primary key 
        lstStockList.DataValueField = "ProductID";
        //setting the data field to display 
        lstStockList.DataTextField = "Quantity";
        lstStockList.DataTextField = "ProductID";
        //bind the data to the list 
        lstStockList.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the sessin object to indicate this is a ne record 
        Session["ProductID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("StockDataEntry.aspx"); 
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key of the ecord to be edited 
        Int32 ProductID;

        //if a record has been selected from the list 
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);

            //store the data in the session object 
            Session["ProductID"] = ProductID;

            //redirect to the edit page 
            Response.Redirect("StockDataEntry.aspx"); 
        }
        else // if no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to edit from the list";
        }
    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Var to store the primary key value of the record to be deleted
        Int32 ProductID;

        // If a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to delete
            ProductID = Convert.ToInt32(lstStockList.SelectedIndex);
            // Store the data in the session object
            Session["ProductID"] = ProductID;

            // Redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx"); 
        }
        else
        {
            // Display an error
            lblError.Text = "Please select a record to delete from the list.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection 
        clsStockCollection Stocks = new clsStockCollection();

        if (txtFilter.Text != "")
        {

            Int32 Filter = Convert.ToInt32(txtFilter.Text);

            Stocks.ReportByQuantity(Filter);
            lstStockList.DataSource = Stocks.StockList;

            //set the name of the primary key 
            lstStockList.DataValueField = "ProductID";
            //set the nae of the field to disply 
            lstStockList.DataValueField = "Quantity";

            //bind the data to the list 
            lstStockList.DataBind();
            
        }

        else
        {
            DisplayStocks();
        }



    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection 
        clsStockCollection Stocks = new clsStockCollection();

        //clear any existing filter to tidy up the interface 
        txtFilter.Text = "";
        lstStockList.DataSource = Stocks.StockList;

        //set the name of the primary key 
        lstStockList.DataValueField = "ProductID";
        //set the nae of the field to disply 
        lstStockList.DataValueField = "Quantity";

        //bind the data to the list 
        lstStockList.DataBind();

    }

  
}