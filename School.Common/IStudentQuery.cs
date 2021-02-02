using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common
{
    public interface IStudentQuery<T> where T:StudentModel
    {
        SchoolModel GetSchool(int studentId);
        SchoolClassModel GetClass(int studentId);
        void CreateStudent(string firstName, string lastName, SchoolClassModel schoolClass, Gender gender, string address, SchoolModel school);
        void UpdateStudent(int id, StudentModel currentModel);
        void DeleteStudent(StudentModel model);
        void DeleteStudent(int id);
    }
}
