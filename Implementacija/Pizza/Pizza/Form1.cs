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
                MessageBox.Show(v.Naziv_tipa + v.Tip_vozila);   //problem: vrednost Tip_vozila je null, ali zna da je rec o automobilu

                VoziloBicikl vb = s.Load<VoziloBicikl>(5);
                MessageBox.Show(vb.ToString());

                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDodavanjeNovogVozila_Click(object sender, EventArgs e)
        {
            try
            {
                VoziloForm voziloForma = new VoziloForm();

                voziloForma.ShowDialog();
                voziloForma.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
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
                    //problem: ne ispisuje vrednost tipa vozila, ali prepoznaje odgovarajuci tip i zna o kom tipu se radi
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
            try
            {
                BrisanjeVozilaForm voziloForma = new BrisanjeVozilaForm();

                voziloForma.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjeSmene_Click(object sender, EventArgs e)
        {
            try
            {
                SmenaForm novaSmena = new SmenaForm();

                novaSmena.ShowDialog();
                novaSmena.Close();
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnObrisiSmenu_Click(object sender, EventArgs e)
        {
            try
            {
                BrisanjeSmeneForm smenaForma = new BrisanjeSmeneForm();

                smenaForma.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajPicu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

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

        private void btnUcitajKategoriju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pizza.Entiteti.Kategorija k = s.Load<Pizza.Entiteti.Kategorija>(5);

                MessageBox.Show("Naziv: " + k.Kategorija_vozacke_dozvole + '\n' + "Pripada: " + k.PripadaOsobi.Ime +" " +k.PripadaOsobi.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajPoklon_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pizza.Entiteti.DobijeniPoklon p = s.Load<Pizza.Entiteti.DobijeniPoklon>(8);

                MessageBox.Show("Tip poklona: " + p.Tip_poklona 
                                + '\n' 
                                + "Datum dodele: " + p.Datum_dodele
                                + '\n'
                                + "Datum iskoriscenja: " + p.Datum_iskoriscenja
                                + '\n'
                                + "Broj bodova: " + p.Kvalifikacioni_bodovi
                                + '\n'
                                + "Pripada: " + p.PripadaOsobi.Ime + " " + p.PripadaOsobi.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajEmail_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pizza.Entiteti.Email m = s.Load<Pizza.Entiteti.Email>(5);

                MessageBox.Show("Email adresa: " + m.Email_adresa 
                              + '\n' 
                              + "Pripada: " + m.PripadaOsobi.Ime + " " + m.PripadaOsobi.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjeKategorije_Click(object sender, EventArgs e)
        {
            KategorijaForm kategorija = new KategorijaForm();
            kategorija.Show();
        }

        private void btnDodajPoklon_Click(object sender, EventArgs e)
        {
            DobijeniPoklonForm poklon = new DobijeniPoklonForm();
            poklon.Show();
        }

        private void btnDodajEmail_Click(object sender, EventArgs e)
        {
            EmailForm email = new EmailForm();
            email.Show();
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            BrisanjeKategorijeForm kategorija = new BrisanjeKategorijeForm();
            kategorija.Show();
        }

        private void btnObrisiPoklon_Click(object sender, EventArgs e)
        {
            BrisanjePoklonaForm poklon = new BrisanjePoklonaForm();
            poklon.Show();
        }

        private void btnObrisiEmail_Click(object sender, EventArgs e)
        {
            BrisanjeEmailaForm email = new BrisanjeEmailaForm();
            email.Show();
        }
    }
}
