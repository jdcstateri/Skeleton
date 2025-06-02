using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Redirect if not logged in or not admin
        if (Session["IsAdmin"] == null || !(bool)Session["IsAdmin"])
        {
            Response.Redirect("StaffLogin.aspx");
        }

        if (!IsPostBack)
        {
            DisplayActivityLogs();
        }
    }

    void DisplayActivityLogs()
    {
        clsActivityLogCollection ActivityLogCollection = new clsActivityLogCollection();
        lstActivityLogList.Items.Clear();
        for (int i = 0; i < ActivityLogCollection.Count; i++)
        {
            clsActivityLog activityLog = ActivityLogCollection.ActivityLogList[i];
            string StaffName = !string.IsNullOrEmpty(activityLog.StaffName) ? activityLog.StaffName : "Unknown Staff";
            
            string displayText = "ID: " + activityLog.ActivityId
                               + " | Staff: " + StaffName
                               + " | Action: " + activityLog.Action;
            ListItem item = new ListItem(displayText, activityLog.ActivityId.ToString());
            lstActivityLogList.Items.Add(item);
        }
    }

    protected void BtnView_Click(object sender, EventArgs e)
    {
        if (lstActivityLogList.SelectedIndex != -1)
        {
            // Get the selected Activity ID
            int selectedActivityId = Convert.ToInt32(lstActivityLogList.SelectedValue);

            // Store it in session for the DataEntry page
            Session["ActivityID"] = selectedActivityId;

            // Redirect to the detail view page
            Response.Redirect("ActivityLogDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select an Activity Log to view.";
        }
    }
}
