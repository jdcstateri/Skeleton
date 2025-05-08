using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public bool IsAdmin { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime DateAdded { get; set; }
    }
}