using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.Entiteti
{
    public class Sadrzi
    {
        public virtual int Id_surogat_sadrzi { get; protected set; }

        public virtual Pica Id_pizza { get; set; }

        public virtual Porudzbina Id_porudzbina { get; set; }

        public virtual string Sastojci { get; set; }

        public virtual float Pojedinacna_cena { get; set; }

        public Sadrzi()
        {

        }
    }
}
