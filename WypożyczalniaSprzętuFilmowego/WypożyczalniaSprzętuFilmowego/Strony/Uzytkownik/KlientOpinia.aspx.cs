using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Uzytkownik
{
    public partial class KlientOpinia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            var DodajOpinie = new Mapping.Opinia()
            {
                Opis = Opinia.Text,
                Ocena = ddlOcena.SelectedIndex,

            };
            api.dodajOpinie(DodajOpinie);
            Response.Redirect("~/Interfejs/Klient/klientglowna.aspx");
        }
    }
}