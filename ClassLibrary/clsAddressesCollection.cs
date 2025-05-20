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

        public clsAddressesCollection()
        {
            //variable for the Index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAddresses_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to proccess
            while (Index < RecordCount)
            {
                //create a blank object
                clsAddresses aAddress = new clsAddresses();
                //read in the fields for the current record
                aAddress.AddressID = Convert.ToInt32(DB.DataTable.Rows[Index]["AddressID"]);
                aAddress.AccountID = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountID"]);
                aAddress.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                aAddress.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                aAddress.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                aAddress.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                //add the record to the private data member
                mAddressesList.Add(aAddress);
                //point at the next record
                Index++;
            }
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

    }
}