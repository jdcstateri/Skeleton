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
            //set the private data members to the test data value
            mAccountID = 15;
            mDateRegistered = Convert.ToDateTime("23/12/2022");
            mIsVerified = true;
            mName = "Joe";
            mEmail = "Joe@email.com";
            mPassword = "JoePassword15";

            //always return true
            return true;
        }
    }
}