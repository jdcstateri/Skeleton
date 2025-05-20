using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {

        // constructor for the class
        public clsProductCollection()
        {
            // variable for the index
            Int32 Index = 0;
            //variable for the record count
            Int32 RecordCount = 0;
            // onject for the data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblProducts_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank product
                clsProduct AnProduct = new clsProduct();
                //read in the fields for the record
                AnProduct.ItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemID"]);
                AnProduct.ProductTitle = Convert.ToString(DB.DataTable.Rows[Index]["ProductTitle"]);
                AnProduct.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AnProduct.Price = Convert.ToSingle(DB.DataTable.Rows[Index]["Price"]);
                AnProduct.StockNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["StockNumber"]);
                AnProduct.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnProduct.IsPublished = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPublished"]);
                // add the record to the private data member
                mProductList.Add(AnProduct);
                // point to the next record
                Index++;
            }
        }
        // private data member for the product list
        public List<clsProduct> mProductList
        {
            get
            {
                // return the private data
                return mProductList;
            }
            set
            {
                // set the private data
                mProductList = value;
            }
        }
        public int Count
        {
            get
            {
                // return the count of the list
                return mProductList.Count;
            }
            set
            {
                // do nothing
            }
        }
        public clsProduct ThisProduct { get; set; }
    }
}