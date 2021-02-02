using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TeacherModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual SchoolModel School { get; set; }
        public virtual Gender Gender{ get; set; }
        public virtual IList<SubjectModel> Subjects { get; set; }

        public TeacherModel()
        {
            Subjects = new List<SubjectModel>();
        }
    }
}
