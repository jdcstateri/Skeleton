using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // if thiis the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayProducts();
        }
    }
    void DisplayProducts()
    {
        // create an instance of the product collection
        clsProductCollection ProductList = new clsProductCollection();
        // set the data source to the product list
        lstProductList.DataSource = ProductList.ProductList;
        // set the name of the primary key
        lstProductList.DataValueField = "ItemID";
        // set the data field to display
        lstProductList.DataTextField = "ProductTitle";
        // bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnAdd_Click_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate that this is a new record
        Session["ItemID"] = -1;
        // redirect to the data entry page
        Response.Redirect("ProductDataEntry.aspx");
    }

    protected void btn_Edit_Click(object sender, EventArgs e)
    {
        //varaiable to store the primary key value of the recored edit
        Int32 ItemID;
        // if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            // get the primary key value of the record to be edited
            ItemID = Convert.ToInt32(lstProductList.SelectedValue);
            // store the data in the session object
            Session["ItemID"] = ItemID;
            // redirect to the data entry page
            Response.Redirect("ProductDataEntry.aspx");
        }
        else
        {
            // display an error message
            lblError.Text = "Please select a record to edit from the list";
        }   
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 ItemID;
        // if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            // get the primary key value of the record to be deleted
            ItemID = Convert.ToInt32(lstProductList.SelectedValue);
            // store the data in the session object
            Session["ItemID"] = ItemID;
            // redirect to the delete page
            Response.Redirect("ProductConfirmDelete.aspx");
        }
        else
        {
            // display an error message
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}