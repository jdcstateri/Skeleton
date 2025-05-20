using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsAddressesCollection
    {

        //private data member for the list
        List<clsAddresses> mAddressesList = new List<clsAddresses>();
        //private member data for this record
        clsAddresses mThisAddress = new clsAddresses();

        //constructor for the class
        public clsAddressesCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAddresses_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public List<clsAddresses> AddressesList
        {
            get
            {
                //return the private data
                return mAddressesList;
            }
            set
            {
                //set the private data
                mAddressesList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mAddressesList.Count;
            }
            set
            {
                //worry about it later

            }
        }
        public clsAddresses ThisAddress
        {
            get
            {
                //return the private data
                return mThisAddress;
            }
            set
            {
                //set the private data
                mThisAddress = value;

            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisRecord
            //connection to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedured
            DB.AddParameter("@AccountID", mThisAddress.AccountID);
            DB.AddParameter("@Address", mThisAddress.Address);
            DB.AddParameter("@PostCode", mThisAddress.PostCode);
            DB.AddParameter("@DateAdded", mThisAddress.DateAdded);
            DB.AddParameter("@IsActive", mThisAddress.IsActive);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAddresses_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisRecord
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("AddressID", mThisAddress.AddressID);
            //execute the stored procedure
            DB.Execute("sproc_tblAddresses_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisRecord
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@AddressID", mThisAddress.AddressID);
            DB.AddParameter("@AccountID", mThisAddress.AccountID);
            DB.AddParameter("@Address", mThisAddress.Address);
            DB.AddParameter("@PostCode", mThisAddress.PostCode);
            DB.AddParameter("@DateAdded", mThisAddress.DateAdded);
            DB.AddParameter("@IsActive", mThisAddress.IsActive);
            //execute the stored procedure
            DB.Execute("sproc_tblAddresses_Update");
        }

        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblAddresses_FilterByPostCode");
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
            mAddressesList = new List<clsAddresses>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsAddresses AnAddress = new clsAddresses();
                //read in the fields from the current record
                AnAddress.AddressID = Convert.ToInt32(DB.DataTable.Rows[Index]["AddressID"]);
                AnAddress.AccountID = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountID"]);
                AnAddress.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnAddress.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnAddress.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnAddress.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                //add the record to the private data member
                mAddressesList.Add(AnAddress);
                //point at next record
                Index++;
            }
        }
    }
}