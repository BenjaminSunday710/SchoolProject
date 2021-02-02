using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SubjectModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual TeacherModel Teacher { get; set; }
        public virtual SchoolClassModel SchoolClass { get; set; }
        //public virtual IList<SchoolClassModel> SchoolClasses { get; set; }

        public SubjectModel()
        {
            //SchoolClasses = new List<SchoolClassModel>();
        }
    }
}
