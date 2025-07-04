﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Redirect if not logged in or not admin
        if (Session["IsAdmin"] == null || !(bool)Session["IsAdmin"])
        {
            Response.Redirect("StaffLogin.aspx");
        }
        //Get the number of the staff to be deleted from the session object
        StaffId = Convert.ToInt32(Session["StaffID"]);
    }


    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //Create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //Find the record to delete
        Staff.ThisStaff.Find(StaffId);
        //Delete the record
        Staff.Delete();
        //Redirect back to the staff list page
        Response.Redirect("StaffList.aspx");
    }
    protected void BtnNo_Click(object sender, EventArgs e)
    {
        //Redirect back to the staff list page
        Response.Redirect("StaffList.aspx");
    }
}