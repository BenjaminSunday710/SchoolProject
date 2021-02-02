using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SchoolClassModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual TeacherModel ClassTeacher { get; set; }
        public virtual SchoolModel School { get; set; }
        public virtual IList<SubjectModel> Subjects { get; set; }

        public SchoolClassModel()
        {
            Subjects = new List<SubjectModel>();
        }
    }
}
