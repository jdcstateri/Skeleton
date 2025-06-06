using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayProducts();

            if (lblError.Visible == true)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "HideErrorOnLoad", "hideErrorAfterDelay();", true);
            }
        }
    }

    void DisplayProducts()
    {
        // create an instance of the product collection
        clsProductCollection ProductList = new clsProductCollection();

        // set the data source to the product list
        lstProductList.DataSource = ProductList.ProductList;
        // set the name of the primary key
        lstProductList.DataValueField = "ItemID";
        // set the data field to display
        lstProductList.DataTextField = "ProductTitle";
        // bind the data to the list
        lstProductList.DataBind();

       
        if (lblError.Text == "" || lstProductList.Items.Count > 0) // If no text or list populated
        {
            lblError.Visible = false;
        }
    }

    protected void btnAdd_Click_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate that this is a new record
        Session["ItemID"] = -1;
        // redirect to the data entry page
        Response.Redirect("ProductDataEntry.aspx");
    }

    protected void btn_Edit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 ItemID;
        // if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            // get the primary key value of the record to be edited
            ItemID = Convert.ToInt32(lstProductList.SelectedValue);
            // store the data in the session object
            Session["ItemID"] = ItemID;
            // redirect to the data entry page
            Response.Redirect("ProductDataEntry.aspx");
        }
        else
        {
            // display an error message
            lblError.Text = "Please select a record to edit from the list.";
            lblError.Visible = true; 
            
            ScriptManager.RegisterStartupScript(this, this.GetType(), "HideErrorEdit", "hideErrorAfterDelay();", true);
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 ItemID;
        // if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            // get the primary key value of the record to be deleted
            ItemID = Convert.ToInt32(lstProductList.SelectedValue);
            // store the data in the session object
            Session["ItemID"] = ItemID;
            // redirect to the delete page
            Response.Redirect("ProductConfirmDelete.aspx");
        }
        else
        {
            // display an error message
            lblError.Text = "Please select a record to delete from the list.";
            lblError.Visible = true; // Make it visible
            //the JavaScript is scheduled to hide it after delay
            ScriptManager.RegisterStartupScript(this, this.GetType(), "HideErrorDelete", "hideErrorAfterDelay();", true);
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // Check ito see if the user entered anything in the filter box.
        
        string filterText = txtFilter.Text.Trim(); // Get the text and remove extra spaces

        if (string.IsNullOrWhiteSpace(filterText))
        {
            // The filter box is empty, user will be infromed
            lblError.Text = "Please enter a Product Title or Letter to filter by.";
            lblError.Visible = true;
            // Hide the error message after a short delay using JavaScript.
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FilterEmptyInput", "hideErrorAfterDelay();", true);

      
            return;
        }

        // The user entered something, so let's filter 
        clsProductCollection ProductFilter = new clsProductCollection(); // Create a new product collection

        // Filter the collection based on what the user typed.
        ProductFilter.ReportByProductTitle(filterText);

        // Check if any products matched the filter.
        if (ProductFilter.ProductList.Count == 0)
        {
            // if no products were found infrom the user
            lblError.Text = "No products found matching your request '" + filterText + "'. Try a different search term!";
            lblError.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FilterNoResults", "hideErrorAfterDelay();", true);
        }
        else
        {
            // if Products were found,Hide any previous error messages.
            lblError.Visible = false;
            lblError.Text = "";
        }

        // Update the listbox with the filtered results.
        lstProductList.DataSource = ProductFilter.ProductList;
        lstProductList.DataValueField = "ItemID"; // Use ItemID as the value
        lstProductList.DataTextField = "ProductTitle"; // Show ProductTitle to the user
        lstProductList.DataBind(); 
    }


    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Check if the filter box is already empty.
        if (string.IsNullOrWhiteSpace(txtFilter.Text))
        {
            // inform the user if the filter is already clear
            lblError.Text = "The Filter is already clear.";
            lblError.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "FilterAlreadyClear", "hideErrorAfterDelay();", true);
            return; 
        }

        
        clsProductCollection AllProducts = new clsProductCollection(); //reterive all products

        // Show all products by removing the filter empty string = no filter
        AllProducts.ReportByProductTitle("");

        // Clear the filter text box
        txtFilter.Text = "";

        // Hide and clear any error messages
        lblError.Text = "";
        lblError.Visible = false;

        // Listbox refreshed to show all products
        lstProductList.DataSource = AllProducts.ProductList;
        lstProductList.DataValueField = "ItemID";
        lstProductList.DataTextField = "ProductTitle";
        lstProductList.DataBind();
    }





    protected void txtFilter_TextChanged(object sender, EventArgs e)
    {

    }
}
