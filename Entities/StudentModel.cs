using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class StudentModel
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual SchoolModel School { get; set; }
        public virtual SchoolClassModel SchoolClass { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
