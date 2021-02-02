using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;

namespace School.Infrastructures.NHibernate
{
    public interface IDatabaseType
    {
        ISessionFactory CreateSessionFactory();
    }
}
