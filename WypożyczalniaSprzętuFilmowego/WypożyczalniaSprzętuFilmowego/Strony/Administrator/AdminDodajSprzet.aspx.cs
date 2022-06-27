using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Administrator
{
    public partial class AdminDodajSprzet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            var Nazwa = Txt1.Text;
            WypożyczalniaApi api = new WypożyczalniaApi();
            api.DodajSprzet(Nazwa);
            Response.Redirect("~/Strony/Administrator/AdminGlowna.aspx");
        }
    }
}