using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key of the record to be deleted
    Int32 AddressID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of accounts to be deleted from the session object
        AddressID = Convert.ToInt32(Session["AddressID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsAddressesCollection AllAddresses = new clsAddressesCollection();
        //find the record to delete
        AllAddresses.ThisAddress.Find(AddressID);
        //delete the record
        AllAddresses.Delete();
        //redirect back to main page
        Response.Redirect("AddressesList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("AddressesList.aspx");
    }
}