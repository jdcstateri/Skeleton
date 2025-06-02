using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsActivityLogCollection
    {
        private List<clsActivityLog> mActivityLogList = new List<clsActivityLog>();
        private clsActivityLog mThisActivityLog = new clsActivityLog();

        public clsActivityLogCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblActivityLogs_SelectAll");
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            mActivityLogList = new List<clsActivityLog>();

            for (int i = 0; i < DB.Count; i++)
            {
                clsActivityLog log = new clsActivityLog
                {
                    ActivityId = Convert.ToInt32(DB.DataTable.Rows[i]["ActivityID"]),
                    UserId = Convert.ToInt32(DB.DataTable.Rows[i]["UserID"]),
                    Action = Convert.ToString(DB.DataTable.Rows[i]["Action"]),
                    TimeStamp = Convert.ToDateTime(DB.DataTable.Rows[i]["TimeStamp"]),
                    Detail = Convert.ToString(DB.DataTable.Rows[i]["Details"])
                };

                // Optional: populate StaffName if returned by SP/view
                if (DB.DataTable.Columns.Contains("Name"))
                {
                    log.StaffName = Convert.ToString(DB.DataTable.Rows[i]["Name"]);
                }

                mActivityLogList.Add(log);
            }
        }

        public List<clsActivityLog> ActivityLogList
        {
            get { return mActivityLogList; }
            set { mActivityLogList = value; }
        }

        public int Count => mActivityLogList.Count;

        public clsActivityLog ThisActivityLog
        {
            get { return mThisActivityLog; }
            set { mThisActivityLog = value; }
        }

        // Search/filter by Action text (partial or full)
        public void ReportByAction(string action)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Action", action);
            DB.Execute("sproc_tblActivityLog_FilterByAction");
            PopulateArray(DB);
        }
    }
}
