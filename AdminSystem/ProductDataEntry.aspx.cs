using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{   
    // variable to store the primary key value
    Int32 ItemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the product to be processed
        ItemID = Convert.ToInt32(Session["ItemID"]);
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // populate the list of products
            DisplayProducts();
            // if this is not a new record
            if (ItemID != -1)
            {
                // display the current product details
                DisplayProducts();
            }
        }
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
            // create a new instance of the product collection
            clsProductCollection ProductList = new clsProductCollection();
            // If this is a new record i.e. ItemID = -1 then add the data
            if (ItemID == -1)
            {
                // set the ThisProduct property to the new record
                ProductList.ThisProduct = AnProduct;
                // add the new record
                ProductList.Add();
            }
            else
            {
                // find the record to update
                ProductList.ThisProduct.Find(ItemID);
                // set the ThisProduct property to the new record
                ProductList.ThisProduct = AnProduct;
                // update the record
                ProductList.Update();
            }
            // redirect back to the list page
            Response.Redirect("ProductList.aspx");  


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
    void DisplayProducts()
    {
        // create an instance of the product collectionb
        clsProductCollection ProductList = new clsProductCollection();
        // variable to store the result of the find operation
        Boolean Found = false;
        // find the record to update
        Found = ProductList.ThisProduct.Find(ItemID);
        // if the record is found
        if (Found == true)
        {
            // display the data for this record
            txtItemID.Text = ProductList.ThisProduct.ItemID.ToString();
            txtProductTitle.Text = ProductList.ThisProduct.ProductTitle;
            txtProductDescription.Text = ProductList.ThisProduct.ProductDescription;
            txtPrice.Text = ProductList.ThisProduct.Price.ToString();
            txtStockNumber.Text = ProductList.ThisProduct.StockNumber.ToString();
            txtDateAdded.Text = ProductList.ThisProduct.DateAdded.ToString("yyyy-MM-ddTHH:mm");
            chkIsPublished.Checked = ProductList.ThisProduct.IsPublished;
        }
        else
        {
            // display an error message
            lblError.Text = "Record not found";
            lblError.Visible = true;
        }
    }

}

 
