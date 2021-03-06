﻿using System;
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
        // Create an instance of the staff collection.
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

    // Event handler for the add button.
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate this is a new record.
        Session["StaffID"] = -1;
        // Redirect to the data entry page.
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Var to store the primary key of the record to be edited.
        Int32 StaffID;
        // If a record has been selected from the list.
        if (lstStaffList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit.
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            // Store the data in the session object.
            Session["StaffID"] = StaffID;
            // Redirect to the edit page.
            Response.Redirect("StaffDataEntry.aspx");
        }
        else // If no record has been selected.
        {
            // Display an error.,
            lblError.Text = "Please select a record to edit.";
        }
        
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Var to store the primary key value of the record to be deleted.
        Int32 StaffID;
        // If a record has been selected from the list.
        if (lstStaffList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to delete.
            StaffID = Convert.ToInt32(lstStaffList.SelectedIndex);
            // Store the data in the session object,
            Session["StaffID"] = StaffID;
            // Redirect to the delete page.
            Response.Redirect("StaffConfirmDelete.aspx");
        } else
        {
            // Display an error.
            lblError.Text = "Please select a record to delete from the list.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // Create an instance of the Staff collection
        clsStaffCollection StaffCollection = new clsStaffCollection();
        StaffCollection.ReportByStaffName(txtStaffName.Text);
        lstStaffList.DataSource = StaffCollection.StaffList;
        // Set the name of the primary key.
        lstStaffList.DataValueField = "StaffID";
        // Set the name of the field to display.
        lstStaffList.DataTextField = "StaffName";
        // Bind the data to the list.
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Create an instance of the address collection.
        clsStaffCollection staffCollection = new clsStaffCollection();
        staffCollection.ReportByStaffName("");
        // Clear any existing filter to tidy up the interface.
        txtStaffName.Text = "";
        lstStaffList.DataSource = staffCollection.StaffList;
        // Set the name of the primary key.
        lstStaffList.DataValueField = "StaffID";
        // Set the name of the field to display.
        lstStaffList.DataTextField = "StaffName";
        // Bind the data to the list.
        lstStaffList.DataBind();
    }
}