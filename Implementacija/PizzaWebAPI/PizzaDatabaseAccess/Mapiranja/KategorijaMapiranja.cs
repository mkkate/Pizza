using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PizzaDatabaseAccess.Entiteti;

namespace PizzaDatabaseAccess.Mapiranja
{
    class KategorijaMapiranja : ClassMap<Kategorija>
    {
        public KategorijaMapiranja()
        {

            //Mapiranje tabele
            Table("KATEGORIJA");

            //mapiranje primarnog kljuca
            Id(x => x.Id_surogat_kategorija, "ID_SUROGAT_KATEGORIJA").GeneratedBy.Sequence("SEQ_ID_SUROGAT_KATEGORIJA");

            //mapiranje svojstava
            Map(x => x.Kategorija_vozacke_dozvole, "KATEGORIJA_VOZACKE_DOZVOLE");

            //mapiranje veze 1:N Prodavnica-Odeljenje
            References(x => x.PripadaOsobi).Column("ID_OSOBA").LazyLoad();
        }
    }
}
