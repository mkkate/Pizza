using FluentNHibernate.Mapping;
using Pizza.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Mapiranja
{
    class VoziloMapiranja : ClassMap<Pizza.Entiteti.Vozilo>
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

    class VoziloBiciklMapiranja : SubclassMap<VoziloBicikl>
    {
        public VoziloBiciklMapiranja()
        {
            DiscriminatorValue("BICIKL");
        } 
    }

    class VoziloSkuterMapiranja : SubclassMap<VoziloSkuter>
    {
        public VoziloSkuterMapiranja()
        {
            DiscriminatorValue("SKUTER");
        }
    }

    class VoziloAutomobilMapiranja : SubclassMap<VoziloAutomobil>
    {
        public VoziloAutomobilMapiranja()
        {
            DiscriminatorValue("AUTOMOBIL");
        }
    }
}
