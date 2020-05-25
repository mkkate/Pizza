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

namespace Pizza.Forme
{
    public partial class BrisanjeGovoriForm : Form
    {
        public BrisanjeGovoriForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Pizza.Entiteti.Govori g = s.Load<Pizza.Entiteti.Govori>((int)upDownId.Value);

                s.Delete(g);

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
