using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WypożyczalniaSprzętuFilmowego.Mapping
{
    public class Klient
    {
        public virtual int KlientId { get; set; }
        public virtual string Imie { get; set; }
        public virtual string Nazwisko { get; set; }
        public virtual string Email { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Haslo { get; set; }
        public virtual string Pesel { get; set; }
    }
}