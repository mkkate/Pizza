using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDatabaseAccess.Entiteti
{
    public class Email
    {
        public virtual int Id_surogat_email { get; protected set; }
        public virtual string Email_adresa { get; set; }
        public virtual Osoba PripadaOsobi { get; set; }
    }
}
