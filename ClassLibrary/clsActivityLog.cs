using System;

namespace ClassLibrary
{
    public class clsActivityLog
    {
        public int ActivityId { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public string Detail { get; set; }
        public DateTime TimeStamp { get; set; }

        // Add StaffName if available from DB or join
        public string StaffName { get; set; }

        // Display field for list UI
        public string DisplayField
        {
            get
            {
                return $"{TimeStamp:G} - {StaffName ?? "Unknown User"} - {Action}";
            }
        }

        // Find method to load details by ActivityId
        public bool Find(int activityId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ActivityID", activityId);
            DB.Execute("sproc_tblActivityLogs_FilterByActivityId");

            if (DB.Count == 1)
            {
                ActivityId = Convert.ToInt32(DB.DataTable.Rows[0]["ActivityID"]);
                UserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                Action = Convert.ToString(DB.DataTable.Rows[0]["Action"]);
                TimeStamp = Convert.ToDateTime(DB.DataTable.Rows[0]["TimeStamp"]);
                Detail = Convert.ToString(DB.DataTable.Rows[0]["Details"]);

                // Optional: If StaffName is returned by your stored procedure
                if (DB.DataTable.Columns.Contains("StaffName"))
                {
                    StaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                }
                else
                {
                    StaffName = "Unknown Staff";
                }


                    return true;
            }
            return false;
        }
    }
}
