using NHibernate;
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

namespace Pizza.Forme
{
    public partial class OsobaForm : Form
    {
        public OsobaForm()
        {
            InitializeComponent();

            IList<String> listaRadnoMesto = new List<String>();
            listaRadnoMesto.Add("Primalac porudzbine");
            listaRadnoMesto.Add("Dostavljac");
            cmbRadnoMesto.DataSource = listaRadnoMesto;
            
            this.cmbRadnoMesto.Enabled = false;
            this.cmbRadnoMesto.Visible = false;
            this.lblRadnoMesto.Visible = false;
            this.groupBoxKupac.Visible = false;
            this.groupBoxZaposleni.Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Osoba osoba = new Osoba();

                osoba.Ime = this.txtIme.Text;
                osoba.Prezime = this.txtPrezime.Text;
                osoba.Ulica = this.txtUlica.Text;
                osoba.Broj = (int)this.nudBroj.Value;
                osoba.Grad = this.txtGrad.Text;
                osoba.Drzava = this.txtDrzava.Text;
                
                if (this.chkZaposleni.Checked)
                {
                    osoba.FZaposleni = 'T';
                    osoba.Jmbg = this.txtJMBG.Text;
                    osoba.Datum_rodjenja = this.dtpDatumRodjenja.Value;
                    if (cmbRadnoMesto.Text == "Primalac porudzbine")
                    {
                        osoba.FPrimalac_porudzbine = 'T';
                        osoba.FDostavljac = 'F';
                    }
                    else if (cmbRadnoMesto.Text == "Dostavljac")
                    {
                        osoba.FPrimalac_porudzbine = 'F';
                        osoba.FDostavljac = 'T';
                        Vozilo vozilo = sesija.Load<Vozilo>((int)this.nudIdVozila.Value);
                        osoba.DuziVozilo = vozilo;
                        vozilo.Osobe.Add(osoba);

                        sesija.SaveOrUpdate(vozilo);
                    }
                }
                else
                {
                    osoba.FZaposleni = 'F';
                    osoba.Jmbg = null;
                    osoba.Datum_rodjenja = null;
                    osoba.FDostavljac = 'F';
                    osoba.FPrimalac_porudzbine = 'F';
                }

                if (this.chkKupac.Checked)
                {
                    osoba.FKupac = 'T';
                    osoba.Datum_prve_porudzbine = this.dtpDatumPrvePorudzbine.Value;
                    if (rdbBonusProgramDa.Checked)
                    {
                        osoba.FBonus_program = 'T';
                        osoba.Br_bodova = (int)this.nudBrojBodova.Value;
                    }
                    else
                    {
                        osoba.FBonus_program = 'F';
                        osoba.Br_bodova = null;
                    }
                }
                else
                {
                    osoba.FKupac = 'F';
                    osoba.Datum_prve_porudzbine = null;
                    osoba.FBonus_program = 'F';
                    osoba.Br_bodova = null;
                }

                sesija.SaveOrUpdate(osoba);
                sesija.Flush();
                sesija.Close();

                MessageBox.Show("Uspesno dodata osoba");
                //reset polja
                osoba.Ime = String.Empty;
                osoba.Prezime = String.Empty;
                osoba.Ulica = String.Empty;
                osoba.Broj = 0;
                osoba.Grad = String.Empty;
                osoba.Drzava = String.Empty;
                osoba.Jmbg = null;
                osoba.Datum_rodjenja = null;
                osoba.Datum_prve_porudzbine = null;
                osoba.Br_bodova = null;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void chkKupac_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkKupac.Checked)
            {
                this.groupBoxKupac.Enabled = true;
                this.groupBoxKupac.Visible = true;
            }
            else
            {
                this.groupBoxKupac.Enabled = false;
                this.groupBoxKupac.Visible = false;
            }
        }

        private void chkZaposleni_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkZaposleni.Checked)
            {
                this.groupBoxZaposleni.Enabled = true;
                this.groupBoxZaposleni.Visible = true;
                this.cmbRadnoMesto.Enabled = true;
                this.cmbRadnoMesto.Visible = true;
                this.lblRadnoMesto.Visible = true;
            }
            else
            {
                this.groupBoxZaposleni.Enabled = false;
                this.groupBoxZaposleni.Visible = false;
                this.cmbRadnoMesto.Enabled = false;
                this.cmbRadnoMesto.Visible = false;
                this.lblRadnoMesto.Visible = false;
            }
        }

        private void cmbRadnoMesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRadnoMesto.Text=="Primalac porudzbine")
            {
                groupBoxPrimalacPorudzbine.Enabled = true;
                groupBoxPrimalacPorudzbine.Visible = true;

                groupBoxDostavljac.Enabled = false;
                groupBoxDostavljac.Visible = false;
            }
            else if(cmbRadnoMesto.Text == "Dostavljac")
            {
                groupBoxDostavljac.Enabled = true;
                groupBoxDostavljac.Visible = true;

                groupBoxPrimalacPorudzbine.Enabled = false;
                groupBoxPrimalacPorudzbine.Visible = false;
            }
        }
    }
}
