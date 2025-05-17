using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary
{
    public class clsStaffColletion
    {

        //Private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList 
        {
            get
            {
                //Return the private date
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count 
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //Ammend later
            }
        }
        public clsStaff ThisStaff { get; set; }


        //Constructor for the class
        public clsStaffColletion()
        {
            //Variable for the index
            Int32 Index = 0;    

            //Variable to store the record count
            Int32 RecordCount = 0;

            //Object for the data connnect
            clsDataConnection DB = new clsDataConnection();

            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");

            //Get the counts for the records
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                //Create blank Staff
                clsStaff AStaff = new clsStaff();

                //Read in Field for the current records
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AStaff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAdmin"]);
                AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStaff.LastLogin = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastLogin"]);

                mStaffList.Add(AStaff);

                //Point at the next record
                Index++;
            }

        }
    }
}