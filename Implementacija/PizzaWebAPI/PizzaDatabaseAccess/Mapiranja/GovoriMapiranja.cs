using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Pizza.Entiteti;

namespace Pizza.Mapiranja
{
    class GovoriMapiranja : ClassMap<Govori>
    {
        public GovoriMapiranja()
        {

            Table("GOVORI");

            Id(x => x.Id_surogat_govori, "ID_SUROGAT_GOVORI").GeneratedBy.Sequence("SEQ_ID_SUROGAT_GOVORI");

            Map(x => x.Nivo, "NIVO");

            References(x => x.Id_osoba).Column("ID_OSOBA");
            References(x => x.Id_strani_jezik).Column("ID_STRANI_JEZIK");
        }
    }
}
