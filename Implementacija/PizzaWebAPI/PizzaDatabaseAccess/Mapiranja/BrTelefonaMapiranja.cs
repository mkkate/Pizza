using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PizzaDatabaseAccess.Entiteti;

namespace PizzaDatabaseAccess.Mapiranja
{
    public class BrTelefonaMapiranja : ClassMap<BrTelefona>
    {
        public BrTelefonaMapiranja()
        {
            Table("BR_TELEFONA");

            Id(x => x.Id_surogat_br_telefona, "ID_SUROGAT_BR_TELEFONA").GeneratedBy.SequenceIdentity("SEQ_ID_SUROGAT_BR_TELEFONA");

            Map(x => x.Broj_telefona, "BROJ_TELEFONA");

            //many-to-one BrTelefona-Osoba
            References(x => x.PripadaOsobi).Column("ID_OSOBA").LazyLoad();
        }
    }
}
