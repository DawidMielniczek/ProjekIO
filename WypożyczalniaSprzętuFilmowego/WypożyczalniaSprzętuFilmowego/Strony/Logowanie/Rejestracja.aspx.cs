using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WypożyczalniaSprzętuFilmowego.Api;

namespace WypożyczalniaSprzętuFilmowego.Strony.Logowanie
{
    public partial class Rejestracja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Rejestracja_Click(object sender, EventArgs e)
        {
            WypożyczalniaApi api = new WypożyczalniaApi();
            var Rejestracja = new Mapping.Klient()
            {
                Haslo = TxtHaslo.Text,
                Email = TXTEmail.Text,
                Imie = TxtImie.Text,
                Nazwisko = TxtNazwisko.Text,
                Telefon = TxtTelefon.Text,
                Pesel = TxtPesel.Text,
            };
            api.Rejestracja(Rejestracja);
            Response.Redirect("~/Strony/Logowanie/LogowanieKlient.aspx");
        }
    }
}