using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using School.Infrastructures.NHibernate.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructures.NHibernate.DatabaseType
{
    public class SqlServerSessionFactoryCreator:IDatabaseType
    {
        public ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NHibernateSchoolDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SchoolMap>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, true))
                .BuildSessionFactory();
        }
        
    }
}
