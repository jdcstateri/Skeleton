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
        //Following for the Activity Log page
        clsActivityLog AnActivityLog = new clsActivityLog();
        AnActivityLog = (clsActivityLog)Session["AnActivityLog"];
        Response.Write(AnActivityLog.ActivityId);
        Response.Write(AnActivityLog.UserId);
        Response.Write(AnActivityLog.Action);
        Response.Write(AnActivityLog.Detail);
        Response.Write(AnActivityLog.TimeStamp);
        
    }
}