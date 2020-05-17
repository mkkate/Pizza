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
    public partial class BrisanjeEmailaForm : Form
    {
        public BrisanjeEmailaForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Pizza.Entiteti.Email m = s.Load<Pizza.Entiteti.Email>((int)upDownId.Value);

                s.Delete(m);

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
