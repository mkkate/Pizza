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
    public partial class BrisanjeTelefonaForm : Form
    {
        public BrisanjeTelefonaForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                BrTelefona broj = sesija.Load<BrTelefona>((int)nudIdBrojaTelefona.Value);

                sesija.Delete(broj);

                sesija.Flush();
                sesija.Close();

                MessageBox.Show("Uspesno obrisan broj telefona ciji je id " + (int)nudIdBrojaTelefona.Value);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
