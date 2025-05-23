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

        void PopulateArray(clsDataConnection DB)
        {
            //Populates the array list based on the data table in the parameter DB
            Int32 Index = 0;

            //variable to store the count
            Int32 RecordCount;

            //Get the count of records
            RecordCount = DB.Count;

            //clear the private array list
            mStaffList = new List<clsStaff>();

            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AStaff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAdmin"]);
                AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStaff.LastLogin = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastLogin"]);
                //Add the record to the private data member
                mStaffList.Add(AStaff);
                //Point at the next record
                Index++;
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
            DB.AddParameter("@Staff_Id", mThisStaff.StaffId);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@LastLogin", mThisStaff.LastLogin);
            //Execute the stored procedure
            return DB.Execute("sproc_tblStaff_Update");
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
    }
}