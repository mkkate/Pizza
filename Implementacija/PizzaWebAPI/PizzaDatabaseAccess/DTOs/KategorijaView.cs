using System;
using System.Collections.Generic;
using System.Text;
using Pizza.Entiteti;

namespace PizzaDatabaseAccess.DTOs
{
    public class KategorijaView
    {
        public int Id_surogat_kategorija { get; protected set; }
        public string Kategorija_vozacke_dozvole { get; set; }
        public OsobaView PripadaOsobi { get; set; }

        public KategorijaView() { }

        public KategorijaView(Kategorija k)
        {
            Id_surogat_kategorija = k.Id_surogat_kategorija;
            Kategorija_vozacke_dozvole = k.Kategorija_vozacke_dozvole;
            PripadaOsobi = new OsobaView(k.PripadaOsobi);
        }
    }
}
