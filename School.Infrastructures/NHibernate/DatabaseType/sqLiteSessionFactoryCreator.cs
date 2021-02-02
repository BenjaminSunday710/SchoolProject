using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using School.Infrastructures.NHibernate.Mappings;

namespace School.Infrastructures.NHibernate.DatabaseType
{
    public class SqLiteSessionFactoryCreator : IDatabaseType
    {
        public ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("School.db"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SchoolMap>())
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
        }

        private static void BuildSchema(Configuration config)
        {
            if (!File.Exists("School.db"))
                new SchemaExport(config)
                  .Create(false, true);
        }
    }
}
