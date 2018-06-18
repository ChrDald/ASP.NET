using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRental.Models;

namespace VideoRental
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnRent.Visible = false;
        }

        protected void grdvAllCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void dtlvCustomer_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        protected void dtlvCustomer_ItemCreated(object sender, EventArgs e)
        {
            btnRent.Visible = true;
        }

        protected void btnRent_Click(object sender, EventArgs e)
        {
            Response.Redirect("RentMedia.aspx?id=" + dtlvCustomer.SelectedValue);
        }
    }
}