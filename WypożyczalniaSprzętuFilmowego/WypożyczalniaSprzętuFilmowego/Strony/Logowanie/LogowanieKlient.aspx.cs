using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Logowanie
{
    public partial class LogowanieKlient : System.Web.UI.Page
    {
        public int logK;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            var result = true;
            WypożyczalniaApi api = new WypożyczalniaApi();
            var services = api.GetKlient();
            for (int i = 0; i < services.Count; i++)
            {
                if (services[i].Email.Trim() == TxtloginK.Text && services[i].Haslo.Trim() == TxthasloK.Text)
                {
                    Session["Id"] = services[i].KlientId;
                    logK = services[i].KlientId;
                    Response.Redirect("~/Strony/Uzytkownik/klientGlowna.aspx");
                    result = false;
                    break;
                }
            }
            if (result)
            {
                txtwynik.Text = "Podano błędne dane";
            }
        }
    }
}