using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 AccountID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        AccountID = Convert.ToInt32(Session["AccountID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (AccountID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the class
        clsCustomerCollection aCustomer = new clsCustomerCollection();
        //find the record to update
        aCustomer.ThisCustomer.Find(AccountID);
        //display the data for the record
        txtAccountID.Text = aCustomer.ThisCustomer.AccountID.ToString();
        txtName.Text = aCustomer.ThisCustomer.Name.ToString();
        txtEmail.Text = aCustomer.ThisCustomer.Email.ToString();
        txtPassword.Text = aCustomer.ThisCustomer.Password.ToString();
        txtDateRegistered.Text = aCustomer.ThisCustomer.DateRegistered.ToString();
        chkVerified.Checked = aCustomer.ThisCustomer.IsVerified;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //capture id
        //String AccountID = txtAccountID.Text;
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
        aCustomer.AccountID = AccountID; //dont miss this bit
        Error = aCustomer.Valid(DateRegistered, Name, Email, Password, AccountID);
        if (Error == "")
        {
            //capture id
            aCustomer.AccountID = AccountID; //dont miss this bit
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

            //if this is a new record i.e. ID = -1 then add the data
            if (AccountID == -1)
            {
                //set the thisdata property
                CustomerList.ThisCustomer = aCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(AccountID);
                //set thisdata property
                CustomerList.ThisCustomer = aCustomer;
                //update the record
                CustomerList.Update();
            }

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

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}