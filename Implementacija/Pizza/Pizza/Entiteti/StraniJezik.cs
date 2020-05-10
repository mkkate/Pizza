using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Entiteti
{
    public class StraniJezik
    {
        public virtual int Id { get; protected set; }
        public virtual string NazivJezika { get; set; }

        public StraniJezik() { }

    }
}
