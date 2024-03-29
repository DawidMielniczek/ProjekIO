﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;
using WypożyczalniaSprzętuFilmowego.Dto;

namespace WypożyczalniaSprzętuFilmowego.Strony.Uzytkownik
{
    public partial class KlientWypo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            gvSprzet.DataSource = api.GetSprzetD();
            gvSprzet.DataBind();
        }

        protected void wypozyczbt_Click(object sender, EventArgs e)
        {
            var IdU = Convert.ToInt32( Session["Id"]);
            var IdS =Convert.ToInt32( TxtId.Text);
            WypożyczalniaApi api = new WypożyczalniaApi();
            api.AddWypo(IdU, IdS);
            Response.Redirect("~/Strony/Uzytkownik/KlientGlowna.aspx");
        }
    }
}