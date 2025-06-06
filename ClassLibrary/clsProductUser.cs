using System;
// Add this using directive at the top of your file
using System.Data;

// Removed System.IO; and Microsoft.VisualStudio.TestTools.UnitTesting; as they are not used within this class.

namespace ClassLibrary
{
    public class clsProductUser // Renamed to clsStaffUser in previous suggestions for clarity, but keeping original name as requested.
    {
        private Int32 mStaffID;
        private string mName;
        private string mEmail;
        private string mPassword;
        private bool mIsAdmin; // FIX: CRITICAL - This MUST be 'bool' to match the public property and DB BIT type.
        private DateTime mDateAdded;
        private DateTime mLastLogin;

        public int StaffID
        {
            get { return mStaffID; }
            set { mStaffID = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public bool IsAdmin // FIX: CRITICAL - Public property type is already 'bool', which is correct for DB BIT type.
        {
            get { return mIsAdmin; }
            set { mIsAdmin = value; }
        }

        public DateTime DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }

        public DateTime LastLogin
        {
            get { return mLastLogin; }
            set { mLastLogin = value; }
        }

        public bool FindUser(string Email, string Password)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Email", Email);
            DB.AddParameter("@Password", Password); // FIX: Added missing '@' before Password

            // Stored Procedure name seems to be correct based on your previous messages.
            DB.Execute("sproc_tblProductsUsers_FindUserNamePW");

            // Recommended to use DB.Count for consistency with clsDataConnection abstraction.
            // Using DB.DataTable.Rows.Count == 1 is functionally equivalent if DB.Count works.
            if (DB.Count == 1) // FIX: Changed back to DB.Count for consistency/preferred abstraction
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAdmin"]); // Corrected to Convert.ToBoolean
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mLastLogin = Convert.ToDateTime(DB.DataTable.Rows[0]["LastLogin"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}