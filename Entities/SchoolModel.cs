using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SchoolModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Location { get; set; }
        public virtual PrincipalModel Principal { get; set; }
        public virtual IList<StudentModel> Students { get; set; }
        public virtual IList<TeacherModel> Teachers { get; set; }
        public virtual IList<SchoolClassModel> SchoolClasses { get; set; }

        public SchoolModel()
        {
            Students = new List<StudentModel>();
            Teachers = new List<TeacherModel>();
            SchoolClasses = new List<SchoolClassModel>();
        }
    }
}
