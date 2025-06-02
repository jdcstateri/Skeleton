using System;
using ClassLibrary;

public partial class ActivityLogDataEntry : System.Web.UI.Page
{
    Int32 ActivityId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Redirect if not logged in or not admin
        if (Session["IsAdmin"] == null || !(bool)Session["IsAdmin"])
        {
            Response.Redirect("StaffLogin.aspx");
        }

        // Check if ActivityID is provided (either via Session or QueryString)
        if (Session["ActivityID"] != null)
        {
            ActivityId = Convert.ToInt32(Session["ActivityID"]);
        }
        else
        {
            lblError.Text = "No Activity selected.";
            return; // Exit early if no ID
        }

        if (!IsPostBack)
        {
            DisplayActivity();
        }
    }

    void DisplayActivity()
    {
        clsActivityLog activity = new clsActivityLog();

        bool found = activity.Find(ActivityId);

        if (found)
        {
            txtActivityId.Text = activity.ActivityId.ToString();
            txtUserId.Text = activity.UserId.ToString();
            txtAction.Text = activity.Action;
            txtDetail.Text = activity.Detail;
            txtTimeStamp.Text = activity.TimeStamp.ToString();
        }
        else
        {
            lblError.Text = "Activity record not found.";
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityLogList.aspx");
    }
}
