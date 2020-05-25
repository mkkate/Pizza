using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Pizza.Entiteti;

namespace Pizza.Forme
{
    public partial class KategorijaForm : Form
    {
        public KategorijaForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Kategorija k = new Entiteti.Kategorija();


                k.Kategorija_vozacke_dozvole = tbKategorija.Text;
                Pizza.Entiteti.Osoba o = s.Load<Pizza.Entiteti.Osoba>((int)UpDownId.Value);
                k.PripadaOsobi = o;
                o.Kategorije.Add(k);

                s.SaveOrUpdate(k);
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
