using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRental.Models;

namespace VideoRental
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DbContextVideoRentalRepository repo = new DbContextVideoRentalRepository();
            Customer customer = new Customer()
            {
                FirstName = txbFirstName.Text,
                LastName = txbLastName.Text,
                Phone = txbPhone.Text,
                Address = txbAddress.Text
            };

            repo.AddNewCustomer(customer);

            Response.Redirect("Default.aspx");
        }
    }
}