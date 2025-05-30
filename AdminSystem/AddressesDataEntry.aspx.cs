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
    //variable to store the primary key with page level scope
    Int32 AddressID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        AddressID = Convert.ToInt32(Session["AddressID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (AddressID != -1)
            {
                //display the current data for the record
                DisplayAddress();
            }
        }
    }

    void DisplayAddress()
    {
        //create an instance of the class
        clsAddressesCollection aAddress = new clsAddressesCollection();
        //find the record to update
        aAddress.ThisAddress.Find(AddressID);
        //display the data for the record
        txtAddressID.Text = aAddress.ThisAddress.AddressID.ToString();
        txtAccountID.Text = aAddress.ThisAddress.AccountID.ToString();
        txtAddress.Text = aAddress.ThisAddress.Address.ToString();
        txtPostCode.Text = aAddress.ThisAddress.PostCode.ToString();
        txtDateAdded.Text = aAddress.ThisAddress.DateAdded.ToString();
        chkIsActive.Checked = aAddress.ThisAddress.IsActive;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance of clsAddresses
        clsAddresses aAddress = new clsAddresses();
        //capture address id
        //string AddressID = txtAddress.Text;
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
        Error = aAddress.Valid(DateAdded, Address, PostCode, AccountID);
        if (Error == "")
        {
            //capture address id
            aAddress.AddressID = AddressID;
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

            //if this is a new record i.e. ID = -1 then add the data
            if (AddressID == -1)
            {
                //set the thisdata property
                AddressList.ThisAddress = aAddress;
                //add the new record
                AddressList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                AddressList.ThisAddress.Find(AddressID);
                //set thisdata property
                AddressList.ThisAddress = aAddress;
                //update the record
                AddressList.Update();
            }

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

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddressesList.aspx");
    }
}