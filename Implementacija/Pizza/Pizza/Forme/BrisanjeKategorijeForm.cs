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
    public partial class BrisanjeKategorijeForm : Form
    {
        public BrisanjeKategorijeForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Pizza.Entiteti.Kategorija k = s.Load<Pizza.Entiteti.Kategorija>((int)upDownId.Value);
                
                s.Delete(k);

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
