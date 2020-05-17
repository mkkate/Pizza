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
using NHibernate;

namespace Pizza.Forme
{
    public partial class BrisanjePoklonaForm : Form
    {
        public BrisanjePoklonaForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Pizza.Entiteti.DobijeniPoklon p = s.Load<Pizza.Entiteti.DobijeniPoklon>((int)upDownId.Value);

                s.Delete(p);

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
