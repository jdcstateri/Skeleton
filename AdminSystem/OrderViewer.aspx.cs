using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["StaffID"] == null && Session["CustomerUser"] == null)
        {
            Response.Redirect("OrderLogin.aspx");
        }
        if (!IsPostBack)
        {
            if (Session["StaffID"] != null)
            {
                lblAccountId.Visible = true;
                txtAccountId.Visible = true;
                btnSearchByAccountId.Visible = true;
            }
            else
            {
                lblAccountId.Visible = false;
                txtAccountId.Visible = false;
                btnSearchByAccountId.Visible = false;
                clsCustomer aCustomer = Session["CustomerUser"] as clsCustomer; 
                DisplayOrders(aCustomer.AccountID);
            }
        }
    }

    protected void btnSearchOrderById_Click(object sender, System.EventArgs e)
    {
        string id = txtAccountId.Text;

        if (string.IsNullOrEmpty(id))
        {
            lblError.Text = "Please enter an Account ID.";
            return;
        }
        if (!Regex.IsMatch(id, "^[0-9]+$"))
        {
            lblError.Text = "Please enter a valid Account ID.";
            return;
        }

        DisplayOrders(Convert.ToInt32(id));
    }

    protected void DisplayOrders(int accountId)
    {
        clsCustomer aCustomer = Session["CustomerUser"] as clsCustomer;
        clsOrder anOrder = new clsOrder();

        clsOrderCollection orderCollection = anOrder.Find(accountId, "AccountId");

        int counter = 1;
        string displayText = "";

        lstOrders.Items.Clear();

        if (orderCollection.count == 0)
        {
            displayText = "No orders found under this account ID";
            ListItem listItem = new ListItem(displayText, counter.ToString());
            lstOrders.Items.Add(listItem); 
            return;
        }

        foreach (clsOrder order in orderCollection.GetOrderList())
        {
            displayText = "Order ID: " + order.GetOrderId() +
                     " | Account Id: " + order.GetAccountId() +
                     " | Date Of Delivery: " + order.GetDateOfDelivery().ToString() +
                     " | Order Delivered?: " + order.GetDelivered() +
                     " | Delivery Instuctions: " + order.GetDeliveryInstructions();

            ListItem listItem = new ListItem(displayText, counter.ToString());
            lstOrders.Items.Add(listItem);
            counter++;
        }
    }
}