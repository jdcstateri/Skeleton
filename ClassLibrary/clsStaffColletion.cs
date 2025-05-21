using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary
{
    public class clsStaffColletion
    {

        //Private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //Private data member for the thisStaff property
        clsStaff mThisStaff = new clsStaff();

        //Public property for the staff list
        public clsStaff ThisStaff
        {
            get
            {
                //Return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

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
        public int Add()
        {
            //Adds a new record to the database based on the values of thisStaff
            //Connect the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@LastLogin", mThisStaff.LastLogin);
            //Execute the stored procedure
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public int Update()
        {
            //update an existing record based on the values of thisStaff
            //Connect the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@LastLogin", mThisStaff.LastLogin);
            //Execute the stored procedure
            return DB.Execute("sproc_tblStaff_Update");
        }

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