using PizzaDatabaseAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDatabaseAccess.DTOs
{
    public class SmenaView
    {
        public int Id_smena { get; set; }

        public DateTime Datum_od { get; set; }

        public DateTime Datum_do { get; set; }

        public char Tip_smene { get; set; }

        public virtual IList<RadiUView> RadiUS { get; set; }
        public SmenaView()
        {
            RadiUS = new List<RadiUView>();
        }
        public SmenaView(Smena s)
        {
            Id_smena = s.Id_smena;
            Datum_od = s.Datum_od;
            Datum_do = s.Datum_do;
            RadiUS = new List<RadiUView>();
        }

    }

    public class Smena1View : SmenaView 
    { 
        public Smena1View()
        {
            Tip_smene = '1';
            RadiUS = new List<RadiUView>();
        }
        public Smena1View(Smena s) : base(s)
        {
            Tip_smene = '1';
            RadiUS = new List<RadiUView>();
        }
    }

    public class Smena2View : SmenaView 
    {
        public Smena2View()
        {
            Tip_smene = '2';
            RadiUS = new List<RadiUView>();
        }
        public Smena2View(Smena s) : base(s)
        {
            Tip_smene = '2';
            RadiUS = new List<RadiUView>();
        }
    }

    public class Smena3View : SmenaView
    {
        public Smena3View()
        {
            Tip_smene = '3';
            RadiUS = new List<RadiUView>();
        }
        public Smena3View(Smena s) : base(s)
        {
            Tip_smene = '3';
            RadiUS = new List<RadiUView>();
        }
    }
}
