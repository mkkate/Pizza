using NHibernate;
using Pizza;
using Pizza.Entiteti;
using PizzaDatabaseAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDatabaseAccess
{
    public class DataProvider
    {
        #region Vozila
        public static List<VoziloView> VratiSvaVozila()
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IList<Vozilo> listaVozila = sesija.QueryOver<Vozilo>()
                                             .OrderBy(x => x.Id_vozilo)
                                             .Asc.List<Vozilo>();
                List<VoziloView> vozilaView = new List<VoziloView>();

                foreach(Vozilo v in listaVozila)
                {
                    VoziloView vozilo = new VoziloView(v);
                    vozilaView.Add(vozilo);
                }

                sesija.Close();

                return vozilaView;
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static VoziloView VratiVozilo(int voziloID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Vozilo v = sesija.Get<Vozilo>(voziloID);

                if(v.GetType() == typeof(VoziloAutomobil))
                {
                    VoziloAutomobil va = v as VoziloAutomobil;
                    VoziloAutomobilView auto = new VoziloAutomobilView(va);

                    sesija.Close();
                    return auto;
                }
                else if (v.GetType() == typeof(VoziloSkuter))
                {
                    VoziloSkuter vs = v as VoziloSkuter;
                    VoziloSkuterView skuter = new VoziloSkuterView(vs);

                    sesija.Close();
                    return skuter;
                }
                else if (v.GetType() == typeof(VoziloBicikl))
                {
                    VoziloBicikl vb = v as VoziloBicikl;
                    VoziloBiciklView bicikl = new VoziloBiciklView(vb);

                    sesija.Close();
                    return bicikl;
                }

                VoziloView vozilo = new VoziloView(v);

                sesija.Close();

                return vozilo;
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiVozilo(int voziloID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Vozilo v = sesija.Get<Vozilo>(voziloID);

                sesija.Delete(v);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        #region VozilaBicikli
        public static void DodajVoziloBicikl(VoziloBiciklView vbv)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                VoziloBicikl bicikl = new VoziloBicikl();

                bicikl.Naziv_tipa = vbv.Naziv_tipa;
                bicikl.Proizvodjac = vbv.Proizvodjac;
                bicikl.Velicina_rama = vbv.Velicina_rama;
                bicikl.Registarski_broj = null;
                bicikl.Br_saobracajne_dozvole = null;

                sesija.Save(bicikl);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        #endregion

        #region VozilaAutomobili
        public static void DodajVoziloAutomobil(VoziloAutomobilView vav)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                VoziloAutomobil auto = new VoziloAutomobil();

                auto.Naziv_tipa = vav.Naziv_tipa;
                auto.Proizvodjac = vav.Proizvodjac;
                auto.Velicina_rama = null;
                auto.Registarski_broj = vav.Registarski_broj;
                auto.Br_saobracajne_dozvole = vav.Br_saobracajne_dozvole;

                sesija.Save(auto);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        #endregion

        #region VozilaSkuteri
        public static void DodajVoziloSkuter(VoziloSkuterView vsv)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                VoziloSkuter skuter = new VoziloSkuter();

                skuter.Naziv_tipa = vsv.Naziv_tipa;
                skuter.Proizvodjac = vsv.Proizvodjac;
                skuter.Velicina_rama = null;
                skuter.Registarski_broj = vsv.Registarski_broj;
                skuter.Br_saobracajne_dozvole = vsv.Br_saobracajne_dozvole;

                sesija.Save(skuter);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        #endregion
        #endregion

        #region Smena
        public static List<SmenaView> VratiSveSmene()
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IList<Smena> listaSmena = sesija.QueryOver<Smena>()
                                             .OrderBy(x => x.Id_smena)
                                             .Asc.List<Smena>();
                List<SmenaView> smeneView = new List<SmenaView>();

                foreach (Smena s in listaSmena)
                {
                    SmenaView smena = new SmenaView(s);
                    smeneView.Add(smena);
                }

                sesija.Close();

                return smeneView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static SmenaView VratiSmenu(int smenaID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Smena s = sesija.Get<Smena>(smenaID);

                if (s.GetType() == typeof(Smena1))
                {
                    Smena1 s1 = s as Smena1;
                    Smena1View smena1 = new Smena1View(s1);

                    sesija.Close();
                    return smena1;
                }
                else if (s.GetType() == typeof(Smena2))
                {
                    Smena2 s2 = s as Smena2;
                    Smena2View smena2 = new Smena2View(s2);

                    sesija.Close();
                    return smena2;
                }
                else if (s.GetType() == typeof(Smena3))
                {
                    Smena3 s3 = s as Smena3;
                    Smena3View smena3 = new Smena3View(s3);

                    sesija.Close();
                    return smena3;
                }

                SmenaView smena = new SmenaView(s);

                sesija.Close();

                return smena;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiSmenu(int smenaID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Smena smena = sesija.Get<Smena>(smenaID);

                sesija.Delete(smena);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        #endregion
    }
}
