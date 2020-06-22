using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Pizza;
using Pizza.Entiteti;
using PizzaDatabaseAccess.DTOs;

namespace PizzaDatabaseAccess
{
    public class DataProvider
    {
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
