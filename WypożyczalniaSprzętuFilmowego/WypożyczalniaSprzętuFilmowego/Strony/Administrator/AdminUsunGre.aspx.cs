using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WypożyczalniaSprzętuFilmowego.Strony.Administrator
{
    public partial class AdminUsunGre : System.Web.UI.Page
    {
        string conn = @"Data Source=localhost;Initial Catalog=WypożyczalniaSprzetuFilmowego;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(conn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand("Select Nazwa From Sprzet", sqlconn);
            sqlcomm.CommandType = CommandType.Text;
            ddlSprzet.DataSource = sqlcomm.ExecuteReader();
            ddlSprzet.DataTextField = "Nazwa";
            ddlSprzet.DataValueField = "Nazwa";
            ddlSprzet.DataBind();
            ddlSprzet.Items.Insert(0, new ListItem("-- Wybierz Sprzet--", "0"));
        }

        protected void btn_usun_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(conn);
            sqlconn.Open();
            var wynik = ddlSprzet.SelectedValue;
            SqlCommand sqlcomm = new SqlCommand("Delete from Sprzet where Nazwa ='" + ddlSprzet.SelectedValue + "' ", sqlconn);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }
    }
}