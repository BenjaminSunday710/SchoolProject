using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using School.Common;
using Entities;

namespace School.Infrastructures.NHibernate.Mappings
{
    public class TeacherMap:ClassMap<TeacherModel>
    {
        public TeacherMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            Map(x => x.Gender);
            References(x => x.School);
            HasMany(x => x.Subjects).Inverse().Cascade.All();
        }
    }
}
