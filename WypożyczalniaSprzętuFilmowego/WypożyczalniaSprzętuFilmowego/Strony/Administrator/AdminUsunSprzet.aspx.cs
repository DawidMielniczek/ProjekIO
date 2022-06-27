using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Administrator
{
    public partial class AdminUsunSprzet : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            var result = api.GetSprzetD();
            gvSprzet.DataSource = result;
            gvSprzet.DataBind();
        }

        protected void btn_usun_Click(object sender, EventArgs e)
        {
            var id = TxtId.Text;

            WypożyczalniaApi api1 = new WypożyczalniaApi();
            api1.UsuńSprzet(Convert.ToInt32(id));
            Response.Redirect("~/Strony/Administrator/AdminUsunSprzet.aspx");
        }
    }
}