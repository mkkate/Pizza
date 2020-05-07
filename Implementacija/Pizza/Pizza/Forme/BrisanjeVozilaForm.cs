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
    public partial class BrisanjeVozilaForm : Form
    {
        public BrisanjeVozilaForm()
        {
            InitializeComponent();
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                int voziloId = (int)nudIdVozila.Value;

                Vozilo vozilo = sesija.Load<Vozilo>(voziloId);

                sesija.Delete(vozilo);

                sesija.Flush();

                sesija.Close();

                MessageBox.Show("Uspesno obrisano vozilo ciji je id " + voziloId);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
