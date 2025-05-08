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
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AStaff"];
        Response.Write(AStaff.StaffId);
        Response.Write(AStaff.Name);
        Response.Write(AStaff.Email);
        Response.Write(AStaff.Password);
        Response.Write(AStaff.DateAdded);
        Response.Write(AStaff.LastLogin);
        Response.Write(AStaff.IsAdmin);

        //Following for the Activity Log page
        clsActivityLog AnActivityLog = new clsActivityLog();
        AnActivityLog = (clsActivityLog)Session["AnActivityLog"];
        Response.Write(AnActivityLog.ActivityID);
        Response.Write(AnActivityLog.UserID);
        Response.Write(AnActivityLog.Action);
        Response.Write(AnActivityLog.TimeStamp);
        Response.Write(AnActivityLog.Detail);
    }
}