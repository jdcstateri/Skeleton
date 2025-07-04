﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key of the record to be deleted
    Int32 AccountID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of accounts to be deleted from the session object
        AccountID = Convert.ToInt32(Session["AccountID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //find the record to delete
        AllCustomers.ThisCustomer.Find(AccountID);
        //delete the record
        AllCustomers.Delete();
        //redirect back to main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("CustomerList.aspx");
    }
}