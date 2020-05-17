using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Pizza.Entiteti;

namespace Pizza.Mapiranja
{
    class EmailMapiranja : ClassMap<Email>
    {
        public EmailMapiranja()
        {

            //Mapiranje tabele
            Table("EMAIL");

            //mapiranje primarnog kljuca
            Id(x => x.Id_surogat_email, "ID_SUROGAT_EMAIL").GeneratedBy.Sequence("SEQ_ID_SUROGAT_EMAIL");

            //mapiranje svojstava
            Map(x => x.Email_adresa, "EMAIL_ADRESA");

            //mapiranje veze 1:N Prodavnica-Odeljenje
            References(x => x.PripadaOsobi).Column("ID_OSOBA").LazyLoad();
        }
    }
}
