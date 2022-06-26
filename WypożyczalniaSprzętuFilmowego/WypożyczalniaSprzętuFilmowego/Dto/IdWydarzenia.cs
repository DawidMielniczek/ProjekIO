using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WypożyczalniaSprzętuFilmowego.Dto
{
    public class IdWydarzenia
    {
        public int WydarzenieId { get; set; }
        public int KlientId { get; set; }
        public int SprzetId { get; set; }
        public DateTime DataWyp { get; set; }
    }
}