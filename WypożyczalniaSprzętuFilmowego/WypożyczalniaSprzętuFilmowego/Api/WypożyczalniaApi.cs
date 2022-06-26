using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WypożyczalniaSprzętuFilmowego.Dto;
using WypożyczalniaSprzętuFilmowego.Hibernate;
using WypożyczalniaSprzętuFilmowego.Mapping;

namespace WypożyczalniaSprzętuFilmowego.Api
{
    public class WypożyczalniaApi
    {
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
        public List<IdWydarzenia> GetWypożyczenia(int ID)
        {
            using (var session = NhibernateBase.Session)
            {
                return session.Query<Wydarzenie>().Select(
                    x => new IdWydarzenia
                    {
                        WydarzenieId = x.WydarzenieId,
                        KlientId = x.KlientId,
                        DataWyp = x.DataWyp,
                        SprzetId = x.SprzetId
                    }).Where(x => x.KlientId == ID).ToList();
            }
        }
        public List<IdSprzet> GetStatus(int IdWyp)
        {
            using (var session = NhibernateBase.Session)
            {
                return session.Query<Sprzet>().Select(
                    x => new IdSprzet
                    {
                        SprzetId = x.SprzetId,
                        Nazwa = x.Nazwa,
                        Dostepnosc = x.Dostepnosc
                    }).Where(x => x.SprzetId == IdWyp).ToList();

            }
        }

        public void Rejestracja(Klient rejestracja)
        {
            using (var session = NhibernateBase.Session)
            {
                session.Save(rejestracja);
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
        public void Usun(Klient klient)
        {
            using (var session = NhibernateBase.Session)
            {
                session.Delete(klient);
                session.Refresh(klient);
                //nie mam pojęcia dlaczego ale bez Flush() nie usuwa a jak nie damy wcześniej Refresh() to wywala błąd także nie usuwać mimo że jest błędem
                session.Flush();
            }
        }
        public void dodajOpinie(Opinia DodajOpinie)
        {
            using (var session = NhibernateBase.Session)
            {
                session.Save(DodajOpinie);
            }
        }
        public void dodajSprzet(Sprzet DodajSprzet)
        {
            using (var session = NhibernateBase.Session)
            {
                session.Save(DodajSprzet);
            }
        }

        public List<IdSprzet> GetGry()
        {
            using (var session = NhibernateBase.Session)
            {
                return session.Query<Sprzet>().Select(
                x => new IdSprzet
                {
                    SprzetId = x.SprzetId,
                    Nazwa = x.Nazwa,
                    Dostepnosc = x.Dostepnosc
                }).Where(x => x.Dostepnosc == "tak").ToList();
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
    }
}