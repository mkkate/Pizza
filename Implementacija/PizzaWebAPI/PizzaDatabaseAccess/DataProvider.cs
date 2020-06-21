using NHibernate;
using PizzaDatabaseAccess;
using PizzaDatabaseAccess.Entiteti;
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

                foreach (Vozilo v in listaVozila)
                {
                    if (v.GetType() == typeof(VoziloAutomobil))
                    {
                        VoziloAutomobil va = v as VoziloAutomobil;
                        VoziloAutomobilView auto = new VoziloAutomobilView(va);
                        auto.Osobe = VratiVoziloveOsobe(va);

                        vozilaView.Add(auto);
                    }
                    else if (v.GetType() == typeof(VoziloSkuter))
                    {
                        VoziloSkuter vs = v as VoziloSkuter;
                        VoziloSkuterView skuter = new VoziloSkuterView(vs);
                        skuter.Osobe = VratiVoziloveOsobe(vs);

                        vozilaView.Add(skuter);
                    }
                    else if (v.GetType() == typeof(VoziloBicikl))
                    {
                        VoziloBicikl vb = v as VoziloBicikl;
                        VoziloBiciklView bicikl = new VoziloBiciklView(vb);
                        bicikl.Osobe = VratiVoziloveOsobe(vb);

                        vozilaView.Add(bicikl);
                    }
                }

                sesija.Close();

                return vozilaView;
            }
            catch (Exception exc)
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

                if (v.GetType() == typeof(VoziloAutomobil))
                {
                    VoziloAutomobil va = v as VoziloAutomobil;
                    VoziloAutomobilView auto = new VoziloAutomobilView(va);
                    auto.Osobe = VratiVoziloveOsobe(v);

                    sesija.Close();
                    return auto;
                }
                else if (v.GetType() == typeof(VoziloSkuter))
                {
                    VoziloSkuter vs = v as VoziloSkuter;
                    VoziloSkuterView skuter = new VoziloSkuterView(vs);
                    skuter.Osobe = VratiVoziloveOsobe(v);

                    sesija.Close();
                    return skuter;
                }
                else if (v.GetType() == typeof(VoziloBicikl))
                {
                    VoziloBicikl vb = v as VoziloBicikl;
                    VoziloBiciklView bicikl = new VoziloBiciklView(vb);

                    bicikl.Osobe = VratiVoziloveOsobe(v);

                    sesija.Close();
                    return bicikl;
                }

                VoziloView vozilo = new VoziloView(v);

                sesija.Close();

                return vozilo;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static IList<OsobaView> VratiVoziloveOsobe(Vozilo v)
        {
            try
            {
                IList<OsobaView> listaOsoba = new List<OsobaView>();
                foreach (Osoba o in v.Osobe)
                {
                    OsobaView ov = new OsobaView(o);
                    ov.DuziVozilo = null;
                    listaOsoba.Add(ov);
                }
                return listaOsoba;
            }
            catch (Exception exc)
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
                    if (s.GetType() == typeof(Smena1))
                    {
                        Smena1 s1 = s as Smena1;
                        Smena1View smena1 = new Smena1View(s1);
                        smeneView.Add(smena1);
                    }
                    else if (s.GetType() == typeof(Smena2))
                    {
                        Smena2 s2 = s as Smena2;
                        Smena2View smena2 = new Smena2View(s2);
                        smeneView.Add(smena2);
                    }
                    else if (s.GetType() == typeof(Smena3))
                    {
                        Smena3 s3 = s as Smena3;
                        Smena3View smena3 = new Smena3View(s3);
                        smeneView.Add(smena3);
                    }
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
        #region Smena1
        public static void DodajSmenu1(Smena1View s1)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Smena1 smena1 = new Smena1();

                smena1.Datum_od = s1.Datum_od;
                smena1.Datum_do = s1.Datum_do;

                sesija.Save(smena1);
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
        #region Smena2
        public static void DodajSmenu2(Smena2View s2)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Smena2 smena2 = new Smena2();

                smena2.Datum_od = s2.Datum_od;
                smena2.Datum_do = s2.Datum_do;

                sesija.Save(smena2);
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
        #region Smena3
        public static void DodajSmenu3(Smena3View s3)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Smena3 smena3 = new Smena3();

                smena3.Datum_od = s3.Datum_od;
                smena3.Datum_do = s3.Datum_do;

                sesija.Save(smena3);
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

        #region Osoba
        public static List<OsobaView> VratiSveOsobe()
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IList<Osoba> listaOsoba = sesija.QueryOver<Osoba>()
                                             .OrderBy(x => x.Id_osoba)
                                             .Asc.List<Osoba>();
                List<OsobaView> osobeView = new List<OsobaView>();

                foreach (Osoba o in listaOsoba)
                {
                    OsobaView osoba = new OsobaView(o);
                    osoba.Porudzbine = VratiOsobinePorudzbine(o);
                    osoba.BrojeviTelefona = VratiOsobineBrojeveTelefona(o);
                    osobeView.Add(osoba);
                }

                sesija.Close();

                return osobeView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static OsobaView VratiOsobu(int osobaID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Osoba osoba = sesija.Get<Osoba>(osobaID);
                OsobaView osobaView = new OsobaView(osoba);

                osobaView.BrojeviTelefona = VratiOsobineBrojeveTelefona(osoba);
                osobaView.Porudzbine = VratiOsobinePorudzbine(osoba);

                sesija.Close();

                return osobaView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiOsobu(int osobaID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Osoba o = sesija.Get<Osoba>(osobaID);

                sesija.Delete(o);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void DodajOsobu(OsobaView ov, int voziloID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Osoba osoba = new Osoba();

                osoba.Broj = ov.Broj;
                osoba.Br_bodova = ov.Br_bodova;
                osoba.Datum_prve_porudzbine = ov.Datum_prve_porudzbine;
                osoba.Datum_rodjenja = ov.Datum_rodjenja;
                osoba.Drzava = ov.Drzava;
                if (voziloID != 0)
                    osoba.DuziVozilo = sesija.Get<Vozilo>(voziloID);
                osoba.FBonus_program = ov.FBonus_program;
                osoba.FDostavljac = ov.FDostavljac;
                osoba.FKupac = ov.FKupac;
                osoba.FPrimalac_porudzbine = ov.FPrimalac_porudzbine;
                osoba.FZaposleni = ov.FZaposleni;
                osoba.Grad = ov.Grad;
                osoba.Ime = ov.Ime;
                osoba.Jmbg = ov.Jmbg;
                osoba.Prezime = ov.Prezime;
                osoba.Ulica = ov.Ulica;

                sesija.Save(osoba);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        // PROVERI !!!
        /*public static void DodajVoziloOsobi(OsobaView o, int voziloID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                //Osoba osoba = new Osoba();
                //osoba.Id_osoba = o.OsobaId;

                VoziloView v = sesija.Get<VoziloView>(voziloID);
                o.DuziVozilo = v;
                v.Osobe.Add(o);

                sesija.Update(v);
                sesija.Flush();

                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }*/

        public static IList<PorudzbinaView> VratiOsobinePorudzbine(Osoba o)
        {
            IList<PorudzbinaView> listaPorudzbina = new List<PorudzbinaView>();
            foreach (Porudzbina p in o.Porudzbine)
            {
                PorudzbinaView pv = new PorudzbinaView(p);
                pv.PripadaOsobi = null; //nepotrebno je da nam prikazuje osobu kojoj pripada
                listaPorudzbina.Add(pv);
            }
            return listaPorudzbina;
        }

        public static IList<BrTelefonaView> VratiOsobineBrojeveTelefona(Osoba o)
        {
            IList<BrTelefonaView> listaBrTel = new List<BrTelefonaView>();
            foreach (BrTelefona brtel in o.BrojeviTelefona)
            {
                BrTelefonaView brtelv = new BrTelefonaView(brtel);
                brtelv.PripadaOsobi = null; //nepotrebno je da nam prikazuje osobu kojoj pripada
                listaBrTel.Add(brtelv);
            }
            return listaBrTel;
        }
        #endregion

        #region Porudzbina
        public static List<PorudzbinaView> VratiSvePorudzbine()
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IList<Porudzbina> listaPorudzbina = sesija.QueryOver<Porudzbina>()
                                             .OrderBy(x => x.Id_porudzbina)
                                             .Asc.List<Porudzbina>();
                List<PorudzbinaView> porudzbineView = new List<PorudzbinaView>();

                foreach (Porudzbina p in listaPorudzbina)
                {
                    PorudzbinaView porudzbina = new PorudzbinaView(p);
                    porudzbina.SadrziPice = VratiPorudzbininePice(p);
                    porudzbineView.Add(porudzbina);
                }

                sesija.Close();

                return porudzbineView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static PorudzbinaView VratiPorudzbinu(int porudzbinaID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Porudzbina porudzbina = sesija.Get<Porudzbina>(porudzbinaID);
                PorudzbinaView porudzbinaView = new PorudzbinaView(porudzbina);

                porudzbinaView.SadrziPice = VratiPorudzbininePice(porudzbina);

                sesija.Close();

                return porudzbinaView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiPorudzbinu(int porudzbinaID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Porudzbina porudzbina = sesija.Get<Porudzbina>(porudzbinaID);

                sesija.Delete(porudzbina);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        public static void DodajPorudzbinu(PorudzbinaView pv, int osobaID, int voziloID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Porudzbina porudzbina = new Porudzbina();

                porudzbina.Cena = pv.Cena;
                porudzbina.Datum_vreme_isporuke = pv.Datum_vreme_isporuke;
                porudzbina.Datum_vreme_kreiranja = pv.Datum_vreme_kreiranja;
                porudzbina.Nacin_placanja = pv.Nacin_placanja;
                porudzbina.Status = pv.Status;
                porudzbina.DostavljanoVozilom = sesija.Get<Vozilo>(voziloID);
                porudzbina.PripadaOsobi = sesija.Get<Osoba>(osobaID);
                //porudzbina.SadrziPice = pv.SadrziPice;

                sesija.Save(porudzbina);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        // PROVERI !!!
        public static IList<SadrziView> VratiPorudzbininePice(Porudzbina p)
        {
            IList<SadrziView> listaPica = new List<SadrziView>();
            foreach (Sadrzi s in p.SadrziPice)
            {
                SadrziView sv = new SadrziView(s);
                listaPica.Add(sv);
            }
            return listaPica;
        }
        #endregion

        #region BrTelefona
        public static List<BrTelefonaView> VratiSveBrojeveTelefona()
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IList<BrTelefona> listaBrTelefona = sesija.QueryOver<BrTelefona>()
                                             .OrderBy(x => x.Id_surogat_br_telefona)
                                             .Asc.List<BrTelefona>();
                List<BrTelefonaView> brtelView = new List<BrTelefonaView>();

                foreach (BrTelefona brtel in listaBrTelefona)
                {
                    BrTelefonaView brtelv = new BrTelefonaView(brtel);
                    brtelView.Add(brtelv);
                }

                sesija.Close();

                return brtelView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static BrTelefonaView VratiBrojTelefona(int brtelID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                BrTelefona brtel = sesija.Get<BrTelefona>(brtelID);
                BrTelefonaView brtelView = new BrTelefonaView(brtel);

                sesija.Close();

                return brtelView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiBrojTelefona(int brtelID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                BrTelefona brtel = sesija.Get<BrTelefona>(brtelID);

                sesija.Delete(brtel);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void DodajBrojTelefona(BrTelefonaView brtelv, int osobaID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                BrTelefona brtel = new BrTelefona();
                brtel.Broj_telefona = brtelv.BrojTelefona;

                Osoba o = sesija.Get<Osoba>(osobaID);
                brtel.PripadaOsobi = o;
                o.BrojeviTelefona.Add(brtel);

                sesija.Update(o);
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

        #region Sadrzi
        public static List<SadrziView> VratiSveSadrzaje()
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IList<Sadrzi> listaSadrzi = sesija.QueryOver<Sadrzi>()
                                             .OrderBy(x => x.Id_surogat_sadrzi)
                                             .Asc.List<Sadrzi>();
                List<SadrziView> sadrziView = new List<SadrziView>();

                foreach (Sadrzi s in listaSadrzi)
                {
                    SadrziView sv = new SadrziView(s);
                    sadrziView.Add(sv);
                }

                sesija.Close();

                return sadrziView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static SadrziView VratiSadrzaj(int sadrziID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Sadrzi sadrzi = sesija.Get<Sadrzi>(sadrziID);
                SadrziView sadrziView = new SadrziView(sadrzi);

                sesija.Close();

                return sadrziView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiSadrzaj(int sadrziID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sadrzi sadrzi = sesija.Get<Sadrzi>(sadrziID);

                sesija.Delete(sadrzi);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void DodajSadrzaj(SadrziView sadrziv)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sadrzi sadrzi = new Sadrzi();

                sadrzi.Pojedinacna_cena = sadrziv.PojedinacnaCena;
                sadrzi.Sastojci = sadrziv.Sastojci;
                //sadrzi.Id_porudzbina = new Porudzbina(sadrziv.IdPorudzbina);
                //sadrzi.Id_pizza = new Pizza(sadrziv.IdPizza);

                sesija.Save(sadrzi);
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
