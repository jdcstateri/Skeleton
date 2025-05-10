using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Navigate to the Staff View Page
    protected void btnOK_Click(object sender, EventArgs e)
    {

        //Capture Input for the Activity Logs
        clsActivityLog AnActivityLog = new clsActivityLog();
        AnActivityLog.ActivityId = Convert.ToInt32(txtActivityId.Text);
        AnActivityLog.UserId = Convert.ToInt32(txtUserId.Text);
        AnActivityLog.Action = txtAction.Text;
        AnActivityLog.Detail = txtDetail.Text;
        AnActivityLog.TimeStamp = Convert.ToDateTime(DateTime.Now);

        Session["AnActivityLog"] = AnActivityLog;
        //Navigate to the Staff Viewer Page
        Response.Redirect("ActivityLogViewer.aspx");
    }

}