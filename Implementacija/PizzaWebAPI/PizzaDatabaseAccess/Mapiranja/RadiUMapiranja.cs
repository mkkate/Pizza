using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PizzaDatabaseAccess.DTOs;

namespace PizzaDatabaseAccess.Mapiranja
{
    class RadiUMapiranja : ClassMap<RadiU>
    {
        public RadiUMapiranja()
        {

            Table("RADI_U");

            Id(x => x.Id_surogat_radi_u, "ID_SUROGAT_RADI_U").GeneratedBy.Sequence("SEQ_ID_SUROGAT_RADI_U");

            References(x => x.Id_osoba).Column("ID_OSOBA");
            References(x => x.Id_smena).Column("ID_SMENA");

        }
    }
}
