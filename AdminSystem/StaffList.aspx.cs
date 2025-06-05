using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Redirect if not logged in or not admin
        if (Session["IsAdmin"] == null || !(bool)Session["IsAdmin"])
        {
            Response.Redirect("StaffLogin.aspx");
        }

        if (IsPostBack == false)
        {
            //update the listbox
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();

        //set the data source to the list staff in the collectioj
        lstStaffList.DataSource = Staff.StaffList;

        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";

        //Set the data field to display
        lstStaffList.DataTextField = "Name";

        //Bind the data to the list
        lstStaffList.DataBind();
    }


    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate that this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }




    protected void ButtonEdit_Click1(object sender, EventArgs e)
    {
        //Variable to store the primary key of the record
        Int32 StaffID;
        //if a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {

            //get the primary key of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the data entry page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key of the record
        Int32 StaffID;

        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key of the record to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the data entry page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record to delete from the list";
        }
    }


    protected void ButtonFilter_Click(object sender, EventArgs e)
    {
        //create an instance 
        clsStaffCollection AStaff = new clsStaffCollection();

        //Retrieve the value of post code from the presentation layer
        AStaff.ReportByName(txtFilter.Text);

        //Set the data store to the list addresses in the collection
        lstStaffList.DataSource = AStaff.StaffList;

        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffID";

        //Set the name of the field to display
        lstStaffList.DataTextField = "Name";

        //bind the data to the list
        lstStaffList.DataBind();

        
    }
    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        //Create an Staff of the Staff object
        clsStaffCollection AStaff = new clsStaffCollection();

        //Set the empty String
        txtFilter.Text = "";

        //Set the data source to the list of Staff Collection
        lstStaffList.DataSource = AStaff.StaffList;

        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffID";

        //Set the name of the field to display
        lstStaffList.DataTextField = "Name";

        //Bind the data the list
        lstStaffList.DataBind();
    }
}