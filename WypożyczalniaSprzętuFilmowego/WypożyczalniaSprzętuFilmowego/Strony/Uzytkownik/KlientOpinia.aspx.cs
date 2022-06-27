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
            var opinia = Opinia.Text;
            var ocena = Convert.ToInt32(ddlOcena.Text);
            WypożyczalniaApi api = new WypożyczalniaApi();
            api.DodajOpinie(opinia, ocena);
            
            Response.Redirect("~/Strony/Uzytkownik/KlientGlowna.aspx");
        }
    }
}