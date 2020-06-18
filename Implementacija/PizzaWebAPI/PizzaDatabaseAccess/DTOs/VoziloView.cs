using Pizza.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDatabaseAccess.DTOs
{
    public class VoziloView
    {
        public string Tip_vozila { get; set; }
        public int VoziloId { get; set; }
        public string Naziv_tipa { get; set; }
        public string Proizvodjac { get; set; }
        public float? Velicina_rama { get; set; }
        public string Registarski_broj { get; set; }
        public int? Br_saobracajne_dozvole { get; set; }

        //broj porudzbina koje dostavlja to vozilo
        public int BrojPorudzbina { get; set; }

        //broj osoba koje voze to vozilo
        public int BrojOsoba { get; set; }

        public VoziloView()
        { }

        public VoziloView(Vozilo v)
        {
            VoziloId = v.Id_vozilo;
            Naziv_tipa = v.Naziv_tipa;
            Proizvodjac = v.Proizvodjac;
            BrojPorudzbina = v.Porudzbine.Count;
            BrojOsoba = v.Osobe.Count;
        }
    }

    public class VoziloAutomobilView : VoziloView
    {
        public VoziloAutomobilView()
        {
            Tip_vozila = "AUTOMOBIL";
        }

        public VoziloAutomobilView(Vozilo v) : base(v)
        {
            this.Velicina_rama = null;
            this.Registarski_broj = v.Registarski_broj;
            this.Br_saobracajne_dozvole = v.Br_saobracajne_dozvole;
        }
    }

    public class VoziloBiciklView : VoziloView
    {
        public VoziloBiciklView()
        {
            Tip_vozila = "BICIKL";
        }

        public VoziloBiciklView(Vozilo v) : base(v)
        {
            this.Velicina_rama = v.Velicina_rama;
            this.Registarski_broj = null;
            this.Br_saobracajne_dozvole = null;
        }
    }

    public class VoziloSkuterView : VoziloView
    {
        public VoziloSkuterView()
        {
            Tip_vozila = "SKUTER";
        }

        public VoziloSkuterView(Vozilo v) : base(v)
        {
            this.Velicina_rama = null;
            this.Registarski_broj = v.Registarski_broj;
            this.Br_saobracajne_dozvole = v.Br_saobracajne_dozvole;
        }
    }
}
