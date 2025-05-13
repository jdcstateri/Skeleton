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
            ////Set the private data members to the test data value
            //mStaffId = 21;
            //mStaffName = "John Doe";
            //mStaffEmail = "john@gmail.com";
            //mPassword = "12345678";
            //mIsAdmin = true;
            //mDateAdded = Convert.ToDateTime("25/12/2022");
            //mLastLogin = Convert.ToDateTime("25/12/2022");
            ////always return true
            //return true;

            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Staff id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAdmin"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mLastLogin = Convert.ToDateTime(DB.DataTable.Rows[0]["LastLogin"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                //if no record was found, return false
                return false;
            }
        }
    }
}