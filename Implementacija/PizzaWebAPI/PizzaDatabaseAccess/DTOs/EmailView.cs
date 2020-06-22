using System;
using System.Collections.Generic;
using System.Text;
using PizzaDatabaseAccess.Entiteti;

namespace PizzaDatabaseAccess.DTOs
{
    public class EmailView
    {
        public int Id_surogat_email { get; protected set; }
        public string Email_adresa { get; set; }
        public OsobaView PripadaOsobi { get; set; }

        public EmailView() { }

        public EmailView(Email e)
        {
            Id_surogat_email = e.Id_surogat_email;
            Email_adresa = e.Email_adresa;
            PripadaOsobi = new OsobaView(e.PripadaOsobi);
        }
    }
}
