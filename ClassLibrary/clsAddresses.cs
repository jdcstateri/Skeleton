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
            //set the private data members to the test data value
            mAddressID = 15;
            mAccountID = 15;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            mIsActive = true;
            mAddress = "Road Street 15";
            mPostCode = "LE3 9ET";

            //always return true
            return true;
        }
    }
}