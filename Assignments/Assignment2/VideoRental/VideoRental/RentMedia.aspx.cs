using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRental.Models;

namespace VideoRental
{
    public partial class RentMedia : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            btnRent.Visible = false;

            // page wont work without a customer id
            if (GetCustomerID() == 0)
            {
                Response.Redirect("Customers.aspx");
            }
        }

        protected void cblResult_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btnRent_Click(object sender, EventArgs e)
        {
            DbContextVideoRentalRepository repo = new DbContextVideoRentalRepository();

            List<int> selectedItems = new List<int>();
            List<Media> rentedMedia = new List<Media>();

            // get the value(s) of the selected items in the checkbox list (IDs)
            foreach (ListItem item in cblResult.Items)
                if (item.Selected) selectedItems.Add(Int32.Parse(item.Value));

            // get a list a Media objects with a selected ID
            foreach (int selecteditem in selectedItems)
            {               
                rentedMedia.Add(repo.GetMediaByID(selecteditem));
            }

            // add rental record for the specific customer
            int customerId = Int32.Parse(Request.QueryString["id".ToString()]);
            if (customerId != 0)
            {
                repo.AddRentalRecord(customerId, rentedMedia);

            }



        }

        protected int GetCustomerID()
        {
            return Int32.Parse(Request.QueryString["id".ToString()]);

        }

        protected void cblResult_DataBound(object sender, EventArgs e)
        {
            btnRent.Visible = true;

        }
    }
}