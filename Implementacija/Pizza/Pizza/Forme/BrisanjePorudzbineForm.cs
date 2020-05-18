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
    public partial class BrisanjePorudzbineForm : Form
    {
        public BrisanjePorudzbineForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Porudzbina porudzbina = sesija.Load<Porudzbina>((int)nudIdPorudzbine.Value);
                
                sesija.Delete(porudzbina);

                sesija.Flush();

                sesija.Close();

                MessageBox.Show("Uspesno obrisana porudzbina ciji je id " + (int)nudIdPorudzbine.Value);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
