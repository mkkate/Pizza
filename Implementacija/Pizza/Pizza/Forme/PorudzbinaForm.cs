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
    public partial class PorudzbinaForm : Form
    {
        public PorudzbinaForm()
        {
            InitializeComponent();

            List<String> listaNacinaPlacanja = new List<string>();
            listaNacinaPlacanja.Add("gotovina");
            listaNacinaPlacanja.Add("kartica");
            this.cmbNacinPlacanja.DataSource = listaNacinaPlacanja;

            List<String> listaStatusa = new List<string>();
            listaStatusa.Add("isporucena");
            listaStatusa.Add("vracena");
            listaStatusa.Add("u pripremi");
            this.cmbStatus.DataSource = listaStatusa;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Pica pica = sesija.Load<Pica>((int)nudPicaId.Value);

                Porudzbina porudzbina = new Porudzbina();

                porudzbina.Cena = pica.Cena * (int)nudKolicina.Value;
                lblObracunataCena.Text = porudzbina.Cena.ToString();

                porudzbina.Nacin_placanja = cmbNacinPlacanja.Text;
                porudzbina.Status = cmbStatus.Text;
                porudzbina.Datum_vreme_kreiranja = dtpDatumVremeKreiranja.Value;

                Osoba osoba = sesija.Load<Osoba>((int)nudIdOsobe.Value);

                porudzbina.PripadaOsobi = osoba;
                osoba.Porudzbine.Add(porudzbina);
                sesija.SaveOrUpdate(osoba);

                Vozilo vozilo = sesija.Load<Vozilo>((int)nudIdVozila.Value);
                porudzbina.DostavljanoVozilom = vozilo;

                vozilo.Porudzbine.Add(porudzbina);
                sesija.SaveOrUpdate(vozilo);

                sesija.SaveOrUpdate(porudzbina);

                //veza m:n (Porudzbina-Pizza)
                // kreiranje u tabeli Sadrzi
                Sadrzi sadrzi = new Sadrzi();
                sadrzi.Id_pizza = pica;
                sadrzi.Id_porudzbina = porudzbina;
                sadrzi.Sastojci = txtSastojci.Text;
                sadrzi.Pojedinacna_cena = pica.Cena;
                sesija.Save(sadrzi);


                sesija.Flush();
                sesija.Close();

                //reset polja
                cmbNacinPlacanja.Text = "";
                cmbStatus.Text = "";
                dtpDatumVremeKreiranja.Value = DateTime.Now;
                nudIdOsobe.Value = 0;
                nudIdVozila.Value = 0;
                nudPicaId.Value = 0;
                nudKolicina.Value = 0;
                txtSastojci.Text = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
