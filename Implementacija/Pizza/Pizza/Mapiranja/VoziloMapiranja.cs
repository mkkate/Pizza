using FluentNHibernate.Mapping;
using Pizza.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Mapiranja
{
    public class VoziloMapiranja : ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            //map table
            Table("VOZILO");

            //map key
            Id(x => x.Id_vozilo, "ID_VOZILO").GeneratedBy.SequenceIdentity("SEQ_ID_VOZILO");

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIP_VOZILA");

            //map properties
            Map(x => x.Naziv_tipa, "NAZIV_TIPA");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.Velicina_rama, "VELICINA_RAMA");
            Map(x => x.Registarski_broj, "REGISTARSKI_BROJ");
            Map(x => x.Br_saobracajne_dozvole, "BR_SAOBRACAJNE_DOZVOLE");
        }
    }

    class BiciklMapiranja : SubclassMap<VoziloBicikl>
    {
        public BiciklMapiranja()
        {
            DiscriminatorValue("BICIKL");
        } 
    }

    class SkuterMapiranja : SubclassMap<VoziloSkuter>
    {
        public SkuterMapiranja()
        {
            DiscriminatorValue("SKUTER");
        }
    }

    class AutomobilMapiranja : SubclassMap<VoziloAutomobil>
    {
        public AutomobilMapiranja()
        {
            DiscriminatorValue("AUTOMOBIL");
        }
    }
}
