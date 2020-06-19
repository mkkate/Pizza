using PizzaDatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDatabaseAccess.DTOs
{
    public class BrTelefonaView
    {
        public int BrTelefonaId { get; set; }
        public string BrojTelefona { get; set; }
        //many-to-one BrTelefona-Osoba
        public OsobaView PripadaOsobi { get; set; }

        public BrTelefonaView() 
        { 

        }

        public BrTelefonaView(BrTelefona brtel)
        {
            BrTelefonaId = brtel.Id_surogat_br_telefona;
            BrojTelefona = brtel.Broj_telefona;
            PripadaOsobi = new OsobaView(brtel.PripadaOsobi);
        }
    }
}
