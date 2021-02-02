using School.Common;
using School.Infrastructures.NHibernate;
using School.Infrastructures.EFcore;
using System;
using System.Collections.Generic;
using System.Text;
using School.Infrastructures.EFcore.DatabaseContextType;
using School.Infrastructures.NHibernate.DatabaseType;

namespace School.ConsoleMain
{
    public class ModelSupport<T> where T : class
    {
        public static IRepository<T> UseNHibernateSqLite() 
        {
            var sqLite = new SqLiteSessionFactoryCreator();
            var repo = new NHibernateRepository<T>(sqLite);
            return repo;
        }

        public static IRepository<T> UseNHibernateSqlServer()
        {
            var sqlServer = new SqlServerSessionFactoryCreator();
            var repo = new NHibernateRepository<T>(sqlServer);
            return repo;
        }

        public static IRepository<T> UseEFCoreSqLite()
        {
            SchoolDatabaseContext sqLite = new SqLiteDatabaseInitializer();
            var repo = new EFcoreRepository<T>(sqLite);
            return repo;
        }

        public static IRepository<T> UseEFCoreSqlServer()
        {
            SchoolDatabaseContext sqlServer = new SqlServerDatabaseInitializer();
            var repo = new EFcoreRepository<T>(sqlServer);
            return repo;
        }
    }
}
