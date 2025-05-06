using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool IsVerified { get; set; }
        public int AccountID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}