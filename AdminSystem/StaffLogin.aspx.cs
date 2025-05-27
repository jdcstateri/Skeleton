using System;
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
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password";
        }
        else if (Found == true)
        {
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect, please try aagain!";
        }
    }
}