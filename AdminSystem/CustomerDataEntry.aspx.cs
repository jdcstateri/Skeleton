using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //capture id
        string AccountID = txtAccountID.Text;
        //capture name
       string Name = txtName.Text;
        //capture email
        string Email = txtEmail.Text;
        //capture password
        string Password = txtPassword.Text;
        //capture date
        string DateRegistered = txtDateRegistered.Text;
        //capture check box
        string IsVerified = chkVerified.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aCustomer.Valid(DateRegistered, Name, Email, Password);
        if (Error == "")
        {
            //capture id
            //aCustomer.AccountID = Convert.ToInt32(txtAccountID.Text);
            //capture name
            aCustomer.Name = Name;
            //capture email
            aCustomer.Email = Email;
            //capture password
            aCustomer.Password = Password;
            //capture date
            aCustomer.DateRegistered = Convert.ToDateTime(DateRegistered);
            //capture check box
            aCustomer.IsVerified = chkVerified.Checked;
            //create a new instance of the class collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the record property
            CustomerList.ThisCustomer = aCustomer;
            //add the new record
            CustomerList.Add();
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        } 
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer aCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 AccountID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AccountID = Convert.ToInt32(txtAccountID.Text);
        //find the record
        Found = aCustomer.Find(AccountID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAccountID.Text = aCustomer.AccountID.ToString();
            txtName.Text = aCustomer.Name;
            txtEmail.Text = aCustomer.Email;
            txtPassword.Text = aCustomer.Password;
            txtDateRegistered.Text = aCustomer.DateRegistered.ToString();
            chkVerified.Checked = aCustomer.IsVerified;
        }
    }
}