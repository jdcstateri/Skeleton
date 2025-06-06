using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ProductUserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // create an instance of the clsProductUser class
        clsProductUser AnUser = new clsProductUser();
        // get the username and password entered by the user
        string Email = txtPEmail.Text;
        string Password = txtPassword.Text;

        // input validation
        if (string.IsNullOrWhiteSpace(Email))
        {
            lblError.Text = "Please enter an email.";
            return;
        }
        if (string.IsNullOrWhiteSpace(Password))
        {
            lblError.Text = "Please enter a password.";
            return;
        }

        // find the record
        bool Found = AnUser.FindUser(Email, Password);

        if (Found)
        {
            // Check if the user is an admin
            if (AnUser.IsAdmin) 
            {
                Response.Redirect("ProductList.aspx");
            }
            else
            {
                Response.Redirect("CustomerList.aspx");
            }
        }
        else
        {
            // if the user is not found, display an error message
            lblError.Text = "Invalid email or password.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Takes you back to homepage
        Response.Redirect("TeamMainMenu.aspx");
    }
}