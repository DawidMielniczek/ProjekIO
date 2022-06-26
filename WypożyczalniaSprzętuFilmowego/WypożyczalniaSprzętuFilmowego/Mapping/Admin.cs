using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WypożyczalniaSprzętuFilmowego.Mapping
{
    public class Admin
    {
        public virtual int IdAdmina { get; set; }
        public virtual string Email { get; set; }
        public virtual string Haslo { get; set; }
    }
}