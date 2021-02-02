using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using School.Common;
using Entities;

namespace School.Infrastructures.NHibernate.Mappings
{
    public class StudentMap:ClassMap<StudentModel>
    {
        public StudentMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Address);
            Map(x => x.Gender);
            References(x => x.School);
            References(x => x.SchoolClass);
        }
    }
}
