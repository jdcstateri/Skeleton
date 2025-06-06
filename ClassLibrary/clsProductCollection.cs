using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ClassLibrary
{
    public class clsProductCollection
    {
        // private data member for the product list
        List<clsProduct> mProductList = new List<clsProduct>();

       

        // private data memeber for the thisProduct
        clsProduct mThisProduct = new clsProduct();

        // constructor for the class
        public clsProductCollection()
        {
            // object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblProducts_SelectAll");
            // populate the array list with the data table in the DB variable
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populate the product list from the data table in the parameter DB
            // variable for the index
            Int32 Index = 0;
            // variable for the record count
            Int32 RecordCount = 0;
            // get the count of records
            RecordCount = DB.Count;
            // clear th private array list 
            mProductList = new List<clsProduct>();
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


        // property for the product list
        public List<clsProduct> ProductList
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

        public clsProduct ThisProduct
        {
            get
            {
                // return the private data member
                return mThisProduct;
            }
            set
            {
                // set the private data member
                mThisProduct = value;
            }
        }

        public int Add()
        {
            // adds a record to the database based on the values of ThisProduct
            // set a the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@ProductTitle", mThisProduct.ProductTitle);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@StockNumber", mThisProduct.StockNumber);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@IsPublished", mThisProduct.IsPublished);

            // execute the query returning the primary key value
            return DB.Execute("sproc_tblProduct_Insert");

        }
        public void Update()
        {
            //update an existing record based on the values of ThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@ItemID", mThisProduct.ItemID);
            DB.AddParameter("@ProductTitle", mThisProduct.ProductTitle);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@StockNumber", mThisProduct.StockNumber);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@IsPublished", mThisProduct.IsPublished);
            // execute the stored procedure
            DB.Execute("sproc_tblProducts_Update");
        }
        public void Delete()
        {
            // deletes the record pointed to by ThisProduct
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameter for the stored procedure
            DB.AddParameter("@ItemID", mThisProduct.ItemID);
            // execute the stored procedure
            DB.Execute("sproc_tblProducts_Delete");
        }

        public void ReportByProductTitle(string ProductTitle)
        {
            // filters the records based on a product title
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the product title parameter to the database
            DB.AddParameter("@ProductTitle", ProductTitle);
            // execute the stored procedure
            DB.Execute("sproc_tblProducts_FilterByProductTitle");
            // populate the product list with the data table in the DB variable
            PopulateArray(DB);
        }
      
    }

}