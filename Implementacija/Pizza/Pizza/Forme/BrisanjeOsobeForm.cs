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
    public partial class BrisanjeOsobeForm : Form
    {
        public BrisanjeOsobeForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Osoba osoba = sesija.Load<Osoba>((int)nudIdOsobe.Value);

                sesija.Delete(osoba);

                sesija.Flush();

                sesija.Close();

                MessageBox.Show("Uspesno obrisana osoba ciji je id " + (int)nudIdOsobe.Value);

                //reset polja
                nudIdOsobe.Value = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
