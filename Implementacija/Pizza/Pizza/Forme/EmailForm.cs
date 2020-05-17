using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza.Entiteti;
using NHibernate;

namespace Pizza.Forme
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Email m = new Entiteti.Email();


                m.Email_adresa = tbAdresa.Text;
                Pizza.Entiteti.Osoba o = s.Load<Pizza.Entiteti.Osoba>((int)upDownId.Value);
                m.PripadaOsobi = o;
                o.Emailovi.Add(m);

                s.SaveOrUpdate(m);
                s.SaveOrUpdate(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
