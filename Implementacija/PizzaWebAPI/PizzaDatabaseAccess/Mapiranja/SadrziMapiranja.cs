using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Pizza.Entiteti;

namespace Pizza.Mapiranja
{
    public class SadrziMapiranja : ClassMap<Sadrzi>
    {
        public SadrziMapiranja()
        {
            Table("SADRZI");

            Id(x => x.Id_surogat_sadrzi, "ID_SUROGAT_SADRZI").GeneratedBy.SequenceIdentity("SEQ_ID_SUROGAT_SADRZI");

            Map(x => x.Sastojci, "SASTOJCI");
            Map(x => x.Pojedinacna_cena, "POJEDINACNA_CENA");

            //many-to-one Sadrzi-Porudzbina
            References(x => x.Id_porudzbina).Column("ID_PORUDZBINA").LazyLoad();

            //many-to-one Sadrzi-Pizza
            References(x => x.Id_pizza).Column("ID_PIZZA").LazyLoad();
        }
    }
}
