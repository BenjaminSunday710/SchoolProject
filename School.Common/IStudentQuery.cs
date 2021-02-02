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
    }
}
