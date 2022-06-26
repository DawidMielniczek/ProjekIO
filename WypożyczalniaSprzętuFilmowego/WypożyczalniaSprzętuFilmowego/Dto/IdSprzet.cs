using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WypożyczalniaSprzętuFilmowego.Dto
{
    public class IdSprzet
    {
        public int SprzetId { get; set; }
        public string Nazwa { get; set; }
        public string Dostepnosc { get; set; }
    }
}