using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            /*
            dlstProv.Items.Add("QC");
            dlstProv.Items.Add("ON");
            dlstProv.Items.Add("BC");
            dlstProv.Items.Add("AB");
            */
        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            
            if (Page.IsValid)
            {
                try
                {
                    if (dlstProv.SelectedIndex == 0 || dlstCity.SelectedIndex == 0)
                    {
                        return;
                    }

                    string name = tbName.Text;
                    string dob = tbDob.Text;
                    string email = tbEmail.Text;
                    string province = dlstProv.SelectedValue.ToString();
                    string city = dlstCity.SelectedValue.ToString();


                    lstbUsers.Items.Add(name + " dob: " + dob + " email: " + email + " province: " + province + " city: " + city);
                }
                catch (Exception)
                {
                    return;
                }
            }
            
            
        }

        protected void dlstProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            dlstCity.Items.Clear();
            dlstCity.Items.Add("Select a city");

            string choice = dlstProv.SelectedValue.ToString();
            
            switch (choice)
            {
                case "QC":
                    dlstCity.Items.Add("Montreal");
                    break;
                case "ON":
                    dlstCity.Items.Add("Toronto");
                    break;
                case "BC":
                    dlstCity.Items.Add("Vancouver");
                    break;
                case "AB":
                    dlstCity.Items.Add("Edmonton");
                    break;
                default:
                    break;
            }
            
        }

        protected void btClear_Click(object sender, EventArgs e)
        {
            //lstbUsers.Items.Clear();
            formClear();
        }

        private void formClear()
        {
            tbName.Text = "";
            tbDob.Text = "";
            tbEmail.Text = "";
            dlstProv.SelectedIndex = 0;
            dlstCity.Items.Clear();
            dlstCity.Items.Add("Select a city");
        }

    }
}