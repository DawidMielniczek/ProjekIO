using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WypożyczalniaSprzętuFilmowego.Mapping
{
    public class Opinia
    {
        public virtual int IdOpinii { get; set; }
        public virtual string Opis { get; set; }
        public virtual int Ocena { get; set; }
    }
}