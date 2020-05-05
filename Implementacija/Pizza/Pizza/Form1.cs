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
                ISession s = DataLayer.GetSession();

                VoziloAutomobil v = new VoziloAutomobil();

                v.Naziv_tipa = "Hecbek";
                v.Proizvodjac = "VW";
                v.Registarski_broj = "NI015VC";
                v.Br_saobracajne_dozvole = 181818;

                s.Save(v);  //u ovom trenutku se odradjuje naredba INSERT INTO
                            //to je zato sto kljuc baza autamatski generise, kada bi mi rucno unosili
                            //kljuc, u ovom trenutku se ne bi pozvala naredba INSERT INTO vec posle Flush()

                s.Flush();  //u slucaju da rucno unosimi kljuc, nakon ove metode se izvrsaa INSERT INTO
                s.Close();
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
                ISession sesija = DataLayer.GetSession();

                Vozilo v = sesija.Load<Vozilo>(24);
                
                sesija.Delete(v);

                sesija.Flush();

                sesija.Close();

                MessageBox.Show("Uspesno obrisano vozilo");
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
                ISession sesija = DataLayer.GetSession();

                Smena2 s2 = new Smena2();

                s2.Datum_od = "2019-06-03";
                s2.Datum_do = "2019-06-09";

                sesija.Save(s2);
                sesija.Flush();
                sesija.Close();
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
                ISession sesija = DataLayer.GetSession();

                Smena smena = sesija.Load<Smena>(21);

                sesija.Delete(smena);                
                
                sesija.Flush();

                sesija.Close();

                MessageBox.Show("Uspesno obrisana smena");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
