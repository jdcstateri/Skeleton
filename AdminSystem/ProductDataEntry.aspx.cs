using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        // create an instance of the product class 
        clsProduct AnProduct = new clsProduct();
        // capture the product id
        AnProduct.ItemID = Convert.ToInt32(txtItemID.Text); // issue with this line itemID something like StockID
        AnProduct.ProductTitle = txtProductTitle.Text;
        AnProduct.ProductDescription = txtProductDescription.Text;
        AnProduct.Price = Convert.ToSingle(txtPrice.Text);
        AnProduct.StockNumber = Convert.ToInt32(txtStockNumber.Text);
        AnProduct.DateAdded = DateTime.Now;
        AnProduct.IsPublished = chkIsPublished.Checked ? true : false;


        // store the stock number in session object
        Session["AnProduct"] = AnProduct;
        // Navigate to the ProductViewer page
        Response.Redirect("ProductViewer.aspx");
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create and instance of the product class
        clsProduct AnProduct = new clsProduct();
        // create varuable to store the primary key
        Int32 ItemID;
        // create a variable to store the result of the find operation
        Boolean Found = false;
        // get the primary key entered by the user
        ItemID = Convert.ToInt32(txtItemID.Text);
        // find the record
        Found = AnProduct.Find(ItemID);
        // if found
        if (Found == true)
        {
            // display the values of the properties in the form
            txtProductTitle.Text = AnProduct.ProductTitle;
            txtProductDescription.Text = AnProduct.ProductDescription;
            txtPrice.Text = AnProduct.Price.ToString();
            txtStockNumber.Text = AnProduct.StockNumber.ToString();
            txtDateAdded.Text = AnProduct.DateAdded.ToString("yyyy-MM-ddTHH:mm");
            chkIsPublished.Checked = AnProduct.IsPublished;
        }
        else
        {
            // display an error message
            lblError.Text = "Item not found";
        }

    }
}