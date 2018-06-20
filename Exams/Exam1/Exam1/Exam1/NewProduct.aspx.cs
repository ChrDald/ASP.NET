using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam1
{
    public partial class NewProduct : System.Web.UI.Page
    {
        private string ConString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            btnReturn.Enabled = false;
            btnReturn.Visible = false;

            if (!Page.IsPostBack)
            {
                lblSupplierId.Text = Request.QueryString["SupplierID"];
            }
            
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // default value for testing
                if (lblSupplierId.Text == "")
                {
                    lblSupplierId.Text = "1";
                }

                // default values in case no input in non-required fields
                if (txbUnitPrice.Text == "")
                {
                    txbUnitPrice.Text = "0";
                }
                if (txbUnitsInStock.Text == "")
                {
                    txbUnitsInStock.Text = "0";
                }
                if (txbUnitsOnOrder.Text == "")
                {
                    txbUnitsOnOrder.Text = "0";
                }
                if (txbOrderLevel.Text == "")
                {
                    txbOrderLevel.Text = "0";
                }

                // parsing the string values to the approriate ones
                int supplierID = Int32.Parse(lblSupplierId.Text);
                int categoryID = Int32.Parse(ddlCategory.SelectedValue);
                double unitPrice = Double.Parse(txbUnitPrice.Text);
                int unitsInStock = Int32.Parse(txbUnitsInStock.Text);
                int unitsOnOrder = Int32.Parse(txbUnitsOnOrder.Text);
                int reorderLevel = Int32.Parse(txbOrderLevel.Text);

                bool discontinued = false;         
                if (chkbDiscontinued.Checked == true)
                {
                    discontinued = true;
                }
               

                Response.Write(InsertData(ConString, txbProdName.Text, supplierID, categoryID, txbQtyPerUnit.Text, unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discontinued));
                btnAddProduct.Enabled = false;

                // button to return to previous page
                btnReturn.Enabled = true;
                btnReturn.Visible = true;
                
            }
        }

        // ADO method to insert data, not the best class to have this method in but itll do
        private string InsertData(string connectionString, string productName, int supplierID, int categoryID, string quantityPerUnit, double unitPrice, int unitsInStock, 
                                int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            // define INSERT query with parameters
            string query = "INSERT INTO Products (productName, supplierID, categoryID, quantityPerUnit, unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discontinued) " +
                           "VALUES (@productName, @supplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)";

            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // define parameters and their values
                cmd.Parameters.Add("@productName", SqlDbType.VarChar, 50).Value = productName;
                cmd.Parameters.Add("@supplierID", SqlDbType.Int).Value = supplierID;
                cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = categoryID;
                cmd.Parameters.Add("@quantityPerUnit", SqlDbType.VarChar, 50).Value = quantityPerUnit;
                cmd.Parameters.Add("@unitPrice", SqlDbType.Decimal).Value = unitPrice;
                cmd.Parameters.Add("@unitsInStock", SqlDbType.Int).Value = unitsInStock;
                cmd.Parameters.Add("@unitsOnOrder", SqlDbType.Int).Value = unitsOnOrder;
                cmd.Parameters.Add("@reorderLevel", SqlDbType.Int).Value = reorderLevel;
                cmd.Parameters.Add("@discontinued", SqlDbType.Bit).Value = discontinued;

                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            return "Successesfully Added record to database";
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/SupplierSearch.aspx");
        }
    }
}