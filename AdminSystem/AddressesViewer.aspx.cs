using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddresses
        clsAddresses aAddress = new clsAddresses();
        //get the data from the session object
        aAddress = (clsAddresses)Session["aAddress"];
        //display the name for this entry
        Response.Write(aAddress.AddressID);
        Response.Write(aAddress.AccountID);
        Response.Write(aAddress.Address);
        Response.Write(aAddress.PostCode);
        Response.Write(aAddress.DateAdded);
        Response.Write(aAddress.IsActive);
    }
}