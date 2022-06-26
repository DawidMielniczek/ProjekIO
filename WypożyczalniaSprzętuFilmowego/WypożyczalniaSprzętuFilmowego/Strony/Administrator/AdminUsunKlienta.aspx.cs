using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Administrator
{
    public partial class AdminUsunKlienta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            var usun = api.GetKlientas();
            gvUzytkownik.DataSource = usun;
            gvUzytkownik.DataBind();
        }

        protected void btn_usun_Click(object sender, EventArgs e)
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            var Usun = new Mapping.Klient
            {
                KlientId = Convert.ToInt32(TxtId.Text)
            };

            api.Usun(Usun);
            Response.Redirect("~/Strony/Administrator/AdminUsunKlienta.aspx");
        }
    }
}