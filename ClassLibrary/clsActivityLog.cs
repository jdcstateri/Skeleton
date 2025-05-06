using System;

namespace ClassLibrary
{
    public class clsActivityLog
    {
        public int UserID { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Detail { get; set; }
    }
}