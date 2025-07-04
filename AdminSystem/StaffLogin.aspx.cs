﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffUser AStaff = new clsStaffUser();
        //create the variable to store the email
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        //create the variable to store the result of the find user operation
        Boolean Found = false;
        //Get the Email entered by the user
        Email = Convert.ToString(Email);
        //Get the password entered by the user
        Password = Convert.ToString(Password);
        //Find the records
        Found = AStaff.FindUser(Email, Password);
        //if Email and Password found
        if (txtEmail.Text == "")
        {
            lblError.Text = "Enter a Email";
            return;
        }
        if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password";
            return;
        }

        //Authenticate
        if (Found == true)
        {

            Session["StaffID"] = AStaff.StaffID;
            Session["IsAdmin"] = AStaff.IsAdmin;

            UpdateLastLogin(AStaff.StaffID, DateTime.Now); // Update last login time


            if (AStaff.IsAdmin == true)
            {
                //redirect to the list Page
                Int32 StaffLogin = Convert.ToInt32(Session["StaffLogin"]);
                if (StaffLogin == 1) //StaffList button was clicked in menu
                {
                    Response.Redirect("StaffList.aspx");
                }
                else if (StaffLogin == 2) //Activity Log button was clicked in menu
                {
                    Response.Redirect("ActivityLogList.aspx");
                }
            }
            else
            {
                Response.Redirect("CustomerLogin.aspx");
            }
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect, please try aagain!";
        }
        else if (Found == false)
        {
            lblError.Text = "Invalid Login Credentials!";
        }
    }

    public bool UpdateLastLogin(int staffId, DateTime lastLogin)
    {
        try
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", staffId);
            DB.AddParameter("@LastLogin", lastLogin);
            DB.Execute("sproc_tblStaff_Update_LastLogin");
            return true; // success
        }
        catch (Exception)
        {
            // handle exceptions/log as needed
            return false; // failure
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}