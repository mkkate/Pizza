using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Entiteti
{
    public class Pica
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual float Cena { get; set; }


        public Pica() {

        }
    }
}
