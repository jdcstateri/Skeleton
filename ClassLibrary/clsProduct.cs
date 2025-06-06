using System;
using System.Collections.Generic; // You'll need this if you switch to List<string> but not for this specific fix.

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
            get { return itemID; }
            set { itemID = value; }
        }

        public string ProductTitle
        {
            get { return productTitle; }
            set { productTitle = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int StockNumber
        {
            get { return stockNumber; }
            set { stockNumber = value; }
        }

        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }

        public bool IsPublished
        {
            get { return isPublished; }
            set { isPublished = value; }
        }

        public bool Find(int ItemID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the ItemID to search for
            DB.AddParameter("@ItemID", ItemID);
            // execute the stored procedure
            DB.Execute("sproc_tblProducts_FilterByItemID");
            // if one record is found (should be 0 or 1)
            if (DB.Count == 1)
            {
                // copy data from database to class fields
                this.ItemID = Convert.ToInt32(DB.DataTable.Rows[0]["ItemID"]);
                this.ProductTitle = Convert.ToString(DB.DataTable.Rows[0]["ProductTitle"]);
                this.ProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                this.Price = Convert.ToSingle(DB.DataTable.Rows[0]["Price"]);
                this.StockNumber = Convert.ToInt32(DB.DataTable.Rows[0]["StockNumber"]);
                this.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                this.IsPublished = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPublished"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string productTitle, string productDescription, string price, string stockNumber, string dateAdded, string isPublished)
        {
            // create a string variable to store the error message
            String Error = "";

            // # 1 If the product title is blank
            if (productTitle.Length == 0)
            {
                // record the error
                Error = Error + "The product title may not be blank.<br />"; // Changed to <br />
            }
            // If the product title is greater than 50 characters
            if (productTitle.Length > 50)
            {
                // record the error
                Error = Error + "The product title must be less than 50 characters.<br />"; // Changed to <br />
            }
            // # 2 If the product description is blank
            if (productDescription.Length == 0)
            {
                Error += "The product description may not be blank.<br />"; // Changed to <br />
            }
            else if (productDescription.Length > 250)
            {
                Error += "The product description cannot exceed 250 characters.<br />"; // Changed to <br />
            }

            // # 3 Price should not be blank, numeric, and greater than 0, max 8 digits
            if (price.Length == 0)
            {
                // record the error
                Error += "The price may not be blank.<br />"; // Changed to <br />
            }
            else if (!decimal.TryParse(price, out decimal dP))
            {
                Error += "The price must be a number.<br />"; // Changed to <br />
            }
            else
            {
                if (dP < 1m)
                {
                    // record the error
                    Error += "The price must be at least 1.<br />"; // Changed to <br />
                }
                // Check if price string (before parsing) is too long for perceived '8 digits'
                // Note: This check should be careful. "12345.67" is 8 characters but only 7 digits.
                // It might be better to check parsed decimal's precision or number of digits.
                // Assuming you mean string length including decimal points.
                if (price.Length > 8)
                {
                    // record the error
                    Error += "The price string must be less than 8 characters.<br />"; // Changed to <br />
                }
            }

            // # 4 Stock number should not be blank, non-numeric, < 1, > 8 digits
            if (stockNumber.Length == 0)
            {
                // record the error
                Error += "The stock number may not be blank.<br />"; // Changed to <br />
            }
            else if (!int.TryParse(stockNumber, out int dSN))
            {
                Error += "The stock number must be a whole number.<br />"; // Changed to <br />
            }
            else
            {
                if (dSN < 1)
                {
                    // record the error
                    Error += "The stock number must be at least 1.<br />"; // Changed to <br />
                }
                // Again, this is checking string length, not numerical value magnitude.
                if (stockNumber.Length > 8)
                {
                    // record the error
                    Error += "The stock number string must be less than 8 characters.<br />"; // Changed to <br />
                }
            }

            // #5 DATE ADDED (valid, not ≥100 years ago, not >100 years in future)
            if (!DateTime.TryParse(dateAdded, out DateTime DateTemp))
            {
                // not even a date
                Error += "The date added is not a valid date.<br />"; // Changed to <br />
            }
            else
            {
                DateTime today = DateTime.Now.Date;
                DateTime lower = today.AddYears(-100);
                DateTime upper = today.AddYears(100);

                // exactly 100 years ago or earlier → fail Extrememin & MinLessOne
                if (DateTemp <= lower)
                {
                    Error += "The date added cannot be more than 100 years ago.<br />"; // Changed to <br />
                }
                // beyond 100 years in the future → fail ExtremeMax & MaxPlusOne
                if (DateTemp >= upper)
                {
                    Error += "The date added cannot be more than 100 years in the future.<br />"; // Changed to <br />
                }
            }

            // return any error messages
            return Error;
        }
    }
}