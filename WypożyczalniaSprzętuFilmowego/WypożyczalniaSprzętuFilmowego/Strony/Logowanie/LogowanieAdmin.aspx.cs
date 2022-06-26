using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Logowanie
{
    public partial class LogowanieAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            var result = true;
            WypożyczalniaApi api = new WypożyczalniaApi();
            var services = api.GetAdmin();
            for (int i = 0; i < services.Count; i++)
            {
                if (services[i].Email.Trim() == TxtloginA.Text && services[i].Haslo.Trim() == TxthasloA.Text)
                {
                    Session["Id"] = services[i].IdAdmina;
                    Response.Redirect("~/Strony/Administrator/AdminGlowna.aspx");
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