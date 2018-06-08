using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MealOrders
{
    public partial class MealOrders : System.Web.UI.Page
    {
        public int counter = 0;
        //public List<Order> Orders = new List<Order>();

        protected void Page_Init(object sender, EventArgs e)
        {
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
            counter++;

            lblOrderNo.Text = counter + "";

            string[] cities = { "Montreal", "Laval", "Quebec", "Toronto" };

            ddlCity.DataSource = cities;
            ddlCity.DataBind();

            string[] gender = { "Male", "Female", "Others?" };

            ddlGender.DataSource = gender;
            ddlGender.DataBind();

            var mealOptions = new[]
            {
                new{ID=1, Name = "Potatos"},
                new{ID=2, Name = "Steak"},
                new{ID=3, Name = "Fish n Chips"},
                new{ID=4, Name = "Royale With Cheese"}
            };

            cblMeals.DataSource = mealOptions;
            cblMeals.DataBind();

            var paymentOptions = new[]
            {
                new{ID=1, Name = "Cash"},
                new{ID=2, Name = "Debit"},
                new{ID=3, Name = "Credit"},
                new{ID=4, Name = "BTC"}
            };

            rblPayment.DataSource = paymentOptions;
            rblPayment.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string mealOptions = "";

            foreach (ListItem item in cblMeals.Items)
            {
                if (item.Selected)
                {
                    mealOptions += item.Text + " ";
                }
            }

            var Order = "Order No: " + lblOrderNo.Text + " City: " + ddlCity.SelectedValue.ToString() + " Gender: " + ddlGender.SelectedValue.ToString()
                + " Meal Option(s): " + mealOptions + " Payment Option: " + rblPayment.SelectedItem.ToString();

            lstbOrders.Items.Add(Order);
        }

 
    }

  
}