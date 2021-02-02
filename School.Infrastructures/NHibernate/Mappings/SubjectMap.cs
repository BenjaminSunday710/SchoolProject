using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using School.Common;
using Entities;

namespace School.Infrastructures.NHibernate.Mappings
{
    public class SubjectMap:ClassMap<SubjectModel>
    {
        public SubjectMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Teacher);
            References(x => x.SchoolClass);
            //HasMany(x => x.SchoolClasses).Inverse().Cascade.All();
        }
    }
}
