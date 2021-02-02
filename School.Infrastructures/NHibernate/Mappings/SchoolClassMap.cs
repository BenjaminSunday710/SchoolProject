using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using School.Common;
using Entities;

namespace School.Infrastructures.NHibernate.Mappings
{
    public class SchoolClassMap:ClassMap<SchoolClassModel>
    {
        public SchoolClassMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.ClassTeacher);
            References(x => x.School);
            HasMany(x => x.Subjects).Inverse().Cascade.All();
        }
    }
}
