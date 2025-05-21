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
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the class we want to create
        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //set the data source to list the records in the collection
        lstCustomerList.DataSource = AllCustomers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "AccountID";
        //set the data field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["AccountID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 PKey;
        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            PKey = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["AccountID"] = PKey;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
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
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            PKey = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["AccountID"] = PKey;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of address object
        clsCustomerCollection aCustomer = new clsCustomerCollection();
        //retrieve the value of the post code from the presentation layer
        aCustomer.ReportByName(txtName.Text);
        //set the data source to the list of addresses in the collection
        lstCustomerList.DataSource = aCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "AccountID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of address object
        clsCustomerCollection aCustomer = new clsCustomerCollection();
        //set empty string
        aCustomer.ReportByName("");
        //clera any existing filter to tidy up itnerface
        txtName.Text = "";
        //set the data source to the list of addresses in the collection
        lstCustomerList.DataSource = aCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "AccountID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Name";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}