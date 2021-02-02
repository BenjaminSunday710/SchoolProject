using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public enum Gender{ Male, Female }

    public interface IEntities
    {
       int Id { get; set; }
    }
}
