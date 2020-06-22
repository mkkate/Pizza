using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PizzaDatabaseAccess.Entiteti;

namespace PizzaDatabaseAccess.Mapiranja
{
    public class PorudzbinaMapiranja : ClassMap<Porudzbina>
    {
        public PorudzbinaMapiranja()
        {
            Table("PORUDZBINA");

            Id(x=>x.Id_porudzbina,"ID_PORUDZBINA").GeneratedBy.SequenceIdentity("SEQ_ID_PORUDZBINA");

            Map(x => x.Cena, "CENA");
            Map(x => x.Nacin_placanja, "NACIN_PLACANJA");
            Map(x => x.Status, "STATUS");
            Map(x => x.Datum_vreme_isporuke, "DATUM_VREME_ISPORUKE");
            Map(x => x.Datum_vreme_kreiranja, "DATUM_VREME_KREIRANJA");

            // many-to-one; Porudzbina-Osoba
            // fk mapiranje
            References(x => x.PripadaOsobi).Column("ID_OSOBA").LazyLoad();

            // many-to-one Porudzbina-Vozilo
            References(x => x.DostavljanoVozilom).Column("ID_VOZILO").LazyLoad();

            //one-to-many Porudzbina-Sadrzi (Pizza)
            HasMany(x => x.SadrziPice).KeyColumn("ID_PORUDZBINA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
