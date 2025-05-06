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
        //create a new instance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //get the data from the session object
        aCustomer = (clsCustomer)Session["aCustomer"];
        //display the name for this entry
        Response.Write(aCustomer.AccountID);
        Response.Write(aCustomer.Name);
        Response.Write(aCustomer.Email);
        Response.Write(aCustomer.Password);
        Response.Write(aCustomer.DateRegistered);
        Response.Write(aCustomer.IsVerified);
    }
}