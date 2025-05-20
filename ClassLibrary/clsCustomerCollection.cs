using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public clsCustomerCollection()
        {
            //variable for the Index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to proccess
            while (Index < RecordCount)
            {
                //create a blank object
                clsCustomer aCustomer = new clsCustomer();
                //read in the fields for the current record
                aCustomer.AccountID = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountID"]);
                aCustomer.IsVerified = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsVerified"]); 
                aCustomer.DateRegistered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateRegistered"]);
                aCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                aCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                aCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the record to the private data member
                mCustomerList.Add(aCustomer);
                //point at the next record
                Index++;
            }
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
        public clsCustomer ThisCustomer { get; set; }
    }
}