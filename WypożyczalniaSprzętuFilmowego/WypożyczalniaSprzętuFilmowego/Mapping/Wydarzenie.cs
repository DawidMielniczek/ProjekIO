using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WypożyczalniaSprzętuFilmowego.Mapping
{
    public class Wydarzenie
    {
        public virtual int WydarzenieId { get; set; }
        public virtual int KlientId { get; set; }
        public virtual int SprzetId { get; set; }
        public virtual DateTime DataWyp { get; set; }
    }
}