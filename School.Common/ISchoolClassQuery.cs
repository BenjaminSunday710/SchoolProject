using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common
{
    public interface ISchoolClassQuery<T> where T:StudentModel
    {
        List<StudentModel> GetStudents(int schoolClassId);
        List<SubjectModel> GetSubjects(int schoolClassId);
        TeacherModel GetTeacher(int schoolClassId);
        int GetNumberofStudents(int schoolClassId);
        void CreateStudent(string name, SchoolModel school);
        void UpdateStudent(int id, SchoolClassModel currentModel);
        void DeleteStudent(SchoolClassModel model);
        void DeleteStudent(int id);
    }
}
