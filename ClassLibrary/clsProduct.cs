using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public int ItemID { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public float Price { get; set; }
        public int StockNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsPublished { get; set; }
    }
}
