using System;
using System.Collections.Generic;
//using System.Linq;
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
        clsShoppingCart myShoppingCart = FetchShoppingCart();

        clsOrder newOrder = new clsOrder(myShoppingCart, 
                                         Convert.ToInt32(txtAccountId.Text), 
                                         Convert.ToDateTime((DateTime.Now).AddDays(14)),
                                         txtDeliveryInstructions.Text);

        newOrder.CreateNewOrder();
    }

    private clsShoppingCart FetchShoppingCart()
    {
        clsShoppingCart shoppingCart = Session["ShoppingCart"] as clsShoppingCart;

        if (shoppingCart == null)
        {
            shoppingCart = new clsShoppingCart();
            shoppingCart.AddItem(new clsShoppingCartItem(6, 1, 1200.0f, false, 0f));
            shoppingCart.AddItem(new clsShoppingCartItem(8, 2, 600.0f, false, 0f));
        }

        return shoppingCart;
    }
}