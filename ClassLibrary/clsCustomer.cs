using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mAccountID;
        private DateTime mDateRegistered;
        private bool mIsVerified;
        private string mName;
        private string mEmail;
        private string mPassword;

        public bool IsVerified
        {
            get
            {
                //this line of code sends data out of the property
                return mIsVerified;
            }
            set
            {
                //this line of code sends data into the property
                mIsVerified = value;
            }
        }
        public int AccountID 
        { 
            get
            {
                //this line of code sends data out of the property
                return mAccountID;
            }
            set
            {
                //this line of code sends data into the property
                mAccountID = value;
            }
        }
        public string Name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code sends data into the property
                mName = value;
            }
        }
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code sends data into the property
                mEmail = value;
            }
        }
        public string Password
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code sends data into the property
                mPassword = value;
            }
        }
        public DateTime DateRegistered
        {
            get
            {
                //this line of code sends data out of the property
                return mDateRegistered;
            }
            set
            {
                //this line of code sends data into the property
                mDateRegistered = value;
            }
        }

        public bool Find(int accountID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the id to search for
            DB.AddParameter("@AccountID", accountID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByAccoundID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAccountID = Convert.ToInt32(DB.DataTable.Rows[0]["AccountID"]);
                mDateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRegistered"]);
                mIsVerified = Convert.ToBoolean(DB.DataTable.Rows[0]["IsVerified"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {

                //return false indicating there is a problem
                return false;
            }
        }
    }
}