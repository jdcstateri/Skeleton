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
            DB.Execute("sproc_tblProduct_FilterByItemID");
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
    }
}
