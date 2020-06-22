using System;
using System.Collections.Generic;
using System.Text;
using PizzaDatabaseAccess.DTOs;

namespace PizzaDatabaseAccess.DTOs
{
    public class StraniJezikView
    {
        public int Id { get; protected set; }
        public string NazivJezika { get; set; }

        public virtual IList<GovoriView> GStraniJezik { get; set; }

        public StraniJezikView()
        {
            GStraniJezik = new List<GovoriView>();
        }

        public StraniJezikView(StraniJezik s)
        {
            Id = s.Id;
            NazivJezika = s.NazivJezika;
        }
    }
}
