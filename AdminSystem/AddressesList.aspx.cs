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
}