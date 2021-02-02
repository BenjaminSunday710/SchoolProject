using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using School.Common;
using Entities;

namespace School.Infrastructures.NHibernate.Mappings
{
    public class SchoolMap:ClassMap<SchoolModel>
    {
        public SchoolMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Location);
            References(x => x.Principal).Cascade.All();
            HasMany(x => x.SchoolClasses).Inverse().Cascade.All();
            HasMany(x => x.Students).Inverse().Cascade.All();
            HasMany(x => x.Teachers).Inverse().Cascade.All();
        }
    }
}
