﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoSQLDataSource
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SQLdsUserSearch.SelectCommand = "SELECT * FROM[Customers] WHERE([" + ddlFieldSelect.SelectedValue + "] = @CustomerID)";
        }
    }
}