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
    }
}