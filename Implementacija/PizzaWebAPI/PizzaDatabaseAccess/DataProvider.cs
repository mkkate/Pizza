using NHibernate;
using PizzaDatabaseAccess;
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
                    //ov.DuziVozilo = null;
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
                VoziloAutomobil v = sesija.Get<VoziloAutomobil>(voziloID);

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
                    osoba.DobijeniPokloni = VratiOsobinePoklone(o);
                    osoba.Emailovi = VratiOsobineEmailove(o);
                    osoba.Kategorije = VratiOsobineKategorije(o);
                    osoba.ORadiU = VratiGdeOsobaRadi(o);
                    osoba.OGovori = VratiStaGovoriOsoba(o);
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

                osobaView.DuziVozilo = new VoziloView(osoba.DuziVozilo);
                osobaView.BrojeviTelefona = VratiOsobineBrojeveTelefona(osoba);
                osobaView.Porudzbine = VratiOsobinePorudzbine(osoba);
                osobaView.DobijeniPokloni = VratiOsobinePoklone(osoba);
                osobaView.Emailovi = VratiOsobineEmailove(osoba);
                osobaView.Kategorije = VratiOsobineKategorije(osoba);
                osobaView.ORadiU = VratiGdeOsobaRadi(osoba);
                osobaView.OGovori = VratiStaGovoriOsoba(osoba);

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
                //if (voziloID != 0)
                //osoba.DuziVozilo = sesija.Get<Vozilo>(voziloID);
                DodajVoziloOsobi(ov, voziloID);
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
        public static void DodajVoziloOsobi(OsobaView o, int voziloID)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Osoba osoba = new Osoba();
                //osoba.Id_osoba = o.OsobaId;

                Vozilo v = sesija.Get<Vozilo>(voziloID);
                osoba.DuziVozilo = v;
                v.Osobe.Add(osoba);

                sesija.Update(v);
                sesija.Flush();

                sesija.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

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

        public static IList<DobijeniPoklonView> VratiOsobinePoklone(Osoba o)
        {
            IList<DobijeniPoklonView> listaDobijenihPoklona = new List<DobijeniPoklonView>();
            foreach (DobijeniPoklon dp in o.DobijeniPokloni)
            {
                DobijeniPoklonView dpv = new DobijeniPoklonView(dp);
                dpv.PripadaOsobi = null; //nepotrebno je da nam prikazuje osobu kojoj pripada
                listaDobijenihPoklona.Add(dpv);
            }
            return listaDobijenihPoklona;
        }

        public static IList<EmailView> VratiOsobineEmailove(Osoba o)
        {
            IList<EmailView> listaEmailova = new List<EmailView>();
            foreach (Email e in o.Emailovi)
            {
                EmailView ev = new EmailView(e);
                ev.PripadaOsobi = null; //nepotrebno je da nam prikazuje osobu kojoj pripada
                listaEmailova.Add(ev);
            }
            return listaEmailova;
        }

        public static IList<KategorijaView> VratiOsobineKategorije(Osoba o)
        {
            IList<KategorijaView> listaKategorija = new List<KategorijaView>();
            foreach (Kategorija k in o.Kategorije)
            {
                KategorijaView kv = new KategorijaView(k);
                kv.PripadaOsobi = null; //nepotrebno je da nam prikazuje osobu kojoj pripada
                listaKategorija.Add(kv);
            }
            return listaKategorija;
        }

        public static IList<RadiUView> VratiGdeOsobaRadi(Osoba o)
        {
            IList<RadiUView> listaRadiU = new List<RadiUView>();
            foreach (RadiU ru in o.ORadiU)
            {
                RadiUView ruv = new RadiUView(ru);
                ruv.Id_osoba = null; //nepotrebno je da nam prikazuje osobu kojoj pripada
                listaRadiU.Add(ruv);
            }
            return listaRadiU;
        }

        public static IList<GovoriView> VratiStaGovoriOsoba(Osoba o)
        {
            IList<GovoriView> listaGovori = new List<GovoriView>();
            foreach (Govori g in o.OGovori)
            {
                GovoriView gv = new GovoriView(g);
                gv.Id_osoba = null; //nepotrebno je da nam prikazuje osobu kojoj pripada
                listaGovori.Add(gv);
            }
            return listaGovori;
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
                //porudzbina.SadrziPice = VratiPorudzbininePice(poru);

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
                sadrzi.Id_porudzbina = sesija.Get<Porudzbina>(sadrziv.IdPorudzbina);
                sadrzi.Id_pizza = sesija.Get<Pica>(sadrziv.IdPizza);

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

        #region Pica
        public static List<PicaView> VratiSvePice()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Pica> listaPica = s.QueryOver<Pica>()
                                             .OrderBy(x => x.Id)
                                             .Asc.List<Pica>();
                List<PicaView> piceView = new List<PicaView>();

                foreach (Pica p in listaPica)
                {
                    PicaView pica = new PicaView(p);
                    piceView.Add(pica);
                }

                s.Close();

                return piceView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static PicaView VratiPicu(int picaID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pica p = s.Get<Pica>(picaID);


                PicaView pica = new PicaView(p);

                s.Close();

                return pica;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void DodajPicu(PicaView pica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pica p = new Pica
                {
                    Naziv = pica.Naziv,
                    Cena = pica.Cena
                };

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void ObrisiPicu(int picaID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pica p = s.Get<Pica>(picaID);

                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        public static void IzmeniPicu(PicaView pica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pica p = s.Load<Pica>(pica.Id);

                p.Naziv = pica.Naziv;
                p.Cena = pica.Cena;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        #endregion

        #region Strani jezik
        public static List<StraniJezikView> VratiSveJezike()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<StraniJezik> listaJezika = s.QueryOver<StraniJezik>()
                                             .OrderBy(x => x.Id)
                                             .Asc.List<StraniJezik>();
                List<StraniJezikView> jeziciView = new List<StraniJezikView>();

                foreach (StraniJezik j in listaJezika)
                {
                    StraniJezikView jezik = new StraniJezikView(j);
                    jeziciView.Add(jezik);
                }

                s.Close();

                return jeziciView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static StraniJezikView VratiJezik(int jezikID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StraniJezik j = s.Get<StraniJezik>(jezikID);


                StraniJezikView jezik = new StraniJezikView(j);

                s.Close();

                return jezik;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiJezik(int jezikID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StraniJezik jezik = s.Get<StraniJezik>(jezikID);

                s.Delete(jezik);
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        #endregion

        #region Dobijeni poklon
        public static List<DobijeniPoklonView> VratiSvePoklone()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<DobijeniPoklon> listaPoklona = s.QueryOver<DobijeniPoklon>()
                                             .OrderBy(x => x.Id_dodele)
                                             .Asc.List<DobijeniPoklon>();
                List<DobijeniPoklonView> pokloniView = new List<DobijeniPoklonView>();

                foreach (DobijeniPoklon p in listaPoklona)
                {
                    DobijeniPoklonView poklon = new DobijeniPoklonView(p);
                    pokloniView.Add(poklon);
                }

                s.Close();

                return pokloniView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static DobijeniPoklonView VratiPoklon(int poklonID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                DobijeniPoklon p = s.Get<DobijeniPoklon>(poklonID);


                DobijeniPoklonView poklon = new DobijeniPoklonView(p);

                s.Close();

                return poklon;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiPoklon(int poklonID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                DobijeniPoklon poklon = s.Get<DobijeniPoklon>(poklonID);

                s.Delete(poklon);
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        #endregion

        #region Kategorija
        public static List<KategorijaView> VratiSveKategorije()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Kategorija> listaKategorija = s.QueryOver<Kategorija>()
                                             .OrderBy(x => x.Id_surogat_kategorija)
                                             .Asc.List<Kategorija>();
                List<KategorijaView> kategorijeView = new List<KategorijaView>();

                foreach (Kategorija k in listaKategorija)
                {
                    KategorijaView kategorija = new KategorijaView(k);
                    kategorijeView.Add(kategorija);
                }

                s.Close();

                return kategorijeView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static KategorijaView VratiKategoriju(int kategorijaID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kategorija k = s.Get<Kategorija>(kategorijaID);


                KategorijaView kategorija = new KategorijaView(k);

                s.Close();

                return kategorija;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiKategoriju(int kategorijaID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kategorija kategorija = s.Get<Kategorija>(kategorijaID);

                s.Delete(kategorija);
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        #endregion

        #region Email
        public static List<EmailView> VratiSveEmailove()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Email> listaEmailova = s.QueryOver<Email>()
                                             .OrderBy(x => x.Id_surogat_email)
                                             .Asc.List<Email>();
                List<EmailView> emailoviView = new List<EmailView>();

                foreach (Email e in listaEmailova)
                {
                    EmailView email = new EmailView(e);
                    emailoviView.Add(email);
                }

                s.Close();

                return emailoviView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static EmailView VratiEmail(int emailID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Email e = s.Get<Email>(emailID);


                EmailView email = new EmailView(e);

                s.Close();

                return email;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiEmail(int emailID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Email email = s.Get<Email>(emailID);

                s.Delete(email);
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        #endregion

        #region Govori
        public static List<GovoriView> VratiSveGovori()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Govori> listaGovori = s.QueryOver<Govori>()
                                             .OrderBy(x => x.Id_surogat_govori)
                                             .Asc.List<Govori>();
                List<GovoriView> govoriView = new List<GovoriView>();

                foreach (Govori g in listaGovori)
                {
                    GovoriView govori = new GovoriView(g);
                    govoriView.Add(govori);
                }

                s.Close();

                return govoriView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static GovoriView VratiGovori(int govoriID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Govori g = s.Get<Govori>(govoriID);


                GovoriView govori = new GovoriView(g);

                s.Close();

                return govori;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiGovori(int govoriID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Govori govori = s.Get<Govori>(govoriID);

                s.Delete(govori);
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }

        #endregion

        #region Radi u
        public static List<RadiUView> VratiSveRadiU()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IList<RadiU> listaRadiU = s.QueryOver<RadiU>()
                                             .OrderBy(x => x.Id_surogat_radi_u)
                                             .Asc.List<RadiU>();
                List<RadiUView> radiUView = new List<RadiUView>();

                foreach (RadiU r in listaRadiU)
                {
                    RadiUView radiU = new RadiUView(r);
                    radiUView.Add(radiU);
                }

                s.Close();

                return radiUView;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static RadiUView VratiRadiU(int radiUID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RadiU r = s.Get<RadiU>(radiUID);


                RadiUView radiU = new RadiUView(r);

                s.Close();

                return radiU;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
        }
        public static void ObrisiRadiU(int radiUID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RadiU radiU = s.Get<RadiU>(radiUID);

                s.Delete(radiU);
                s.Flush();
                s.Close();
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
