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
    public partial class BrisanjeSmeneForm : Form
    {
        public BrisanjeSmeneForm()
        {
            InitializeComponent();
        }

        private void btnObrisiSmenu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                
                int smenaId = (int)nudIdSmene.Value;

                Smena smena = sesija.Load<Smena>(smenaId);

                sesija.Delete(smena);

                sesija.Flush();

                sesija.Close();

                MessageBox.Show("Uspesno obrisana smena ciji je id " + smenaId);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
