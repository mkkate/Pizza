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
    public partial class DobijeniPoklonForm : Form
    {
        public DobijeniPoklonForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.DobijeniPoklon p = new Entiteti.DobijeniPoklon();


                p.Tip_poklona = cbTip.Text.ToString();
                if (!cbNije.Checked)
                {
                    p.Datum_iskoriscenja = DtIskoriscenje.Value;
                }
                else
                {
                    p.Datum_iskoriscenja = null;
                }

                p.Kvalifikacioni_bodovi = (int)UpDownBodovi.Value;
                p.Datum_dodele = dtDodela.Value;
                Pizza.Entiteti.Osoba o = s.Load<Pizza.Entiteti.Osoba>((int)UpDownId.Value);
                p.PripadaOsobi = o;
                o.DobijeniPokloni.Add(p);

                s.SaveOrUpdate(p);
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
