using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.DTOs
{
    public class BrTelefona
    {
        public virtual int Id_surogat_br_telefona { get; protected set; }

        public virtual string Broj_telefona { get; set; }

        //many-to-one BrTelefona-Osoba
        public virtual Osoba PripadaOsobi { get; set; }

        public BrTelefona() { }
    }
}
