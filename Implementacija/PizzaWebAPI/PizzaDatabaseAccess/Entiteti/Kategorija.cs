using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.DTOs
{
    public class Kategorija
    {
        public virtual int Id_surogat_kategorija { get; protected set; }
        public virtual string Kategorija_vozacke_dozvole { get; set; }
        public virtual Osoba PripadaOsobi { get; set; }
    }
}
