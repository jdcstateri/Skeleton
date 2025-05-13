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

        public string Valid(string name, string email, string password, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //create an instance of DateTime to compare to DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the DataAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);

                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is more than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //if name is blank
            if (name.Length == 0)
            {
                //record error
                Error = Error + "The name must not be blank : ";
            }
            //if name is greater than _ characters
            if (name.Length > 50)
            {
                //record error
                Error = Error + "The name must be less than 50 characters : ";
            }

            //if email is blank
            if (email.Length == 0)
            {
                //record error
                Error = Error + "The email must not be blank : ";
            }
            //if email is greater than _ characters
            if (email.Length > 50)
            {
                //record error
                Error = Error + "The email must be less than 50 characters : ";
            }

            //if password is blank
            if (password.Length == 0)
            {
                //record error
                Error = Error + "The password must not be blank : ";
            }
            //if password is greater than _ characters
            if (password.Length > 50)
            {
                //record error
                Error = Error + "The password must be less than 50 characters : ";
            }
            //return any errors messages
            return Error;
        }


    }
}