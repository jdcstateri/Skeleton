using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Redirect if not logged in or not admin
        if (Session["IsAdmin"] == null || !(bool)Session["IsAdmin"])
        {
            Response.Redirect("StaffLogin.aspx");
        }

        //get the number of the staff to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);

        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    //Navigate to the Staff View Page
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        //Capture the Staff
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        string DateAdded = txtDateAdded.Text;
        string LastLogin = txtLastLogin.Text;
        string IsAdmin = ChkAdmin.Text;

        string Error = "";
        //validate the data
        Error = AStaff.Valid(Name, Email, Password, DateAdded);
        //if there is no error
        if (Error == "")
        {
            AStaff.StaffId = StaffID;
            AStaff.Name = Name;
            AStaff.Email = Email;
            AStaff.Password = Password;
            AStaff.DateAdded = Convert.ToDateTime(DateTime.Now);
            AStaff.LastLogin = DateTime.Now;
            AStaff.IsAdmin = ChkAdmin.Checked;

            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //CRITICAL FIX: Set the current user BEFORE setting ThisStaff
            //This ensures the logging has the correct user context
            StaffList.CurrentUserId = Convert.ToInt32(Session["StaffID"]);

            if (StaffID == -1) //if it's a new record
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //Otherwise it must be an update   
            else
            {
                //CRITICAL FIX: Don't call Find again, just set the staff data
                //The Find call was unnecessary and potentially problematic
                StaffList.ThisStaff = AStaff;
                //Update the record
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();

        //create the variable to store the primary key
        Int32 StaffId;

        //create a variable to store the results of the find operation
        Boolean Found = false;

        //get the primary entered by the user
        StaffId = Convert.ToInt32(txtStaffID.Text);

        //find the record
        Found = AStaff.Find(StaffId);

        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffID.Text = AStaff.StaffId.ToString();
            txtName.Text = AStaff.Name;
            txtEmail.Text = AStaff.Email;
            txtPassword.Text = AStaff.Password;
            txtDateAdded.Text = AStaff.DateAdded.ToString();
            txtLastLogin.Text = AStaff.LastLogin.ToString();
            ChkAdmin.Checked = AStaff.IsAdmin;
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    void DisplayStaff()
    {
        //create an instance of the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();
        //Find the record to be updated
        Staff.ThisStaff.Find(StaffID);
        //display the data for the record
        txtStaffID.Text = Staff.ThisStaff.StaffId.ToString();
        txtName.Text = Staff.ThisStaff.Name;
        txtEmail.Text = Staff.ThisStaff.Email;
        txtPassword.Text = Staff.ThisStaff.Password;
        txtDateAdded.Text = Staff.ThisStaff.DateAdded.ToString();
        txtLastLogin.Text = Staff.ThisStaff.LastLogin.ToString();
        ChkAdmin.Checked = Staff.ThisStaff.IsAdmin;
    }
}