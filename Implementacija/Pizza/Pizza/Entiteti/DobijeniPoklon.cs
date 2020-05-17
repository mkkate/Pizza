using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Entiteti
{
    public class DobijeniPoklon
    {
        public virtual int Id_dodele { get; protected set; }
        public virtual string Tip_poklona { get; set; }
        public virtual int Kvalifikacioni_bodovi { get; set; }
        public virtual DateTime Datum_dodele { get; set; }
        public virtual DateTime Datum_iskoriscenja { get; set; }
        public virtual Osoba PripadaOsobi { get; set; }

    }
}
