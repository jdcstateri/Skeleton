using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 OrderLogin = Convert.ToInt32(Session["OrderLogin"]);

        if (OrderLogin == 1) 
        {
            checkStaff.Visible = false;
        }
        else if (OrderLogin == 2) 
        {
            checkStaff.Visible = true;
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string email = Convert.ToString(txtEmail.Text);
        string password = Convert.ToString(txtPassword.Text);

        if (checkStaff.Checked == true)
        {
            StaffLogin(email, password);
        }
        else if (checkStaff.Checked == false)
        {
            CustomerLogin(email, password);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    private void StaffLogin(string email, string password)
    {
        clsStaffUser aStaff = new clsStaffUser();

        Boolean found = false;
        found = aStaff.FindUser(email, password);

        if (email == "")
        {
            lblError.Text = "Enter an email";
        }
        else if (password == "")
        {
            lblError.Text = "Enter a Password";
        }
        else if (found == true)
        {
            Session["StaffID"] = aStaff.StaffID;
            Session["IsAdmin"] = aStaff.IsAdmin;

            Response.Redirect("OrderViewer.aspx");
        }
        else if (found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again";
        }
    }

    private void CustomerLogin(string email, string password)
    {
        clsCustomer aCustomer = new clsCustomer();

        Boolean found = false;
        found = aCustomer.FindUser(email, password);

        Session["CustomerUser"] = aCustomer;

        if (email == "")
        {
            lblError.Text = "Enter an email";
        }
        else if (password == "")
        {
            lblError.Text = "Enter a Password";
        }
        else if (found == true)
        {
            Int32 OrderLogin = Convert.ToInt32(Session["OrderLogin"]);
           
            if (OrderLogin == 1)
            {
                Response.Redirect("OrderDataEntry.aspx");
            }
            else if (OrderLogin == 2) 
            {
                Response.Redirect("OrderViewer.aspx");
            }
        }
        else if (found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again";
        }
    }
}