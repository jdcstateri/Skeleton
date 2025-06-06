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
    // Store the ID of the product (if editing an existing one)
    Int32 ItemID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Try to retrieve the ItemID from the session safely
        int tempItemID;
        if (Session["ItemID"] != null && int.TryParse(Session["ItemID"].ToString(), out tempItemID))
        {
            ItemID = tempItemID;
        }
        else
        {
            ItemID = -1; // New product
        }

        if (!IsPostBack)
        {
            DisplayProducts();

            if (lblError.Visible)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "HideErrorOnLoad", "hideErrorAfterDelay();", true);
            }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsProduct AnProduct = new clsProduct();

        string itemIDText = txtItemID.Text.Trim();
        string productTitleText = txtProductTitle.Text.Trim();
        string productDescText = txtProductDescription.Text.Trim();
        string priceText = txtPrice.Text.Trim();
        string stockNumberText = txtStockNumber.Text.Trim();
        string dateAddedText = txtDateAdded.Text.Trim();
        string isPublishedText = chkIsPublished.Checked ? "true" : "false";

        string Error = "";

        int parsedItemID;
        if (!int.TryParse(itemIDText, out parsedItemID))
        {
            Error += "Invalid Item ID.<br />";
        }
        else
        {
            AnProduct.ItemID = parsedItemID;
        }

        Error += AnProduct.Valid(productTitleText, productDescText, priceText, stockNumberText, dateAddedText, isPublishedText);

        if (Error == "")
        {
            AnProduct.ProductTitle = productTitleText;
            AnProduct.ProductDescription = productDescText;
            AnProduct.Price = Convert.ToSingle(priceText);
            AnProduct.StockNumber = Convert.ToInt32(stockNumberText);
            AnProduct.DateAdded = Convert.ToDateTime(dateAddedText);
            AnProduct.IsPublished = chkIsPublished.Checked;

            clsProductCollection ProductList = new clsProductCollection();

            if (ItemID == -1)
            {
                ProductList.ThisProduct = AnProduct;
                ProductList.Add();
            }
            else
            {
                ProductList.ThisProduct.Find(ItemID);
                ProductList.ThisProduct = AnProduct;
                ProductList.Update();
            }

            Response.Redirect("ProductList.aspx");
        }
        else
        {
            lblError.Text = Error;
            lblError.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "HideErrorOk", "hideErrorAfterDelay();", true);
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsProduct AnProduct = new clsProduct();
        Int32 findItemID;
        Boolean Found = false;

        if (Int32.TryParse(txtItemID.Text.Trim(), out findItemID))
        {
            Found = AnProduct.Find(findItemID);
            if (Found)
            {
                txtProductTitle.Text = AnProduct.ProductTitle;
                txtProductDescription.Text = AnProduct.ProductDescription;
                txtPrice.Text = AnProduct.Price.ToString();
                txtStockNumber.Text = AnProduct.StockNumber.ToString();
                txtDateAdded.Text = AnProduct.DateAdded.ToString("yyyy-MM-dd"); // fixed the date format so that once it reterieved from the data
                chkIsPublished.Checked = AnProduct.IsPublished;
                lblError.Visible = false;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Item not found.";
                lblError.Visible = true;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "HideErrorFind", "hideErrorAfterDelay();", true);
                ClearFields();
            }
        }
        else
        {
            lblError.Text = "Please enter a valid Item ID to find.";
            lblError.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "HideErrorInvalidFindID", "hideErrorAfterDelay();", true);
            ClearFields();
        }
    }

    void DisplayProducts()
    {
        clsProductCollection ProductList = new clsProductCollection();
        Boolean Found = false;

        if (ItemID != -1)
        {
            Found = ProductList.ThisProduct.Find(ItemID);
            if (Found)
            {
                txtItemID.Text = ProductList.ThisProduct.ItemID.ToString();
                txtProductTitle.Text = ProductList.ThisProduct.ProductTitle;
                txtProductDescription.Text = ProductList.ThisProduct.ProductDescription;
                txtPrice.Text = ProductList.ThisProduct.Price.ToString();
                txtStockNumber.Text = ProductList.ThisProduct.StockNumber.ToString();
       
                txtDateAdded.Text = ProductList.ThisProduct.DateAdded.ToString("yyyy-MM-dd");
                chkIsPublished.Checked = ProductList.ThisProduct.IsPublished;
                lblError.Visible = false;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Record not found for initial display (ItemID: " + ItemID + ").";
                lblError.Visible = true;
            }
        }
        else
        {
            ClearFields();
            lblError.Text = "";
            lblError.Visible = false;
        }
    }

    protected void btnFClear_Click(object sender, EventArgs e)
    {
        // Check if all fields are already empty
        bool isAlreadyEmpty =
            string.IsNullOrWhiteSpace(txtItemID.Text) &&
            string.IsNullOrWhiteSpace(txtProductTitle.Text) &&
            string.IsNullOrWhiteSpace(txtProductDescription.Text) &&
            string.IsNullOrWhiteSpace(txtPrice.Text) &&
            string.IsNullOrWhiteSpace(txtStockNumber.Text) &&
            string.IsNullOrWhiteSpace(txtDateAdded.Text) &&
            !chkIsPublished.Checked;

        if (isAlreadyEmpty)
        {
            // Optional: Show a subtle message or do nothing at all
            lblError.Text = "Form is already empty.";
            lblError.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "HideErrorClear", "hideErrorAfterDelay();", true);
        }
        else
        {
            // Clear the form fields
            ClearFields();
            lblError.Text = "";
            lblError.Visible = false;
        }
    }


    private void ClearFields()
    {
        txtItemID.Text = "";
        txtProductTitle.Text = "";
        txtProductDescription.Text = "";
        txtPrice.Text = "";
        txtStockNumber.Text = "";
        txtDateAdded.Text = "";
        chkIsPublished.Checked = false;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect to the product list page
        Response.Redirect("ProductList.aspx");
    }
}