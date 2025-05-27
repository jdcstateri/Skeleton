using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ItemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the primary key value of the record to be deleted from the session object
        ItemID = Convert.ToInt32(Session["ItemID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create a new instance of the product collection
        ClassLibrary.clsProductCollection ProductList = new ClassLibrary.clsProductCollection();
        // find the record to delete
        ProductList.ThisProduct.Find(ItemID);
        // delete the record
        ProductList.Delete();
        // redirect back to the product list page
        Response.Redirect("ProductList.aspx");
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect back to the product list page
        Response.Redirect("ProductList.aspx");
    }

}



    