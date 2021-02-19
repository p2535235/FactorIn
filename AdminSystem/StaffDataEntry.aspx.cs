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
        // Store the Staff object in the session object.
        Session["Staff"] = Staff;
        // Navigate to the viewer page.
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instances of the Staff class.
        clsStaff staff = new clsStaff();
        // Variable to store the primary key.
        Int32 StaffId;
        // Variable to store the result of the find operation.
        Boolean Found = false;
        // Get the primary key entered by the user.
        StaffId = Convert.ToInt32(txtStaffID.Text);
        // Find the record.
        Found = staff.Find(StaffId);

        // If found
        if(Found)
        {
            // Display the values of the properties in the form.
            txtStaffName.Text = staff.StaffName;
            txtDateAccessed.Text = staff.DateAccessed.ToString();
            txtTotalCost.Text = staff.TotalCost.ToString();
            txtProductID.Text = staff.ProductID.ToString();
            chkGrantAccess.Checked = staff.GrantAccess;
        }
    }
}