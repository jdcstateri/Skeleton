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
}