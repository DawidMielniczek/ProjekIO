using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WypożyczalniaSprzętuFilmowego.Dto
{
    public class IdKlienta
    {
        public int KlientId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Haslo { get; set; }
        public string Pesel { get; set; }
    }
}