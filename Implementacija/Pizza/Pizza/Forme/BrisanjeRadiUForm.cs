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
    public partial class BrisanjeRadiUForm : Form
    {
        public BrisanjeRadiUForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Pizza.Entiteti.RadiU r = s.Load<Pizza.Entiteti.RadiU>((int)upDownId.Value);

                s.Delete(r);

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
