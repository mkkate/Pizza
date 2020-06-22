using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PizzaDatabaseAccess.DTOs;

namespace PizzaDatabaseAccess.Mapiranja
{
    class DobijeniPoklonMapiranja : ClassMap<DobijeniPoklon>
    {
        public DobijeniPoklonMapiranja()
        {

            //Mapiranje tabele
            Table("DOBIJENI_POKLON");

            //mapiranje primarnog kljuca
            Id(x => x.Id_dodele, "ID_DODELE").GeneratedBy.Sequence("SEQ_ID_POKLON");

            //mapiranje svojstava
            Map(x => x.Kvalifikacioni_bodovi, "KVALIFIKACIONI_BODOVI");
            Map(x => x.Tip_poklona, "TIP_POKLONA");
            Map(x => x.Datum_dodele, "DATUM_DODELE");
            Map(x => x.Datum_iskoriscenja, "DATUM_ISKORISCENJA");

            //mapiranje veze 1:N Prodavnica-Odeljenje
            References(x => x.PripadaOsobi).Column("ID_OSOBA").LazyLoad();
        }
    }
}
