using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Var to store the primary key value of the record to be deleted.
    Int32 StaffID;

    // Event handler for the load event.
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the staff ID to be deleted from the session object.
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create a new instance of the staff list.
        clsStaffCollection StaffList = new clsStaffCollection();
        // Find the record to delete.
        StaffList.CurrentStaff.Find(StaffID);
        // Delete the record.
        StaffList.Delete();
        // Redirect back to the main page.
        Response.Redirect("AddressList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddressList.aspx");
    }
}