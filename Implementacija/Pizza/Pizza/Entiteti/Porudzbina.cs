using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Entiteti
{
    public class Porudzbina
    {
        public virtual int Id_porudzbina { get; protected set; }

        public virtual float? Cena { get; set; }

        public virtual string Nacin_placanja { get; set; }

        public virtual string Status { get; set; }

        public virtual DateTime? Datum_vreme_isporuke { get; set; }

        public virtual DateTime Datum_vreme_kreiranja { get; set; }

        //many-to-one Porudzbina-Osoba
        public virtual Osoba PripadaOsobi { get; set; }

        //many-to-one Porudzbina-Vozilo
        public virtual Vozilo DostavljanoVozilom { get; set; }

        public Porudzbina() { }
    }
}
