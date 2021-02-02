using Entities;
using School.Common;
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Linq;
using System.Linq;

namespace School.Infrastructures.NHibernate.Queries
{
    public class StudentRepository:NHibernateRepository<StudentModel>,IStudentQuery<StudentModel>
    {
        public StudentRepository(IDatabaseType databaseType) : base(databaseType)
        {
            var sessionFactory = base.SessionFactory;
        }

        public void CreateTeacher(string name, string address, Gender gender, IList<SubjectModel> subjects, SchoolModel school)
        {
            TeacherModel model = new TeacherModel();
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    model.Name = name;
                    model.School = school;
                    model.Address = address;
                    model.Gender = gender;
                    model.Subjects = subjects;
                    session.Save(model);
                    transaction.Commit();
                }
            }
        }

        public void DeleteStudent(StudentModel model)
        {
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(model);
                    transaction.Commit();
                }
            }
        }

        public void DeleteStudent(int studentId)
        {
            StudentModel student = new StudentModel();
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    student = session.Get<StudentModel>(studentId);
                    session.Delete(student);
                    transaction.Commit();
                }
            }
        }

        public SchoolClassModel GetClass(int studentId)
        {
            SchoolClassModel schoolClass = new SchoolClassModel();
            using (var session=SessionFactory.OpenSession())
            {
                var student = session.Get<StudentModel>(studentId);
                schoolClass = student.SchoolClass;
            }
            return schoolClass;
        }

        public SchoolModel GetSchool(int studentId)
        {
            SchoolModel school = new SchoolModel();
            using (var session = SessionFactory.OpenSession())
            {
                var student = session.Get<StudentModel>(studentId);
                school = student.School;
            }
            return school;
        }

        public void UpdateStudent(int studentId, StudentModel currentModel)
        {
            StudentModel prevModel = new StudentModel();
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    prevModel = session.Get<StudentModel>(studentId);
                    prevModel = currentModel;
                    session.Update(prevModel);
                    session.Save(prevModel);
                    transaction.Commit();
                }
            }
        }
    }
}
