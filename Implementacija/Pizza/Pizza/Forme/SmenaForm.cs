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
    public partial class SmenaForm : Form
    {
        public SmenaForm()
        {
            InitializeComponent();
        }
        
        private void btnDodajSmenu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                int tipSmene = (int)nudTipSmene.Value;

                DateTime datDo = dtpDatumOd.Value.AddDays(6);//od ponedeljka do nedelje je 6 dana

                switch (tipSmene)
                {
                    case 1:
                            Smena1 s1 = new Smena1();
                            s1.Datum_od = dtpDatumOd.Value;
                            s1.Datum_do = datDo;
                            sesija.Save(s1);
                            break;
                    case 2:
                            Smena2 s2 = new Smena2();
                            s2.Datum_od = dtpDatumOd.Value;
                            s2.Datum_do = datDo;
                            sesija.Save(s2);
                            break;
                    case 3:
                            Smena3 s3 = new Smena3();
                            s3.Datum_od = dtpDatumOd.Value;
                            s3.Datum_do = datDo;
                            sesija.Save(s3);
                            break;
                }
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        
    }
}
