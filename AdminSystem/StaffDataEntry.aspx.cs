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
 
        //Store the ID Session Object
        Session["AStaff"] = AStaff;

        //Navigate to the Staff Viewer Page
        Response.Redirect("StaffViewer.aspx");
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