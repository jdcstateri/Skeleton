using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Xml.Linq;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsAddresses aAddress = new clsAddresses();
        //capture address id
        aAddress.AddressID = Convert.ToInt32(txtAddressID.Text);
        //capture account id
        aAddress.AccountID = Convert.ToInt32(txtAccountID.Text);
        //capture address
        aAddress.Address = txtAddress.Text;
        //capture post code
        aAddress.PostCode = txtPostCode.Text;
        //capture date added
        aAddress.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture check box
        aAddress.IsActive = chkIsActive.Checked;
        //store the name in the session object
        Session["aAddress"] = aAddress;
        //navigate to the view page
        Response.Redirect("AddressesViewer.aspx");
    }
}