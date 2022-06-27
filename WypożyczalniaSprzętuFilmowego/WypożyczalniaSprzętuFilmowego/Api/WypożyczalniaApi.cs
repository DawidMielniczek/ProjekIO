using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WypożyczalniaSprzętuFilmowego.Dto;
using WypożyczalniaSprzętuFilmowego.Hibernate;
using WypożyczalniaSprzętuFilmowego.Mapping;

namespace WypożyczalniaSprzętuFilmowego.Api
{
    public class WypożyczalniaApi
    {
        string connection = @"Server = localhost; Database= WypożyczalniaSprzetuFilmowego; Trusted_connection=True";

        public WypożyczalniaApi()
        {
            NhibernateBase nHibernate = new NhibernateBase();
            nHibernate.Initialize();
        }
        public int ID { get; set; }
        public int IdWyp { get; set; }
        public List<IdAdmin> GetAdmin()
        {
            using (var session = NhibernateBase.Session)
            {
                return session.Query<Admin>().Select(
                    x => new IdAdmin
                    {
                        Email = x.Email,
                        Haslo = x.Haslo
                    }).ToList();
            }
        }
        public List<IdKlienta> GetKlient()
        {
            using (var session = NhibernateBase.Session)
            {
                return session.Query<Klient>().Select(
                    x => new IdKlienta
                    {
                        KlientId = x.KlientId,
                        Email = x.Email,
                        Haslo = x.Haslo
                    }).ToList();
            }
        }
        public List<IdSprzet> GetWydarzenie(int q)
        {
            using (var con = new SqlConnection(connection))
            {
                con.Open();
                
                var result = con.Query<IdSprzet>("Select Sprzet.SprzetId,Sprzet.Nazwa,Sprzet.Dostepnosc from Sprzet,Wydarzenie Where Sprzet.SprzetId = Wydarzenie.SprzetId AND Wydarzenie.KlientId=" + q).ToList();

                return result;
            }
        }
        

        public void Rejestracja(Klient rejestracja)
        {
            using (var session = NhibernateBase.Session)
            {
                session.Save(rejestracja);
            }
        }

        public List<IdSprzet> GetSprzetD()
        {
            string connection = @"Server = localhost; Database= WypożyczalniaSprzetuFilmowego; Trusted_connection=True";
            using (var con = new SqlConnection(connection))
            {
                con.Open();
                var result = con.Query<IdSprzet>("Select * from Sprzet where Dostepnosc ='tak'").ToList();
                return result;
            }
        }
        public void Usun(Klient klient)
        {
            using (var session = NhibernateBase.Session)
            {
                session.Delete(klient);
                session.Refresh(klient);
                session.Flush();
            }
        }
        public void DodajOpinie(string opinia, int ocena)
        {
            string connection = @"Server = localhost; Database= WypożyczalniaSprzetuFilmowego; Trusted_connection=True";
            using (var con = new SqlConnection(connection))
            {
                con.Open();

                var Query = @"INSERT INTO Opinia VALUES
                            (@opinia,@ocena)";
                var db = new DynamicParameters();
                db.Add("@opinia", opinia);
                db.Add("@ocena", ocena);
                int result = con.Execute(Query, db);
            }
        }
        public List<IdKlienta> GetKlientas()
        {
            using (var session = NhibernateBase.Session)
            {
                return session.Query<Klient>().Select(
                    x => new IdKlienta
                    {
                        KlientId = x.KlientId,
                        Imie = x.Imie,
                        Nazwisko = x.Nazwisko,
                        Pesel = x.Pesel,
                        Telefon = x.Telefon,
                        Email = x.Email,
                        Haslo = x.Haslo
                    }).ToList();
            }
        }
        public void DodajSprzet(string Nazwa)
        {
            string connection = @"Server =localhost; Database= WypożyczalniaSprzetuFilmowego; Trusted_connection=True";
            using (var con = new SqlConnection(connection))
            {
                con.Open();

                var Query = @"INSERT INTO Sprzet VALUES
                            (@Name,'tak')";
                var db = new DynamicParameters();
                db.Add("@Name", Nazwa);
                int result = con.Execute(Query, db);
            }
        }
        public List<IdSprzet> GetSprzety()
        {
            string connection = @"Server = localhost; Database= WypożyczalniaSprzetuFilmowego; Trusted_connection=True";
            using (var con = new SqlConnection(connection))
            {
                con.Open();
                var result = con.Query<IdSprzet>("Select * from Sprzet").ToList();
                return result;
            }
        }

        public List<IdOpini> GetOpinie()
        {
            using (var session = NhibernateBase.Session)
            {
                return session.Query<Opinia>().Select(
                x => new IdOpini
                {
                    IdOpinii = x.IdOpinii,
                    Opis = x.Opis,
                    Ocena = x.Ocena
                }).ToList();
            }
        }

        public void UsuńSprzet(int id)
        {
            string connection = @"Server = localhost; Database= WypożyczalniaSprzetuFilmowego; Trusted_connection=True";

            using (var con = new SqlConnection(connection))
            {
                con.Open();

                var Query = @"delete from Sprzet where SprzetId=@id";

                var db = new DynamicParameters();
                db.Add("@id", id);
                int result = con.Execute(Query, db);
            }
        }

        public void AddWypo(int IdU, int Ids)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=WypożyczalniaSprzetuFilmowego;Trusted_Connection=True");
            con.Open();
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            SqlCommand cmdwypo = new SqlCommand("INSERT INTO Wydarzenie  VALUES( '" + IdU + "' , '" + Ids + "', '" + sqlFormattedDate + "')", con);
            cmdwypo.ExecuteNonQuery();
            SqlCommand updateg1 = new SqlCommand("Update Sprzet Set Dostepnosc = 'nie' Where SprzetId = " + Ids, con);
            updateg1.ExecuteNonQuery();

        }
        public void OddajWypo(int Ids)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=WypożyczalniaSprzetuFilmowego;Trusted_Connection=True");
            con.Open();
            SqlCommand cmdwypo = new SqlCommand("Delete From  Wydarzenie where SprzetId= " + Ids, con);
            cmdwypo.ExecuteNonQuery();
            SqlCommand updateg1 = new SqlCommand("Update Sprzet Set Dostepnosc = 'tak' Where SprzetId = " + Ids, con);
            updateg1.ExecuteNonQuery();
        }
    }
}