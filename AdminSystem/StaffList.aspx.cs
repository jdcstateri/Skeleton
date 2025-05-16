using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            //update the listbox
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff Collection
        clsStaffColletion Staff = new clsStaffColletion();

        //set the data source to the list staff in the collectioj
        lstStaffList.DataSource = Staff.StaffList;

        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";

        //Set the data field to display
        lstStaffList.DataValueField = "Name";

        //Bind the data to the list
        lstStaffList.DataBind();
    }
}