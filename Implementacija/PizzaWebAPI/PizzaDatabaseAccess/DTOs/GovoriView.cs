using System;
using System.Collections.Generic;
using System.Text;
using PizzaDatabaseAccess.Entiteti;

namespace PizzaDatabaseAccess.DTOs
{
    public class GovoriView
    {
        public int Id_surogat_govori { get; protected set; }

        public string Nivo { get; set; }

        public StraniJezikView Id_strani_jezik { get; set; }

        public OsobaView Id_osoba { get; set; }

        public GovoriView() { }

        public GovoriView(Govori g)
        {
            Id_surogat_govori = g.Id_surogat_govori;
            Nivo = g.Nivo;
            Id_strani_jezik = new StraniJezikView(g.Id_strani_jezik);
            Id_osoba = new OsobaView(g.Id_osoba);
        }
    }
}
