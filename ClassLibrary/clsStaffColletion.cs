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

        //Constructor for the class
        public clsStaffColletion()
        {

            //Object for the data connnect
            clsDataConnection DB = new clsDataConnection();

            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");

            //Populate the array
            PopulateArray(DB);

        }
        //Public property for the staff list
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

        private int mCurrentUserId;

        public int CurrentUserId
        {
            get { return mCurrentUserId; }
            set { mCurrentUserId = value; }
        }


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
            int newId = DB.Execute("sproc_tblStaff_Insert");

            // Log the action
            LogAction("CREATE", $"Added new staff: {mThisStaff.Name} (ID: {newId})");

            return newId;

        }

        public int Update()
        {
            //update an existing record based on the values of thisStaff
            //Connect the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffId);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@LastLogin", mThisStaff.LastLogin);
            //Execute the stored procedure
            int result = DB.Execute("sproc_tblStaff_Update");

            // Log the action
            LogAction("UPDATE", $"Updated staff ID: {mThisStaff.StaffId}");

            return result;


        }

        public void Delete()
        {
            //deletes the record pointed to by thisRecord
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("StaffID", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");

            // Log the action
            LogAction("DELETE", $"Deleted staff ID: {mThisStaff.StaffId}");
        }
         

        public void ReportByName(string Name)
        {
            //Filter the records based on a full partial post code
            clsDataConnection DB = new clsDataConnection();

            //send the name parameter to the databsae
            DB.AddParameter("@Name", Name);

            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByName");

            //Populate the Array
            PopulateArray(DB);
        }

        private void LogAction(string action, string details)
        {
            try
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@UserID", mCurrentUserId); // Correct user
                DB.AddParameter("@Action", action);
                DB.AddParameter("@TimeStamp", DateTime.Now);
                DB.AddParameter("@Details", details);
                DB.Execute("sproc_tblActivityLogs_Insert");
            }
            catch
            {
                // Optional: Log exception if needed
            }
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStaff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAdmin"]);
                AStaff.LastLogin = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastLogin"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at next record
                Index++;
            }
        }
    }
}