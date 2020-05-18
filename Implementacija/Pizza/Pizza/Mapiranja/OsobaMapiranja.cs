using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Pizza.Entiteti;

namespace Pizza.Mapiranja
{
    public class OsobaMapiranja : ClassMap<Osoba>
    {
        public OsobaMapiranja()
        {
            Table("OSOBA");

            Id(x => x.Id_osoba, "ID_OSOBA").GeneratedBy.SequenceIdentity("SEQ_ID_OSOBA");
            
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Drzava, "DRZAVA");
            Map(x => x.Jmbg, "JMBG");
            Map(x => x.Datum_rodjenja, "DATUM_RODJENJA");
            Map(x => x.Datum_prve_porudzbine, "DATUM_PRVE_PORUDZBINE");
            Map(x => x.Br_bodova, "BR_BODOVA");

            Map(x => x.FZaposleni, "FZAPOSLENI");
            Map(x => x.FPrimalac_porudzbine, "FPRIMALAC_PORUDZBINE");
            Map(x => x.FDostavljac, "FDOSTAVLJAC");
            Map(x => x.FKupac, "FKUPAC");
            Map(x => x.FBonus_program, "FBONUS_PROGRAM");

            //many-to-one Osoba-Vozilo
            References(x => x.DuziVozilo).Column("ID_VOZILO").LazyLoad();

            //one-to-many Osoba-Porudzbina
            HasMany(x => x.Porudzbine).KeyColumn("ID_OSOBA").Cascade.All().Inverse();

            //one-to-many Osoba-BrTelefona
            HasMany(x => x.BrojeviTelefona).KeyColumn("ID_OSOBA").Cascade.All().Inverse();
        }
    }
}
