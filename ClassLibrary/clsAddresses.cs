using System;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class clsAddresses
    {
        private Int32 mAddressID;
        private Int32 mAccountID;
        private DateTime mDateAdded;
        private bool mIsActive;
        private string mAddress;
        private string mPostCode;
        
        public bool IsActive
        {
            get
            {
                //this line of code sends data out of the property
                return mIsActive;
            }
            set
            {
                //this line of code sends data into the property
                mIsActive = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code sends data into the property
                mDateAdded = value;
            }
        }
        public int AddressID
        {
            get
            {
                //this line of code sends data out of the property
                return mAddressID;
            }
            set
            {
                //this line of code sends data into the property
                mAddressID = value;
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
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code sends data into the property
                mAddress = value;
            }
        }
        public string PostCode
        {
            get
            {
                //this line of code sends data out of the property
                return mPostCode;
            }
            set
            {
                //this line of code sends data into the property
                mPostCode = value;
            }
        }

        public bool Find(int addressID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the id to search for
            DB.AddParameter("@AddressID", addressID);
            //execute the stored procedure
            DB.Execute("sproc_tblAddresses_FilterByAddressID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAddressID = Convert.ToInt32(DB.DataTable.Rows[0]["AddressID"]);
                mAccountID = Convert.ToInt32(DB.DataTable.Rows[0]["AccountID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
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

        public string Valid(string dateAdded, string address, string postCode)
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

            //address
            //is blank
            if (address.Length == 0)
            {
                Error = Error + "The address must not be blank : ";
            }
            //is greater than 50 chars
            if (address.Length > 50)
            {
                Error = Error + "The address must be less than 50 characters : ";
            }
            //postcode
            //is blank
            if (postCode.Length == 0)
            {
                Error = Error + "The postCode must not be blank : ";
            }
            //is greater than 50 chars
            if (postCode.Length > 50)
            {
                Error = Error + "The postCode must be less than 50 characters : ";
            }


            //return any error messages
            return Error;
        }
    }

    
}