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
            // create and instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the address id to serach for
            DB.AddParameter("@ItemID", ItemID);
            // excute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByItemID");
            // one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //Copy the data from the database to private data members
                this.ItemID = Convert.ToInt32(DB.DataTable.Rows[0]["ItemID"]);
                this.ProductTitle = Convert.ToString(DB.DataTable.Rows[0]["ProductTitle"]);
                this.ProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                this.Price = Convert.ToSingle(DB.DataTable.Rows[0]["Price"]);
                this.StockNumber = Convert.ToInt32(DB.DataTable.Rows[0]["StockNumber"]);
                this.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                this.IsPublished = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPublished"]);
                //return that everything worked ok
                return true;
            }
            // if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}