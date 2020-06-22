using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.DTOs
{
    public abstract class Vozilo
    {
        public virtual int Id_vozilo { get; protected set; }

        public virtual string Naziv_tipa { get; set; }

        public virtual string Proizvodjac { get; set; }

        public virtual string Tip_vozila { get; set; }

        public virtual float? Velicina_rama { get; set; }

        public virtual string Registarski_broj { get; set; }

        public virtual int? Br_saobracajne_dozvole { get; set; }

        //one-to-many Vozilo-Porudzbina
        public virtual IList<Porudzbina> Porudzbine { get; set; }

        //one-to-many Vozilo-Osoba
        public virtual IList<Osoba> Osobe { get; set; }

        public Vozilo()
        {
            Porudzbine = new List<Porudzbina>();

            Osobe = new List<Osoba>();
        }

        public override string ToString()
        {
            if (base.GetType() == typeof(VoziloBicikl))
                return base.ToString() + ":\nId: " + this.Id_vozilo + "\nNaziv tipa: " + this.Naziv_tipa +
                    "\nProizvodjac: " + this.Proizvodjac + "\nVelicina rama: " + this.Velicina_rama;
            else
                return base.ToString() + ":\nId: " + this.Id_vozilo + "\nNaziv tipa: " + this.Naziv_tipa + 
                    "\nProizvodjac: " + this.Proizvodjac + "\nRegistarski broj: " + this.Registarski_broj + 
                    "\nBroj saobracajne dozvole: " + this.Br_saobracajne_dozvole;
        }
    }

    public class VoziloBicikl : Vozilo { }

    public class VoziloSkuter : Vozilo { }

    public class VoziloAutomobil : Vozilo { }
}
