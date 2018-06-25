using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Exam1.BAL;

namespace Exam1
{
    public partial class SupplierSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlSuppliers.Items.Add("Please Selected A Supplier");
                ddlSuppliers.SelectedIndex = 0;
            }
        }

        protected void ddlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/NewProduct.aspx?SupplierID=" + ddlSuppliers.SelectedValue.ToString());
        }

        protected void btnSearchCity_Click(object sender, EventArgs e)
        {
            string cityName = txbCitySearch.Text;

            SupplierBAL bal = new SupplierBAL();
            
            if (bal.GetSuppliersByCity(cityName) == null)
            {
                Response.Write("No Records Found");
            }
            else
            {
                grdvSupplierByCity.AutoGenerateColumns = true;
                grdvSupplierByCity.AutoGenerateSelectButton = true;

                grdvSupplierByCity.DataSource = bal.GetSuppliersByCity(cityName);
                grdvSupplierByCity.DataBind();

                //grdvSupplierByCity.DataKeyNames = new string[] { "SupplierID" };

            }
            
            
            
        }

        protected void grdvSupplierByCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/NewProduct.aspx?SupplierID=" + grdvSupplierByCity.SelectedValue.ToString());
        }
    }
}