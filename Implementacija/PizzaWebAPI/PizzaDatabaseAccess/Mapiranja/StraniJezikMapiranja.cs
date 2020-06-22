using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;

namespace PizzaDatabaseAccess.Mapiranja
{
    class StraniJezikMapiranja: ClassMap<StraniJezik>
    {
        public StraniJezikMapiranja()
        {
            Table("STRANI_JEZIK");

            Id(x => x.Id, "ID_STRANI_JEZIK").GeneratedBy.Sequence("SEQ_ID_STRANI_JEZIK");

            Map(x => x.NazivJezika, "NAZIV_JEZIKA");
            HasMany(x => x.GStraniJezik).KeyColumn("ID_STRANI_JEZIK").LazyLoad().Cascade.All().Inverse();
        }
    }
}
