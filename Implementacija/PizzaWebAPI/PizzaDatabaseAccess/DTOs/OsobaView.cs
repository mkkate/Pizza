using System;
using System.Collections.Generic;
using System.Text;
using PizzaDatabaseAccess.DTOs;

namespace PizzaDatabaseAccess.DTOs
{
    public class OsobaView
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ulica { get; set; }
        public int Broj { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public char FZaposleni { get; set; }
        public string Jmbg { get; set; }
        public DateTime? Datum_rodjenja { get; set; }
        public char FPrimalac_porudzbine { get; set; }
        public char FDostavljac { get; set; }
        public char FKupac { get; set; }
        public DateTime? Datum_prve_porudzbine { get; set; }
        public char FBonus_program { get; set; }
        public int? Br_bodova { get; set; }
        public VoziloView DuziVozilo { get; set; }
        public virtual IList<PorudzbinaView> Porudzbine { get; set; }
        public virtual IList<BrTelefonaView> BrojeviTelefona { get; set; }
        public IList<DobijeniPoklonView> DobijeniPokloni { get; set; }
        public IList<KategorijaView> Kategorije { get; set; }
        public IList<EmailView> Emailovi { get; set; }
        public IList<RadiUView> ORadiU { get; set; }
        public IList<GovoriView> OGovori { get; set; }

        public OsobaView()
        {
            Porudzbine = new List<PorudzbinaView>();
            BrojeviTelefona = new List<BrTelefonaView>();
            DobijeniPokloni = new List<DobijeniPoklonView>();
            Kategorije = new List<KategorijaView>();
            Emailovi = new List<EmailView>();
            ORadiU = new List<RadiUView>();
            OGovori = new List<GovoriView>();
        }

        public OsobaView(Osoba osoba)
        {
            this.Broj = osoba.Broj;
            this.Br_bodova = osoba.Br_bodova;
            this.Datum_prve_porudzbine = osoba.Datum_prve_porudzbine;
            this.Datum_rodjenja = osoba.Datum_rodjenja;
            this.Drzava = osoba.Drzava;
            if(osoba.DuziVozilo != null)
                this.DuziVozilo = new VoziloView(osoba.DuziVozilo);
            this.FBonus_program = osoba.FBonus_program;
            this.FDostavljac = osoba.FDostavljac;
            this.FKupac = osoba.FKupac;
            this.FPrimalac_porudzbine = osoba.FPrimalac_porudzbine;
            this.FZaposleni = osoba.FZaposleni;
            this.Grad = osoba.Grad;
            this.OsobaId = osoba.Id_osoba;
            this.Ime = osoba.Ime;
            this.Jmbg = osoba.Jmbg;
            this.Prezime = osoba.Prezime;
            this.Ulica = osoba.Ulica;
            Porudzbine = new List<PorudzbinaView>();
            BrojeviTelefona = new List<BrTelefonaView>();
            DobijeniPokloni = new List<DobijeniPoklonView>();
            Kategorije = new List<KategorijaView>();
            Emailovi = new List<EmailView>();
            ORadiU = new List<RadiUView>();
            OGovori = new List<GovoriView>();
        }
    }
}
