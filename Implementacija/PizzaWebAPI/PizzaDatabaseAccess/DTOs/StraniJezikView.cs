using System;
using System.Collections.Generic;
using System.Text;
using Pizza.Entiteti;

namespace PizzaDatabaseAccess.DTOs
{
    public class StraniJezikView
    {
        public int Id { get; protected set; }
        public string NazivJezika { get; set; }

        public virtual IList<Govori> GStraniJezik { get; set; }

        public StraniJezikView()
        {
        }

        public StraniJezikView(StraniJezik s)
        {
            Id = s.Id;
            NazivJezika = s.NazivJezika;
        }
    }
}
