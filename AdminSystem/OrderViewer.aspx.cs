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
        string errorCode = "-1";

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
                string displayText = "Input an account ID to show an order";
                ListItem listItem = new ListItem(displayText, errorCode);
                lstOrders.Items.Add(listItem);
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
        lblError.Text = "";
        string errorCode = "-1";
        lstOrderLines.Items.Clear();

        if (string.IsNullOrEmpty(id))
        {
            lblError.Text = "Please enter an Account ID.";
            string displayText = "Input an account ID to show an order";
            ListItem listItem = new ListItem(displayText, errorCode);
            lstOrders.Items.Clear();
            lstOrders.Items.Add(listItem);
            return;
        }
        if (!Regex.IsMatch(id, "^[0-9]+$"))
        {
            lblError.Text = "Please enter a valid Account ID.";
            string displayText = "Input an account ID to show an order";
            lstOrders.Items.Clear();
            ListItem listItem = new ListItem(displayText, errorCode);
            lstOrders.Items.Add(listItem);
            return;
        }

        DisplayOrders(Convert.ToInt32(id));
    }

    protected void btnSearchForOrderLines_Click(object sender, System.EventArgs e)
    {
        if (lstOrders.SelectedIndex != -1)
        {
            int selectedOrderId = Convert.ToInt32(lstOrders.SelectedValue);

            DisplayOrderLines(selectedOrderId);
        }
        else
        {
            lblError.Text = "Please select an order to view its order lines.";
            return;
        }
    }

    protected void btnUpdateOrder_Click(object sender, System.EventArgs e)
    {
        clsOrder aOrder = new clsOrder();
        aOrder.SetDateOfDelivery(Convert.ToDateTime(txtDateOfDelivery.Text));
        aOrder.SetDelivered(Convert.ToBoolean(rblDelivered));
        aOrder.SetDeliveryInstructions(Convert.ToString(txtDeliveryInstructions));
        aOrder.SetOrderId(Convert.ToInt32(lstOrders.SelectedIndex));

        if (Session["StaffID"] != null)
        {
            aOrder.SetAccountId(Convert.ToInt32(txtAccountId.Text));
        }
        else if (Session["CustomerUser"] != null)
        {
            clsCustomer aCustomer = Session["CustomerUser"] as clsCustomer;

            aOrder.SetAccountId(aCustomer.AccountID);
        }
        else if (lstOrders.SelectedIndex == -1)
        {
            lblError.Text = "Order hasn't been selected for editing - No modifications to the order have been made";
            return;
        }
        else
        {
            lblError.Text = "Unknown Error - No modifications to the order have been made";
            return;
        }

        clsOrderCollection aOrderCollection = new clsOrderCollection();
        aOrderCollection.SetThisOrder(aOrder);
        aOrderCollection.Edit();
    }

    protected void btnDeleteOrder_Click(object sender, System.EventArgs e)
    {
        if (lstOrders.SelectedIndex != -1)
        {
            clsOrder aOrder = new clsOrder();
            clsOrderCollection aOrderCollection = new clsOrderCollection();
            aOrder.SetOrderId(lstOrders.SelectedIndex);
            aOrderCollection.SetThisOrder(aOrder);
            aOrderCollection.Delete();
        }
        else
        {
            lblError.Text = "Order hasn't been selected for deleting - No modifications to the order have been made";
            return;
        }
    }

    protected void btnUpdateOrderline_Click(object sender, System.EventArgs e)
    {

    }

    protected void btnDeleteOrderline_Click(object sender, System.EventArgs e)
    {

    }

    protected void DisplayOrders(int accountId)
    {
        clsCustomer aCustomer = Session["CustomerUser"] as clsCustomer;
        clsOrder anOrder = new clsOrder();

        clsOrderCollection orderCollection = anOrder.Find(accountId, "AccountId");

        string displayText = "";
        string errorCode = "-1";

        lstOrders.Items.Clear();

        if (orderCollection.count == 0)
        {
            displayText = "No orders found under this account ID";
            ListItem listItem = new ListItem(displayText, errorCode);
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

            ListItem listItem = new ListItem(displayText, order.GetOrderId().ToString());
            lstOrders.Items.Add(listItem);
        }
    }

    protected void DisplayOrderLines(int orderid)
    {
        clsCustomer aCustomer = Session["CustomerUser"] as clsCustomer;
        clsOrderLine anOrderLine = new clsOrderLine();

        clsOrderLineCollection orderLineCollection = anOrderLine.FindAll(orderid);

        string displayText = "";
        string errorCode = "-1";

        lstOrderLines.Items.Clear();
        
        if (orderLineCollection.GetCount() == 0)
        {
            displayText = "To see order lines, enter an account ID and select an order";
            ListItem listItem = new ListItem(displayText, errorCode);
            lstOrderLines.Items.Add(listItem);
            return;
        }

        foreach (clsOrderLine orderLine in orderLineCollection.GetOrderLines())
        {
            displayText = "Order ID: " + orderLine.GetOrderId() +
                     " | Item Id: " + orderLine.GetItemId() +
                     " | Date added: " + orderLine.GetDateAdded().ToString() +
                     " | Status: " + orderLine.GetStatus() +
                     " | Agreed Price: " + orderLine.GetAgreedPrice() + 
                     " | Quantity: " + orderLine.GetQuantity();

            ListItem listItem = new ListItem(displayText, orderLine.GetItemId().ToString());
            lstOrderLines.Items.Add(listItem);
        }
    }
}