using System;


namespace ClassLibrary
{
    public class clsProduct
    {
        // private data member for itemID
        private Int32 itemID;
        // private data member for product title
        private string productTitle;
        // private data member for product description
        private string productDescription;
        // private data member for price
        private float price;
        // private data member for stock number
        private int stockNumber;
        // private data member for date added
        private DateTime dateAdded;
        // private data member for is published
        private bool isPublished;


        public Int32 ItemID 
        {
            get 
            {
                // This line of code sends the data out of the property
                return itemID;
            }
            // This line of code allows the data to be entered in property
            set
            {
                itemID = value;
            }
        }
        public string ProductTitle 
        {
            get
            {
                return productTitle;
            }
            set
            {
                productTitle = value;
            }
        }
        public string ProductDescription 
        {
            get
            {
                return productDescription;
            }
            set
            {
                productDescription = value;
            }
        }
        public float Price 
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int StockNumber 
        {
            get
            {
                return stockNumber;
            }
            set
            {
                stockNumber = value;
            }
        }
        public DateTime DateAdded 
        {
            get
            {
                return dateAdded;
            }
            set
            {
                dateAdded = value;
            }
        }
        public bool IsPublished 
        {
            get
            {
                return isPublished;
            }
            set
            {
                isPublished = value;
            }
        }

        
        public bool Find(int ItemID)
        {
            // test data
            itemID = 21;
            productTitle = "Gaming Desktop";
            ProductDescription = "High-end gaming desktop";
            Price = 1299.99f;
            StockNumber = 10;
            DateAdded = Convert.ToDateTime("01/01/2023");
            IsPublished = true;

            // always return true for now
            return true;
        }

        public string Valid(string productTitle, string productDescription, string price, string stockNumber, string dateAdded, string isPublished)
        {
            // create a string variable to store the error message
            String Error = "";
            // create a temporary variable to store the date values.
            DateTime DateTemp;
            // If the product title is blank
            if (productTitle.Length == 0)
            {
                // record the error 
                Error = Error + "The product title may not be blank : ";
            }
            // If the product title is greater than 50 characters
            if (productTitle.Length > 50)
            {
                // record the error 
                Error = Error + "The product title must be less 50 : ";
            }
            // copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(dateAdded);
            //check to see if the date is less than today's date
            if (DateTemp < DateTime.Now.Date)
            {
                // record the error 
                Error = Error + "The date added cannot be in the past : ";
            }
            // return any error messages
            return Error;
        }
    }
}
