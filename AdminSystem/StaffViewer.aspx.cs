using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create an instance of clsStaff.
        clsStaff Staff = new clsStaff();
        // Get the data from the session object.
        Staff = (clsStaff) Session["Staff"];
        // Display the StaffID for this entry.
        Response.Write(Staff.StaffID);
        Response.Write("<br>");
        Response.Write(Staff.StaffName);
        Response.Write("<br>");
        Response.Write(Staff.DateAccessed);
        Response.Write("<br>");
        Response.Write(Staff.TotalCost);
        Response.Write("<br>");
        Response.Write(Staff.ProductID);
        Response.Write("<br>");
        Response.Write(Staff.GrantAccess);
        Response.Write("<br>");
        Response.Write(Staff.Active);
        Response.Write("<br>");
    }
}