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
}