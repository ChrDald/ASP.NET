using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PriceQuote
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
  
            double salePrice = Double.Parse(tbPrice.Text);
            double discountPerc = Double.Parse(tbDiscountPerc.Text);

            lblDiscountAmount.Text = (salePrice * discountPerc / 100) + "";

            lblTotalPrice.Text = (salePrice - Double.Parse(lblDiscountAmount.Text)) + "";
        }
    }
}