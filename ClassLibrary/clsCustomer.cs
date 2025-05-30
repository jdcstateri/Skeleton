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

        public bool FindUser(string Email, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the id to search for
            DB.AddParameter("@Email", Email);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FindUserEmailPW");
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

        public bool RepeatedEmail(string email, int currentID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter ("@Email", email);

            if (currentID == -1)
            {
                //adding customer
                DB.Execute("sproc_tblCustomer_FilterByEmail");
            }
            else
            {
                //editing customer
                DB.AddParameter("@AccountID", currentID);
                DB.Execute("sproc_tblCustomer_RepeatedEmailExcludeID");
            }
            return DB.Count > 0;
        }

        public string Valid(string dateRegistered, string name, string email, string password, int currentID = -1)
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
                //copy the dateRegistered value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateRegistered);

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

            if (RepeatedEmail(email, currentID))
            {
                //record error
                Error = Error + "This email is already registered : ";
            }

            //return any error messages
            return Error;
        }
    }
}