using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create an instance of clsStaff.
        clsStaff Staff = new clsStaff();
        // Capture the StaffID Property.
        Staff.StaffID = int.Parse(txtStaffID.Text);
        // Capture the StaffName Property.
        Staff.StaffName = txtStaffName.Text;
        // Capture the DateAccessed Property.
        Staff.DateAccessed = Convert.ToDateTime(txtDateAccessed.Text);
        // Capture the TotalCost Property.
        Staff.TotalCost = double.Parse(txtTotalCost.Text);
        // Capture the ProductID Property.
        Staff.ProductID = int.Parse(txtProductID.Text);
        // Capture the GrantAccess Property.
        Staff.GrantAccess = chkGrantAccess.Checked;
        // Capture the Active Property.
        Staff.Active = chkActive.Checked;
        // Store the Staff object in the session object.
        Session["Staff"] = Staff;
        // Navigate to the viewer page.
        Response.Redirect("StaffViewer.aspx");
    }
}