using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Pizza.Mapiranja;

namespace Pizza
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();

        //otvaranje sesije na zahtev
        public static ISession GetSession()
        {
            //Singleton obrazac uz sinhronizaciju niti
            if(_factory == null)
            {
                lock(objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }
            return _factory.OpenSession();
        }

        //konfiguracija i kreiranje session factory
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ConnectionString(c =>
                        c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;User Id=S16765;Password=picazakon"));

                return Fluently.Configure()
                    .Database(cfg.ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<VoziloMapiranja>())
                    .BuildSessionFactory();
            }
            catch(Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return null;
            }
        }
    }
}
