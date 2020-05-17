using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Entiteti
{
    public class Osoba
    {
        public virtual int Id_osoba { get; protected set; }

        public virtual string Ime { get; set; }

        public virtual string Prezime { get; set; }

        public virtual string Ulica { get; set; }

        public virtual int Broj { get; set; }

        public virtual string Grad { get; set; }

        public virtual string Drzava { get; set; }

        public virtual char FZaposleni { get; protected set; }

        public virtual string Jmbg { get; set; }

        public virtual DateTime Datum_rodjenja { get; set; }

        public virtual char FPrimalac_porudzbine { get; protected set; }

        public virtual char FDostavljac { get; protected set; }

        public virtual char FKupac { get; protected set; }

        public virtual DateTime Datum_prve_porudzbine { get; set; }

        public virtual char FBonus_program { get; protected set; }

        public virtual int Br_bodova { get; set; }



        public virtual IList<DobijeniPoklon> DobijeniPokloni { get; set; }
        public virtual IList<Kategorija> Kategorije { get; set; }
        public virtual IList<Email> Emailovi { get; set; }

        public Osoba()
        {
            DobijeniPokloni = new List<DobijeniPoklon>();
            Kategorije = new List<Kategorija>();
            Emailovi = new List<Email>();
        }
    }
}
