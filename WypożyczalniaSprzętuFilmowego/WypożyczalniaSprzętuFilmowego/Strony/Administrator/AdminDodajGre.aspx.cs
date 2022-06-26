using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Administrator
{
    public partial class AdminDodajGre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            var DodajSprzet = new Mapping.Sprzet()
            {
                Nazwa = Txt1.Text,
                Dostepnosc = Txt2.Text,

            };
            api.dodajSprzet(DodajSprzet);
            Response.Redirect("~/Strony/Administrator/AdminGlowna.aspx");
        }
    }
}