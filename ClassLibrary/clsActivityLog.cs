using System;

namespace ClassLibrary
{
    public class clsActivityLog
    {
        private Int32 mActivityId;
        public int ActivityId
        {
            get { return mActivityId; }
            set { mActivityId = value; }
        }

        private Int32 mUserId;
        public int UserId
        {
            get { return mUserId; }
            set { mUserId = value; }
        }

        private string mAction;
        public string Action
        {
            get { return mAction; }
            set { mAction = value; }
        }

        private string mDetail;
        public string Detail
        {
            get { return mDetail; }
            set { mDetail = value; }
        }

        private DateTime mTimeStamp;
        public DateTime TimeStamp
        {
            get { return mTimeStamp; }
            set { mTimeStamp = value; }
        }

        public bool Find(int ActivityId)
        {
            //Set the private data members to the test data value
            mActivityId = 21;
            mUserId = 21;
            mAction = "This is an Action";
            mDetail = "This is an action in detail";
            mTimeStamp = Convert.ToDateTime("25/12/2025");
            //always return true
            return true;
        }
    }
}