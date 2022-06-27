using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;
using WypożyczalniaSprzętuFilmowego.Dto;

namespace WypożyczalniaSprzętuFilmowego.Strony.Uzytkownik
{
    public partial class KlientAktualne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAktulaneWyp();

        }
        protected void GetAktulaneWyp()
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            var q = Session["Id"];
            var services = api.GetWydarzenie(Convert.ToInt32(q));

            if (services.Count >= 1)
            {
                GAktualneWyp.DataSource = services;
                GAktualneWyp.DataBind();
            }
            else
            {
                GAktualneWyp.DataSource = null;
            }
            string connection = @"Data Source= localhost;Initial Catalog=WypożyczalniaSprzetuFilmowego;Integrated Security=True";
            using (var con = new SqlConnection(connection))
            {
                var dlug = 0;
                con.Open();
                SqlCommand sql = con.CreateCommand();
                sql.CommandText = @"Select DATEDIFF(DAY, DataWyp, GETDATE()) as 'Kara' from Wydarzenie, Klient where Klient.KlientId = Wydarzenie.WydarzenieId AND Klient.KlientId=@Id";
                sql.Parameters.Add("@Id", Convert.ToInt32(q));
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["Kara"]) > 30)
                    {
                        dlug += (Convert.ToInt32(reader["Kara"]) - 30) * 2;

                    }

                }
                lvlKara.Text += dlug.ToString() + " zł";

            }
        }
    }
}