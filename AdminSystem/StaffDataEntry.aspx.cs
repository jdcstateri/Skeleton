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
        string StaffId = txtStaffID.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        string DateAdded = txtDateAdded.Text;
        string LastLogin = txtLastLogin.Text;   
        string IsAdmin = ChkAdmin.Text;

        string Error = "";
        //valdiate the data
        Error = AStaff.Valid(Name, Email, Password, DateAdded);
        //if there is no error
        if (Error == "")
        {
            AStaff.StaffId = Convert.ToInt32(txtStaffID.Text);
            AStaff.Name = Name;
            AStaff.Email = Email;
            AStaff.Password = Password;
            AStaff.DateAdded = Convert.ToDateTime(DateTime.Now);
            AStaff.LastLogin = DateTime.Now;
            AStaff.IsAdmin = ChkAdmin.Checked;
            //Store the ID Session Object
            Session["AStaff"] = AStaff;

            //Navigate to the Staff Viewer Page
            Response.Redirect("StaffViewer.aspx");

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

        //get the primary enetered by the user
        StaffId = Convert.ToInt32(txtStaffID.Text);

        //find the record
        Found = AStaff.Find(StaffId);

        //if found
        if (Found == true)
        {
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
    }
}