using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["CustomerLogin"] = -1;
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Session["CustomerLogin"] = 1;
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnAddresses_Click(object sender, EventArgs e)
    {
        Session["CustomerLogin"] = 2;
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        //redirect it to your login page
        //Response.Redirect("example.aspx");
    }

    protected void btnActivityLog_Click(object sender, EventArgs e)
    {
        //redirect it to your login page
        //Response.Redirect("example.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLogin.aspx");
    }

    protected void btnProduct_Click(object sender, EventArgs e)
    {
        //redirect it to your login page
        //Response.Redirect("example.aspx");
    }
}