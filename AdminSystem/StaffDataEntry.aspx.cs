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

        // Capture the Staff ID.
        string StaffID = txtStaffID.Text;
        // Capture the Staff Name.
        string StaffName = txtStaffName.Text;
        // Capture the date of birth.
        string DateOfBirth = txtDateOfBirth.Text;
        // Capture the wage.
        string Wage = txtWage.Text;
        // Capture the Grant access boolean.
        string GrantAccess = chkGrantAccess.Checked.ToString();
        // Capture the email.
        string Email = txtEmail.Text;

        // Variable to store any error messages.
        string Error = "";
        // Validate the data.
        Error = Staff.Valid(StaffID, StaffName, DateOfBirth, Wage, GrantAccess, Email);
        if (Error == "")
        {
            // Capture the StaffID Property.
            Staff.StaffID = int.Parse(txtStaffID.Text);
            // Capture the StaffName Property.
            Staff.StaffName = txtStaffName.Text;
            // Capture the DateAccessed Property.
            Staff.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            // Capture the TotalCost Property.
            Staff.Wage = double.Parse(txtWage.Text);
            // Capture the ProductID Property.
            Staff.Email = txtEmail.Text;
            // Capture the GrantAccess Property.
            Staff.GrantAccess = chkGrantAccess.Checked;
            // Store the Staff object in the session object.
            Session["Staff"] = Staff;
            // Navigate to the viewer page.
            Response.Redirect("StaffViewer.aspx");
        } else
        {
            lblError.Text = Error;
        }
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
            txtDateOfBirth.Text = staff.DateOfBirth.ToString();
            txtWage.Text = staff.Wage.ToString();
            txtEmail.Text = staff.Email.ToString();
            chkGrantAccess.Checked = staff.GrantAccess;
        }
    }
}