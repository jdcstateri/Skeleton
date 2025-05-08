using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Navigate to the Staff View Page
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        //Capture the Staff
        AStaff.StaffId = Convert.ToInt32(txtStaffID.Text);
        AStaff.Name = txtName.Text;
        AStaff.Email = txtEmail.Text;
        AStaff.Password = txtPassword.Text;
        AStaff.DateAdded = Convert.ToDateTime(DateTime.Now);
        AStaff.LastLogin = Convert.ToDateTime(DateTime.Now);   
        AStaff.IsAdmin = ChkAdmin.Checked;

        //Capture Input for the Activity Logs
        clsActivityLog AnActivityLog = new clsActivityLog();
        AnActivityLog.ActivityID = Convert.ToInt32(txtActivityID.Text);
        AnActivityLog.UserID = Convert.ToInt32(txtUserID.Text);
        AnActivityLog.Action = txtAction.Text;
        AnActivityLog.TimeStamp = Convert.ToDateTime(DateTime.Now);
        
        //Store the ID Session Object
        Session["AStaff"] = AStaff;
        Session["AnActivityLog"] = AnActivityLog;

        //Navigate to the Staff Viewer Page
        Response.Redirect("StaffViewer.aspx");
    }

}