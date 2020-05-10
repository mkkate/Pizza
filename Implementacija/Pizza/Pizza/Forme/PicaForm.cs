using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Pizza.Entiteti;

namespace Pizza.Forme
{
    public partial class PicaForm : Form
    {
        public PicaForm()
        {
            InitializeComponent();
        }

        private void btnDodavanjePice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Pica p = new Entiteti.Pica();


                p.Naziv = tbNaziv.Text; //"Tuna pizza";
                p.Cena = float.Parse(tbCena.Text, CultureInfo.InvariantCulture.NumberFormat);

                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
