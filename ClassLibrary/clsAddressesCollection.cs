using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsAddressesCollection
    {

        //private data member for the list
        List<clsAddresses> mAddressesList = new List<clsAddresses>();

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
        public clsAddresses ThisAddress { get; set; }

    }
}