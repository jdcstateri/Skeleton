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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAddresses();
        }
    }

    void DisplayAddresses()
    {
        //create an instance of the class we want to create
        clsAddressesCollection AllAddresses = new clsAddressesCollection();
        //set the data source to list the records in the collection
        lstAddressesList.DataSource = AllAddresses.AddressesList;
        //set the name of the primary key
        lstAddressesList.DataValueField = "AddressID";
        //set the data field to display
        lstAddressesList.DataTextField = "Address";
        //bind the data to the list
        lstAddressesList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["AddressID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AddressesDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 PKey;
        //if a record has been selected from the list
        if (lstAddressesList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            PKey = Convert.ToInt32(lstAddressesList.SelectedValue);
            //store the data in the session object
            Session["AddressID"] = PKey;
            //redirect to the edit page
            Response.Redirect("AddressesDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 PKey;
        //if a record has been selected from the list
        if (lstAddressesList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            PKey = Convert.ToInt32(lstAddressesList.SelectedValue);
            //store the data in the session object
            Session["AddressID"] = PKey;
            //redirect to the delete page
            Response.Redirect("AddressesConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}