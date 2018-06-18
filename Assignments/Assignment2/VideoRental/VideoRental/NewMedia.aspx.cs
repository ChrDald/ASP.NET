using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoRental.Models;

namespace VideoRental
{
    public partial class NewMedia : System.Web.UI.Page
    {
        public enum Type { Movie, Series, VideoGame, Hardware }

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!Page.IsPostBack)
            {
                ddlType.Items.Add("Select a media type");
                ddlType.Items.Add(Type.Movie.ToString());
                ddlType.Items.Add(Type.Series.ToString());
                ddlType.Items.Add(Type.VideoGame.ToString());
                ddlType.Items.Add(Type.Hardware.ToString());

                ddlType.SelectedIndex = 0;
            }
            
        }

        protected void btnAddMedia_Click(object sender, EventArgs e)
        {
            DbContextVideoRentalRepository repo = new DbContextVideoRentalRepository();

            Media media = new Media()
            {
                Title = txbTitle.Text,
                ProductionYear = calProdYear.SelectedDate
            };

            repo.AddNewMedia(media);

            Response.Redirect("Default.aspx");
        }
    }
}