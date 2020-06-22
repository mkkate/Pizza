using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.Entiteti
{
    public class Pica
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual float Cena { get; set; }

        //one-to-many Pica-Sadrzi (Porudzbina)
        public virtual IList<Sadrzi> SadrziPorudzbine { get; set; }

        public Pica()
        {
            SadrziPorudzbine = new List<Sadrzi>();
        }
    }
}
