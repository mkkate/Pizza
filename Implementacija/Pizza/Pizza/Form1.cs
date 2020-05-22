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
using Pizza.Forme;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitavanjeVozila_Click(object sender, EventArgs e)
        {
            try
            {
                //otvaranje sesije
                ISession s = DataLayer.GetSession();
                //pokrece se unit of work obrazac za perzistenciju

                //ucitavanje podataka o vozilu sa zadatim id-jem
                Vozilo v = s.Load<Vozilo>(6);
                MessageBox.Show(v.ToString());

                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDodavanjeNovogVozila_Click(object sender, EventArgs e)
        {
            VoziloForm voziloForma = new VoziloForm();
            voziloForma.ShowDialog();
        }

        private void btnUcitavanjeSmene_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Smena smena = sesija.Load<Smena>(4);
                MessageBox.Show(smena.ToString());

                sesija.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnUcitajTPHInheritance_Click(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.GetSession();

            IList<Vozilo> vozila = sesija.QueryOver<Vozilo>().List<Vozilo>();

            foreach (Vozilo v in vozila)
            {
                if (v.GetType() == typeof(VoziloBicikl))
                {
                    VoziloBicikl vb = (VoziloBicikl)v;
                }
                else if (v.GetType() == typeof(VoziloSkuter))
                {
                    VoziloSkuter vs = (VoziloSkuter)v;
                }
                else if (v.GetType() == typeof(VoziloAutomobil))
                {
                    VoziloAutomobil va = (VoziloAutomobil)v;
                }
            }

            IList<Smena> smene = sesija.QueryOver<Smena>().List<Smena>();

            foreach (Smena s in smene)
            {
                if (s.GetType() == typeof(Smena1))
                {
                    Smena1 s1 = (Smena1)s;
                }
                else if (s.GetType() == typeof(Smena2))
                {
                    Smena2 s2 = (Smena2)s;
                }
                else if (s.GetType() == typeof(Smena3))
                {
                    Smena3 s3 = (Smena3)s;
                }
            }

            sesija.Close();
        }

        private void btnGetVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Get<Vozilo>(6);

                if (v != null)
                {
                    MessageBox.Show(v.ToString());
                }
                else
                {
                    MessageBox.Show("Ne postoji vozilo sa zadatim identifikatorom");
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            BrisanjeVozilaForm voziloForma = new BrisanjeVozilaForm();
            voziloForma.ShowDialog();
        }

        private void btnDodavanjeSmene_Click(object sender, EventArgs e)
        {
            SmenaForm novaSmena = new SmenaForm();

            novaSmena.ShowDialog();
        }

        private void btnObrisiSmenu_Click(object sender, EventArgs e)
        {
            BrisanjeSmeneForm smenaForma = new BrisanjeSmeneForm();

            smenaForma.ShowDialog();
        }

        private void btnUcitajPicu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Pizza.Entiteti.Pica p = s.Load<Pizza.Entiteti.Pica>(5);

                MessageBox.Show("Naziv: " + p.Naziv + '\n' + "Cena: " + p.Cena);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajJezik_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Pizza.Entiteti.StraniJezik j = s.Load<Pizza.Entiteti.StraniJezik>(5);

                MessageBox.Show("Naziv jezika: " + j.NazivJezika + '\n');

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnDodajPicu_Click(object sender, EventArgs e)
        {
            PicaForm novaPica = new PicaForm();
            novaPica.Show();
        }

        private void btnObrisiPicu_Click(object sender, EventArgs e)
        {
            BrisanjePiceForm brisiPicu = new BrisanjePiceForm();
            brisiPicu.Show();
        }

        private void btnDodajJezik_Click(object sender, EventArgs e)
        {
            StraniJezikForm dodajJezik = new StraniJezikForm();
            dodajJezik.Show();
        }

        private void btnObrisiJezik_Click(object sender, EventArgs e)
        {
            BrisanjeJezikaForm brisiJezik = new BrisanjeJezikaForm();
            brisiJezik.Show();
        }

        private void btnUcitajOsobu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Osoba osoba = sesija.Load<Osoba>(7);
                MessageBox.Show(osoba.Ime + " " + osoba.Prezime);

                sesija.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDodavanjeOsobe_Click(object sender, EventArgs e)
        {
            OsobaForm osoba = new OsobaForm();
            osoba.Show();
        }

        private void btnDodavanjePorudzbine_Click(object sender, EventArgs e)
        {
            PorudzbinaForm porudzbina = new PorudzbinaForm();
            porudzbina.Show();
        }

        private void btnAzurirajPorudzbinu_Click(object sender, EventArgs e)
        {
            AzurirajPorudzbinuForm azurirajPorudzbinu = new AzurirajPorudzbinuForm();
            azurirajPorudzbinu.Show();
        }

        private void btnObrisiPorudzbinu_Click(object sender, EventArgs e)
        {
            BrisanjePorudzbineForm brisanjePorudzbine = new BrisanjePorudzbineForm();
            brisanjePorudzbine.Show();
        }

        private void btnObrisiOsobu_Click(object sender, EventArgs e)
        {
            BrisanjeOsobeForm brisanjeOsobe = new BrisanjeOsobeForm();
            brisanjeOsobe.Show();
        }

        private void btnDodavanjeBrojaTelefona_Click(object sender, EventArgs e)
        {
            BrojTelefonaForm brTel = new BrojTelefonaForm();
            brTel.Show();
        }

        private void btnObrisiBrojTelefona_Click(object sender, EventArgs e)
        {
            BrisanjeTelefonaForm brisanjeTelefona = new BrisanjeTelefonaForm();
            brisanjeTelefona.Show();
        }
    }
}
