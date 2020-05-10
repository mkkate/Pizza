using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza.Entiteti;
using FluentNHibernate.Mapping;

namespace Pizza.Mapiranja
{
    class PicaMapiranja : ClassMap<Pica>
    {
        public PicaMapiranja()
        {
            Table("PIZZA");

            Id(x => x.Id, "ID_PIZZA").GeneratedBy.Sequence("SEQ_ID_PIZZA");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Cena, "CENA");

        }
    }
}
