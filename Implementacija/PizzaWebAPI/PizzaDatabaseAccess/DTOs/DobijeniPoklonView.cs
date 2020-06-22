using System;
using System.Collections.Generic;
using System.Text;
using PizzaDatabaseAccess.Entiteti;

namespace PizzaDatabaseAccess.DTOs
{
    public class DobijeniPoklonView
    {
            public int Id_dodele { get; protected set; }
            public string Tip_poklona { get; set; }
            public int Kvalifikacioni_bodovi { get; set; }
            public DateTime Datum_dodele { get; set; }
            public DateTime? Datum_iskoriscenja { get; set; }
            public OsobaView PripadaOsobi { get; set; }

        public DobijeniPoklonView() { }

        public DobijeniPoklonView(DobijeniPoklon p)
        {
            Id_dodele = p.Id_dodele;
            Tip_poklona = p.Tip_poklona;
            Kvalifikacioni_bodovi = p.Kvalifikacioni_bodovi;
            Datum_dodele = p.Datum_dodele;
            Datum_iskoriscenja = p.Datum_iskoriscenja;
            PripadaOsobi = new OsobaView (p.PripadaOsobi);
        }

    }
}
