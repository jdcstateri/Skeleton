using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for this record
        clsCustomer mThisCustomer = new clsCustomer();

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {
                //worry about it later
                
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;

            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisRecord
            //connection to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedured
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateRegistered", mThisCustomer.DateRegistered);
            DB.AddParameter("@IsVerified", mThisCustomer.IsVerified);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisRecord
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("AccountID", mThisCustomer.AccountID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisRecord
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@AccountID", mThisCustomer.AccountID);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateRegistered", mThisCustomer.DateRegistered);
            DB.AddParameter("@IsVerified", mThisCustomer.IsVerified);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
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
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.AccountID = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountID"]);
                AnCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.DateRegistered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateRegistered"]);
                AnCustomer.IsVerified = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsVerified"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at next record
                Index++;
            }
        }
    }
}