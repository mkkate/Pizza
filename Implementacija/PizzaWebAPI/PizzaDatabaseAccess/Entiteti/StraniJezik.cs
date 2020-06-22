using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.Entiteti
{
    public class StraniJezik
    {
        public virtual int Id { get; protected set; }
        public virtual string NazivJezika { get; set; }

        public virtual IList<Govori> GStraniJezik { get; set; }

        public StraniJezik() {
            GStraniJezik = new List<Govori>();
        }

    }
}
