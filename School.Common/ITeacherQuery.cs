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
        void CreateTeacher(string name, string address, Gender gender, IList<SubjectModel> subjects, SchoolModel school);
        void UpdateTeacher(int id, TeacherModel currentModel);
        void DeleteTeacher(TeacherModel model);
        void DeleteTeacher(int id);
    }
}
