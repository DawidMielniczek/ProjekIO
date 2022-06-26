using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WypożyczalniaSprzętuFilmowego.Mapping
{
    public class Sprzet
    {
        public virtual int SprzetId { get; set; }
        public virtual string Nazwa { get; set; }
        public virtual string Dostepnosc { get; set; }
    }
}