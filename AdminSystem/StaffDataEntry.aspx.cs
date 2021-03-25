using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // Int32 to store the primary key within the page level scope.
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of staff members to be processed.
        StaffID = Convert.ToInt32(Session["StaffID"]);

        if(IsPostBack == false)
        {
            // If this is not a new record.
            if(StaffID != -1)
            {
                // Display the current data for the record.
                DisplayAddress();
            }
        }
    }
    
    void DisplayAddress()
    {
        // Create an instance of the address book.
        clsStaffCollection StaffMembers = new clsStaffCollection();
        // Find the record to update.
        StaffMembers.CurrentStaff.Find(StaffID);
        // Display the data for this record.
        txtStaffID.Text = StaffMembers.CurrentStaff.StaffID.ToString();
        txtStaffName.Text = StaffMembers.CurrentStaff.StaffName;
        txtDateOfBirth.Text = StaffMembers.CurrentStaff.DateOfBirth.ToString();
        txtWage.Text = StaffMembers.CurrentStaff.Wage.ToString();
        txtEmail.Text = StaffMembers.CurrentStaff.Email;
        chkGrantAccess.Checked = StaffMembers.CurrentStaff.GrantAccess;
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
            Staff.StaffID = Convert.ToInt32(StaffID);
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
            // Create a new instance of the address collection.
            clsStaffCollection staffList = new clsStaffCollection();

            // If this is a new record then add the data.
            if(this.StaffID == -1)
            {
                // Set the currentStaff property.
                staffList.CurrentStaff = Staff;
                // Add the new record.
                staffList.Add();
            } else // Otherwise update.
            {
                // Find the record to update.
                staffList.CurrentStaff.Find(StaffID);
                // Set the currentStaff property.
                staffList.CurrentStaff = Staff;
                // Update the record.
                staffList.Update();
            }

            // Redirect back to the listpage.
            Response.Redirect("StaffList.aspx");
            // Redirect back to the list page.
            Response.Redirect("StaffList.aspx");

        } else // Else display error message.
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