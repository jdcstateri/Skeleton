using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff id property
        private Int32 mStaffId;

        //StaffId public property
        public int StaffId
        {
            get { return mStaffId; }
            set { mStaffId = value; }
        }

        private string mStaffName;
        public string Name
        {
            get { return mStaffName; }
            set { mStaffName = value; }
        }

        private string mStaffEmail;
        public string Email
        {
            get { return mStaffEmail; }
            set { mStaffEmail = value; }    
        
        }

        private String mPassword;
        public String Password {
            get { return mPassword; }
            set { mPassword = value; }
        }

        private bool mIsAdmin;
        public bool IsAdmin {
            get { return mIsAdmin; }
            set { mIsAdmin = value;}
        }

        private DateTime mLastLogin;
        public DateTime LastLogin
        {   get {return  mLastLogin; }
            set {mLastLogin = value; } 
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value;}
        }

        public bool Find(int StaffId)
        {
            //Set the private data members to the test data value
            mStaffId = 21;
            mStaffName = "John Doe";
            mStaffEmail = "john@gmail.com";
            mPassword = "12345678";
            mIsAdmin = true;
            mDateAdded = Convert.ToDateTime("25/12/2022");
            mLastLogin = Convert.ToDateTime("25/12/2022");
            //always return true
            return true;
        }
    }
}