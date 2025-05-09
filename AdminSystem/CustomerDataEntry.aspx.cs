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
        aCustomer.AccountID = Convert.ToInt32(txtAccountID.Text);
        //capture name
        aCustomer.Name = txtName.Text;
        //capture email
        aCustomer.Email = txtEmail.Text;
        //capture password
        aCustomer.Password = txtPassword.Text;
        //capture date
        aCustomer.DateRegistered = Convert.ToDateTime(DateTime.Now);
        //capture check box
        aCustomer.IsVerified = chkVerified.Checked;
        //store the name in the session object
        Session["aCustomer"] = aCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
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