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
        public String Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        private bool mIsAdmin;
        public bool IsAdmin
        {
            get { return mIsAdmin; }
            set { mIsAdmin = value; }
        }

        private DateTime mLastLogin;
        public DateTime LastLogin
        {
            get { return mLastLogin; }
            set { mLastLogin = value; }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }

        public bool Find(int StaffId)
        {
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

     

            // -----Name Validations-----
            if (string.IsNullOrEmpty(name))
            {
                //record error
                Error = Error + "The name must not be blank : ";
            }
            if (name.Length < 2)
            {
                //record error
                Error = Error + "The name must not be less than 2 characters : ";
            }
            if (name.Length > 50)
            {
                //record error
                Error = Error + "The name must be less than 50 characters : ";
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                //record error
                Error = Error + "The name must only contain letters and spaces : ";
            }
            if (name.Contains("  ") || name.ToLower().Contains("drop table"))
            {
                //record error
                Error = Error + "The name contains SQL injection risk: "; ;
            }


            // -----Email Validations-----
            if (string.IsNullOrEmpty(email))
            {
                //record error
                Error = Error + "The email must not be blank : ";
            }
            if (email.Length > 50)
            {
                //record error
                Error = Error + "The email must be less than 50 characters : ";
            }
            if (!email.Contains("@") || !email.Contains(".") || email.StartsWith("@") || email.EndsWith("@"))
            {
                //record error
                Error = Error + "The email format is invalid: ";
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                //record error
                Error = Error + "The email is not in a valid format : ";
            }
            if (email.Contains("  ") || email.ToLower().Contains("drop table"))
            {
                //record error
                Error = Error + "The email contains SQL injection risk: "; ;
            }

            // -----Password Validations-----
            if (string.IsNullOrEmpty(password))
            {
                //record error
                Error = Error + "The password must not be blank : ";
            }
            if (password.Length < 8)
            {
                //record error
                Error = Error + "The password must be at least 8 characters : ";
            }
            if (password.Length > 50)
            {
                Error = Error + "The password must be less than 50 characters: ";

            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Z]"))
            {
                //record error
                Error = Error + "The password must contain at least one uppercase letter : ";
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[a-z]"))
            {
                //record error
                Error = Error + "The password must contain at least one lowercase letter : ";
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]"))
            {
                //record error
                Error = Error + "The password must contain at least one number : ";
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[\W_]"))
            {
                // record error
                Error = Error + "The password must contain at least one special character : ";
            }
            if (password.Contains(" "))
            {
                Error = Error + "The password must not contain spaces: ";

            }
            if (password.Contains("  ") || password.ToLower().Contains("drop table"))
            {
                //record error
                Error = Error + "The password contains SQL injection risk: "; ;
            }

            // -----Date Added Validations-----
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


            //return any errors messages
            return Error;
        }


    }
}