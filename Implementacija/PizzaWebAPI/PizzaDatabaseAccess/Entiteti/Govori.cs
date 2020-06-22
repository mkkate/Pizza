using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.DTOs
{
    public class Govori
    {
        public virtual int Id_surogat_govori { get; protected set; }

        public virtual string Nivo { get; set; }

        public virtual StraniJezik Id_strani_jezik { get; set; }

        public virtual Osoba Id_osoba { get; set; }

        public Govori()
        {

        }
    }
}
