using System;

namespace ClassLibrary
{
    public class clsStaffUser
    {
        //private data member for the staff ID
        private Int32 mStaffID;
        //private data member for the email
        private string mEmail;
        //private data member for the password
        private string mPassword;
        //public property for the staff ID

        public clsStaffUser()
        {

        }

        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public bool FindUser(string email, string password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the email
            DB.AddParameter("@Email", email);
            //add the parameter for the password
            DB.AddParameter("@Password", password);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FindUserEmailPW");
            //if one record is found
            if (DB.Count == 1)
            {
                //get the staff ID
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                //get the email
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                //get the password
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //return true
                return true;
            }
            else
            {
                //return false
                return false;
            }
        }
    }
}