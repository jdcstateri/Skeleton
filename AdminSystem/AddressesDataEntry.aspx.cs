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
        //create an instance of clsAddresses
        clsAddresses aAddress = new clsAddresses();
        //capture address id
        string AddressID = txtAddress.Text;
        //capture account id
        string AccountID = txtAccountID.Text;
        //capture address
        string Address = txtAddress.Text;
        //capture post code
        string PostCode = txtPostCode.Text;
        //capture date added
        string DateAdded = txtDateAdded.Text;
        //capture check box
        string IsActive = chkIsActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aAddress.Valid(DateAdded, Address, PostCode);
        if (Error == "")
        {
            //capture address id
            //aAddress.AddressID = Convert.ToInt32(txtAddressID.Text);
            //capture account id
            aAddress.AccountID = Convert.ToInt32(AccountID);
            //capture address
            aAddress.Address = Address;
            //capture post code
            aAddress.PostCode = PostCode;
            //capture date added
            aAddress.DateAdded = Convert.ToDateTime(DateAdded);
            //capture check box
            aAddress.IsActive = chkIsActive.Checked;
            //create a new instance of the class collection
            clsAddressesCollection AddressList = new clsAddressesCollection();
            //set the record property
            AddressList.ThisAddress = aAddress;
            //add the new record
            AddressList.Add();
            //redirect back to the list page
            Response.Redirect("AddressesList.aspx");
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
        clsAddresses aAddress = new clsAddresses();
        //create a variable to store the primary key
        Int32 AddressID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AddressID = Convert.ToInt32(txtAddressID.Text);
        //find the record
        Found = aAddress.Find(AddressID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAddressID.Text = aAddress.AddressID.ToString();
            txtAccountID.Text = aAddress.AccountID.ToString();
            txtAddress.Text = aAddress.Address;
            txtPostCode.Text = aAddress.PostCode;
            txtDateAdded.Text = aAddress.DateAdded.ToString();
            chkIsActive.Checked = aAddress.IsActive;
        }
    }
}