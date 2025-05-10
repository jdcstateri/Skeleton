using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create an instance of the product class
        clsProduct AnProduct = new clsProduct();
        // get the data from the session object
        AnProduct = (clsProduct)Session["AnProduct"];
        // display Details of the product
        Response.Write(AnProduct.ItemID);
        Response.Write(AnProduct.ProductTitle);
        Response.Write(AnProduct.ProductDescription);
        Response.Write(AnProduct.Price);
        Response.Write(AnProduct.StockNumber);
        Response.Write(AnProduct.DateAdded);
        Response.Write(AnProduct.IsPublished);
        
    }
}
