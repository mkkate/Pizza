using PizzaDatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDatabaseAccess.DTOs
{
    public class PorudzbinaView
    {
        public int PorudzbinaId { get; set; }
        public float? Cena { get; set; }
        public string Nacin_placanja { get; set; }
        public string Status { get; set; }
        public DateTime? Datum_vreme_isporuke { get; set; }
        public DateTime Datum_vreme_kreiranja { get; set; }
        public OsobaView PripadaOsobi { get; set; }
        public VoziloView DostavljanoVozilom { get; set; }
        public virtual IList<SadrziView> SadrziPice { get; set; }

        public PorudzbinaView()
        {
            SadrziPice = new List<SadrziView>();
        }

        public PorudzbinaView(Porudzbina p)
        {
            this.Cena = p.Cena;
            this.Datum_vreme_isporuke = p.Datum_vreme_isporuke;
            this.Datum_vreme_kreiranja = p.Datum_vreme_kreiranja;
            this.DostavljanoVozilom = new VoziloView(p.DostavljanoVozilom);
            this.Nacin_placanja = p.Nacin_placanja;
            this.PorudzbinaId = p.Id_porudzbina;
            this.PripadaOsobi = new OsobaView(p.PripadaOsobi);
            this.Status = p.Status;
            SadrziPice = new List<SadrziView>();
        }
    }
}
