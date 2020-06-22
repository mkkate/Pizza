using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDatabaseAccess.DTOs
{
    public class RadiUView
    {
        public virtual int Id_surogat_radi_u { get; protected set; }
        public virtual OsobaView Id_osoba { get; set; }
        public virtual SmenaView Id_smena { get; set; }

        public RadiUView() { }

        public RadiUView(RadiU r)
        {
            Id_surogat_radi_u = r.Id_surogat_radi_u;
            Id_osoba = new OsobaView(r.Id_osoba);
            Id_smena = new SmenaView(r.Id_smena);
        }
    }
}
