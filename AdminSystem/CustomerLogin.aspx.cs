using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsCustomer AnUser = new clsCustomer();
        //create the variables to store the email and password
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the email entered by the user
        Email = Convert.ToString(txtEmail.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(Email, Password);
        //if email and/or password is empty
        if (txtEmail.Text == "")
        {
            //record the error
            lblError.Text = "Enter an email ";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Password ";
        }
        else if (Found == true)
        {
            //redirect to the list Page
            Response.Redirect("CustomerList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}