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
    public partial class AzurirajPoklonForm : Form
    {
        public AzurirajPoklonForm()
        {
            InitializeComponent();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DobijeniPoklon p = s.Load<DobijeniPoklon>((int)upDownId.Value);


                p.Datum_iskoriscenja = dtIskoriscenje.Value;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();


                upDownId.Value = 0;
                dtIskoriscenje.Value = DateTime.Now;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
