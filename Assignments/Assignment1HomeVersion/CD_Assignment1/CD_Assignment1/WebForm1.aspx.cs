using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CD_Assignment1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            checkoutDisplayDiv.Visible = false;

            if (!Page.IsPostBack)
            {
                ddlState.Items.Add("Select a State");
                ddlShipState.Items.Add("Select a State");

                ddlState.SelectedIndex = 0;
                ddlShipState.SelectedIndex = 0;

                string[] states = { "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "GU", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MH", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "PR", "PW", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VI", "VT", "WA", "WI", "WV", "WY" };

                for (int i = 0; i < states.Length; i++)
                {
                    ddlState.Items.Add(states[i]);
                    ddlShipState.Items.Add(states[i]);


                }
            }
        }

        protected void chkbSameAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbSameAddress.Checked)
            {
                txbShipAddress.Enabled = false;
                txbShipCity.Enabled = false;
                txbShipZip.Enabled = false;
                ddlShipState.Enabled = false;

                reqfieldShipAddress.Enabled = false;
                reqfieldShipCity.Enabled = false;
                reqfieldShipZip.Enabled = false;
                regexpShipZip.Enabled = false;
                reqfieldShipState.Enabled = false;
            }
            else
            {
                txbShipAddress.Enabled = true;
                txbShipCity.Enabled = true;
                txbShipZip.Enabled = true;
                ddlShipState.Enabled = true;

                reqfieldShipAddress.Enabled = true;
                reqfieldShipCity.Enabled = true;
                reqfieldShipZip.Enabled = true;
                regexpShipZip.Enabled = true;
                reqfieldShipState.Enabled = true;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ddlState.SelectedIndex == 0 || (ddlShipState.SelectedIndex == 0 && ddlShipState.Enabled == true))
            {
                reqfieldShipState.IsValid = false;
                reqfieldState.IsValid = false;
            }
            else if (Page.IsValid)
            {
                lblEmail.Text = txbEmail.Text;
                lblFirstName.Text = txbFirstName.Text;
                lblLastName.Text = txbLastName.Text;
                lblPhone.Text = txbPhone.Text;

                // if the input is enabled then the shipping address is not the same as the billing address
                // so take the values from there
                if (txbShipAddress.Enabled == true)
                {
                    lblShipAddress.Text = txbShipAddress.Text;
                    lblShipCity.Text = txbShipCity.Text;
                    lblShipState.Text = ddlShipState.SelectedValue.ToString();
                    lblShipZip.Text = txbShipZip.Text;
                }
                // else shipping address is the same so take values of billing address
                else
                {
                    lblShipAddress.Text = txbAddress.Text;
                    lblShipCity.Text = txbCity.Text;
                    lblShipState.Text = ddlState.SelectedValue.ToString();
                    lblShipZip.Text = txbZip.Text;
                }

                checkoutDisplayDiv.Visible = true;
            }
            else return;
        }
    }
}