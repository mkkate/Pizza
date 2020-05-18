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
    public partial class BrojTelefonaForm : Form
    {
        public BrojTelefonaForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                BrTelefona brTel = new BrTelefona();

                brTel.Broj_telefona = this.txtBrojTelefona.Text;

                Osoba osoba = sesija.Load<Osoba>((int)nudIdOsobe.Value);
                brTel.PripadaOsobi = osoba;
                osoba.BrojeviTelefona.Add(brTel);
                sesija.SaveOrUpdate(osoba);

                sesija.SaveOrUpdate(brTel);
                sesija.Flush();
                sesija.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
