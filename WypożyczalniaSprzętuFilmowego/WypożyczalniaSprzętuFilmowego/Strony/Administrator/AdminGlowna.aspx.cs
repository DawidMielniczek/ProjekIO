using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Administrator
{
    public partial class AdminGlowna : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            gvSprzety.DataSource = api.GetSprzety();
            gvSprzety.DataBind();

        }
    }
}