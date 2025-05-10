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

  
}
