using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class PrincipalModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
