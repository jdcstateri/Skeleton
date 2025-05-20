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
        // create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();

        // capture all inputs as strings
        string itemIDText = txtItemID.Text.Trim();
        string productTitleText = txtProductTitle.Text.Trim();
        string productDescText = txtProductDescription.Text.Trim();
        string priceText = txtPrice.Text.Trim();
        string stockNumberText = txtStockNumber.Text.Trim();
        string dateAddedText = txtDateAdded.Text.Trim();
        string isPublishedText = chkIsPublished.Checked ? "true" : "false";

        // variable to store any error messages
        string Error = "";

        // validate the data
        Error = AnProduct.Valid(
            productTitleText,
            productDescText,
            priceText,
            stockNumberText,
            dateAddedText,
            isPublishedText
        );

        if (Error == "")
        {
            

            // capture the itemID
            AnProduct.ItemID = Convert.ToInt32(itemIDText);
            // capture other fields
            AnProduct.ProductTitle = productTitleText;
            AnProduct.ProductDescription = productDescText;
            AnProduct.Price = Convert.ToSingle(priceText);
            AnProduct.StockNumber = Convert.ToInt32(stockNumberText);
            AnProduct.DateAdded = Convert.ToDateTime(dateAddedText);
            AnProduct.IsPublished = chkIsPublished.Checked;

            // store the product object in session
            Session["AnProduct"] = AnProduct;
            // navigate to the viewer page
            Response.Redirect("ProductViewer.aspx");
        }
        else
        {
            // if there are validation errors, show them
            lblError.Text = Error;
            lblError.Visible = true;
        }
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
}
 
