using PizzaDatabaseAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDatabaseAccess.DTOs
{
    public class SadrziView
    {
        public int SadrziId { get; set; }
        public PicaView IdPizza { get; set; }
        public PorudzbinaView IdPorudzbina { get; set; }
        public string Sastojci { get; set; }
        public float PojedinacnaCena { get; set; }

        public SadrziView()
        {

        }

        public SadrziView(Sadrzi s)
        {
            SadrziId = s.Id_surogat_sadrzi;
            if (s.Id_pizza != null)
                IdPizza = new PicaView(s.Id_pizza);
            if (s.Id_porudzbina != null)
                IdPorudzbina = new PorudzbinaView(s.Id_porudzbina);
            Sastojci = s.Sastojci;
            PojedinacnaCena = s.Pojedinacna_cena;
        }
    }
}
