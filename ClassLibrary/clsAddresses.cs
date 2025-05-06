using System;

namespace ClassLibrary
{
    public class clsAddresses
    {
        public bool IsActive { get; set; }
        public DateTime DateAdded { get; set; }
        public int AddressID { get; set; }
        public int AccountID { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
    }
}