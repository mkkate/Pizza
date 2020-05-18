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
    public partial class AzurirajPorudzbinuForm : Form
    {
        public AzurirajPorudzbinuForm()
        {
            InitializeComponent();
            
            List<String> listaStatusa = new List<string>();
            listaStatusa.Add("isporucena");
            listaStatusa.Add("vracena");
            listaStatusa.Add("u pripremi");
            this.cmbStatus.DataSource = listaStatusa;

            dtpDatumVremeIsporuke.Visible = false;
            lblDatumVremeIsporuke.Visible = false;

            dtpDatumVremeIsporuke.Enabled = false;
            lblDatumVremeIsporuke.Enabled = false;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Porudzbina porudzbina = sesija.Load<Porudzbina>((int)nudIdPorudzbine.Value);

                porudzbina.Status = cmbStatus.Text;
                if (cmbStatus.Text == "isporucena")
                {
                    porudzbina.Datum_vreme_isporuke = dtpDatumVremeIsporuke.Value;
                }
                else
                {
                    porudzbina.Datum_vreme_isporuke = null;
                }

                sesija.SaveOrUpdate(porudzbina);
                sesija.Flush();
                sesija.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "isporucena")
            {
                dtpDatumVremeIsporuke.Visible = true;
                lblDatumVremeIsporuke.Visible = true;

                dtpDatumVremeIsporuke.Enabled = true;
                lblDatumVremeIsporuke.Enabled = true;
            }
            else
            {
                dtpDatumVremeIsporuke.Visible = false;
                lblDatumVremeIsporuke.Visible = false;

                dtpDatumVremeIsporuke.Enabled = false;
                lblDatumVremeIsporuke.Enabled = false;
            }
        }
    }
}
