using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza.Entiteti;
using FluentNHibernate.Mapping;

namespace Pizza.Mapiranja
{
    public class SmenaMapiranja : ClassMap<Smena>
    {
        public SmenaMapiranja()
        {
            //mapiranje tabele
            Table("SMENA");

            //mapiranje kljuca
            Id(x => x.Id_smena, "ID_SMENA").GeneratedBy.SequenceIdentity("SEQ_ID_SMENA");   //.UnsavedValue(-1) ??

            //mapiranje propertija
            Map(x => x.Datum_od, "DATUM_OD");
            Map(x => x.Datum_do, "DATUM_DO");

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIP_SMENE");
        }
    }

    class Smena1Mapiranja : SubclassMap<Smena1>
    {
        public Smena1Mapiranja()
        {
            DiscriminatorValue('1');
        }
    }

    class Smena2Mapiranja : SubclassMap<Smena2>
    {
        public Smena2Mapiranja()
        {
            DiscriminatorValue('2');
        }
    }

    class Smena3Mapiranja : SubclassMap<Smena3>
    {
        public Smena3Mapiranja()
        {
            DiscriminatorValue('3');
        }
    }
}
