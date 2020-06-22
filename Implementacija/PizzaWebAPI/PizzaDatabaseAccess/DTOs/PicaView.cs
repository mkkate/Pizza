using System;
using System.Collections.Generic;
using System.Text;
using PizzaDatabaseAccess.Entiteti;

namespace PizzaDatabaseAccess.DTOs
{
    public class PicaView
    {
        public int Id { get; protected set; }
        public string Naziv { get; set; }
        public float Cena { get; set; }

        //one-to-many Pica-Sadrzi (Porudzbina)
        public virtual IList<SadrziView> SadrziPorudzbine { get; set; }

        public PicaView()
        {
            SadrziPorudzbine = new List<SadrziView>();
        }

        public PicaView(Pica p)
        {
            Id = p.Id;
            Naziv = p.Naziv;
            Cena = p.Cena;
        }
    }
}
