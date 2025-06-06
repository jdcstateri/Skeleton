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
        if (Session["CustomerUser"] == null)
        {
            Response.Redirect("OrderLogin.aspx");
        }
        if (!IsPostBack)
        {
            DisplayShoppingCart();

        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsShoppingCart myShoppingCart = FetchShoppingCart();
        clsCustomer clsCustomer = Session["CustomerUser"] as clsCustomer;

        clsOrder newOrder = new clsOrder(Convert.ToInt32(clsCustomer.AccountID), 
                                         Convert.ToDateTime((DateTime.Now).AddDays(14)),
                                         false,
                                         txtDeliveryInstructions.Text);

        clsOrderCollection orderCollection = new clsOrderCollection();
        clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();

        foreach (clsShoppingCartItem item in myShoppingCart.GetShoppingCart())
        {
            clsOrderLine newOrderLine = new clsOrderLine(item.ProductId, DateTime.Now, "Pending", item.Cost, item.Quantity);
            orderLineCollection.AddOrderline(newOrderLine);
        }

        newOrder.SetOrderLineCollection(orderLineCollection);
        orderCollection.SetThisOrder(newOrder);
        orderCollection.Add();

        orderLineCollection.Add(myShoppingCart, newOrder);
        lblError.Text = "Order created.";
    }

    private clsShoppingCart FetchShoppingCart()
    {
        clsShoppingCart shoppingCart = Session["ShoppingCart"] as clsShoppingCart;

        if (shoppingCart == null)
        {
            shoppingCart = new clsShoppingCart();
            shoppingCart.AddItem(new clsShoppingCartItem(55, 1, 1200.0f));
            shoppingCart.AddItem(new clsShoppingCartItem(56, 2, 600.0f));
        }

        return shoppingCart;
    }

    void DisplayShoppingCart()
    {
        clsShoppingCart myShoppingCart = FetchShoppingCart();
        clsOrderLineCollection orderLineCollection = new clsOrderLineCollection();

        lstShoppingCart.Items.Clear();
        int counter = 0;
        double runningTotal = 0;

        foreach (clsShoppingCartItem item in myShoppingCart.GetShoppingCart())
        {
            
            clsOrderLine newOrderLine = new clsOrderLine(item.ProductId, DateTime.Now, "Pending", item.Cost * item.Quantity, item.Quantity);
            orderLineCollection.AddOrderline(newOrderLine);

            string displayText = "Product ID: " + item.ProductId +
                                 " | Quantity: " + item.Quantity +
                                 " | Cost per unit: £" + item.Cost.ToString() +
                                 " | Total cost: £" + (item.Cost * item.Quantity).ToString();

            runningTotal = runningTotal + (item.Cost * item.Quantity);
            ListItem listItem = new ListItem(displayText, counter.ToString());
            lstShoppingCart.Items.Add(listItem);
            counter++;
        }

        lblGrandTotal.Text = "Grand Total: £" + runningTotal.ToString();
    }
}