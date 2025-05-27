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

        clsOrder newOrder = new clsOrder(Convert.ToInt32(txtAccountId.Text), 
                                         Convert.ToDateTime((DateTime.Now).AddDays(14)),
                                         false,
                                         txtDeliveryInstructions.Text);

        clsOrderCollection orderCollection = new clsOrderCollection();
        clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();

        foreach (clsShoppingCartItem item in myShoppingCart.GetShoppingCart())
        {
            clsOrderLine newOrderLine = new clsOrderLine(item.ProductId, DateTime.Now, "Pending", item.Cost * item.Quantity, item.Quantity);
            orderLineCollection.AddOrderline(newOrderLine);
        }

        orderCollection.SetThisOrder(newOrder);
        orderCollection.Add();

        orderLineCollection.Add(myShoppingCart, newOrder);
    }

    private clsShoppingCart FetchShoppingCart()
    {
        clsShoppingCart shoppingCart = Session["ShoppingCart"] as clsShoppingCart;

        if (shoppingCart == null)
        {
            shoppingCart = new clsShoppingCart();
            shoppingCart.AddItem(new clsShoppingCartItem(6, 1, 1200.0f));
            shoppingCart.AddItem(new clsShoppingCartItem(8, 2, 600.0f));
        }

        return shoppingCart;
    }
}