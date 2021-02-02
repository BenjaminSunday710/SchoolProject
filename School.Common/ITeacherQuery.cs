using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common
{
    public interface ITeacherQuery<T> where T:TeacherModel
    {
        SchoolModel GetSchool(int id);
        List<SubjectModel> GetSubjects(int id);
    }
}
