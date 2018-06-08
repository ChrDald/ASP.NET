using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] answers = { "A", "B", "C", "D" };

                // define the data source, in this case the array above
                ddlAnswers.DataSource = answers;

                // call the DataBind() method to bind the data
                ddlAnswers.DataBind();

                // second data source multi dimensional array
                var towns = new[]
                {
                    new{ID=1, Name = "Montreal"},
                    new{ID=2, Name = "Potato"},
                    new{ID=3, Name = "New York"},
                    new{ID=4, Name = "Toronto"},
                    new{ID=5, Name = "Quebec"},
                };

                lstbTowns.DataSource = towns;
                lstbTowns.DataBind();

                // third data source using bulleted list - in the design view when you create the bulleted list change the datatextfield to Name and datavaluefield to url
                var searchEngines = new[]
                {
                    new{Name = "Google", URL = "http://www.google.ca"},
                    new{Name = "Bing", URL = "http://www.bing.com"},
                    new{Name = "Yahoo", URL = "http://www.google.ca"}
                };

                blSearchEngines.DataSource = searchEngines;
                blSearchEngines.DataBind();
            }
            
        }

        protected void ddlAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelection.Text = ddlAnswers.SelectedValue.ToString();
        }

        protected void ddlAnswers_DataBind(object sender, EventArgs e)
        {
            lblBindingEvent.Text = "Binding test";
        }

        protected void lstbTowns_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTownSelection.Text = lstbTowns.SelectedItem.ToString() + " id: " + lstbTowns.SelectedValue.ToString();
        }
    }
}