using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Uzytkownik
{
    public partial class KlientOddaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var q = Session["Id"];
            WypożyczalniaApi api = new WypożyczalniaApi();
            gvSprzet.DataSource = api.GetWydarzenie(Convert.ToInt32(q));
            gvSprzet.DataBind();
        }

        protected void wypozyczbt_Click(object sender, EventArgs e)
        {
            var Ids = Convert.ToInt32( TxtId.Text);
            WypożyczalniaApi api1 = new WypożyczalniaApi();
            api1.OddajWypo(Ids);
            Response.Redirect("~/Strony/Uzytkownik/KlientAktualne.aspx");
        }
    }
}