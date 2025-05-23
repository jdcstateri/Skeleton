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
}