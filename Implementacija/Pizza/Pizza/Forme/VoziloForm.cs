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
    public partial class VoziloForm : Form
    {
        public VoziloForm()
        {
            InitializeComponent();
        }

        private void rdbAutomobil_CheckedChanged(object sender, EventArgs e)
        {
            this.nudVelicinaRama.Hide();
            this.lblVelicinaRama.Hide();
        }

        private void rdbSkuter_CheckedChanged(object sender, EventArgs e)
        {
            this.nudVelicinaRama.Hide();
            this.lblVelicinaRama.Hide();
        }

        private void rdbBicikl_CheckedChanged(object sender, EventArgs e)
        {
            this.lblRegistarskiBroj.Hide();
            this.txtRegistarskiBroj.Hide();
            this.lblBrSaobracanjeDozvole.Hide();
            this.nudBrSaobracajneDozvole.Hide();
        }
        
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                if(rdbAutomobil.Checked)
                {
                    VoziloAutomobil auto = new VoziloAutomobil();
                    auto.Naziv_tipa = txtNazivTipa.Text;
                    auto.Proizvodjac = txtProizvodjac.Text;
                    auto.Registarski_broj = txtRegistarskiBroj.Text;
                    auto.Br_saobracajne_dozvole = (int)nudBrSaobracajneDozvole.Value;

                    sesija.Save(auto);
                }
                else if(rdbSkuter.Checked)
                {
                    VoziloSkuter skuter = new VoziloSkuter();
                    skuter.Naziv_tipa = txtNazivTipa.Text;
                    skuter.Proizvodjac = txtProizvodjac.Text;
                    skuter.Registarski_broj = txtRegistarskiBroj.Text;
                    skuter.Br_saobracajne_dozvole = (int)nudBrSaobracajneDozvole.Value;

                    sesija.Save(skuter);
                }
                else if (rdbBicikl.Checked)
                {
                    VoziloBicikl bicikl = new VoziloBicikl();
                    bicikl.Naziv_tipa = txtNazivTipa.Text;
                    bicikl.Proizvodjac = txtProizvodjac.Text;
                    bicikl.Velicina_rama = (float)nudVelicinaRama.Value;

                    sesija.Save(bicikl);
                }
                else
                {
                    MessageBox.Show("Cekiraj tip vozila");
                }

                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
    }
}
