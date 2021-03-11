using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    // This function handles the load event for the page.
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed.
        if (IsPostBack == false)
        {
            // Update the list box.
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        // CreateChildControls and instance of the staff collection.
        clsStaffCollection StaffList = new clsStaffCollection();
        // Set the data source to the list of staff names in the collection.
        lstStaffList.DataSource = StaffList.StaffList;
        // Set the name of the primary key.
        lstStaffList.DataValueField = "StaffID";
        // Set the data field to display.
        lstStaffList.DataTextField = "Wage";
        // Bind the data to the list.
        lstStaffList.DataBind();
    }
}