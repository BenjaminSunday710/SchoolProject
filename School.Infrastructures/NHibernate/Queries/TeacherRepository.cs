using Entities;
using School.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NHibernate.Linq;

namespace School.Infrastructures.NHibernate.Queries
{
    public class TeacherRepository : NHibernateRepository<TeacherModel>, ITeacherQuery<TeacherModel>
    {
        public TeacherRepository(IDatabaseType databaseType) : base(databaseType)
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
                    transaction.Commit();
                }
            }
        }

        public void DeleteTeacher(TeacherModel model)
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

        public void DeleteSchoolClass(int teacherId)
        {
            SchoolClassModel schoolClass = new SchoolClassModel();
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    schoolClass = session.Get<SchoolClassModel>(teacherId);
                    session.Delete(schoolClass);
                    transaction.Commit();
                }
            }
        }

        public void DeleteSchoolClass(TeacherModel model)
        {
            throw new NotImplementedException();
        }

        public SchoolModel GetSchool(int teacherId)
        {
            SchoolModel school = new SchoolModel();
            using (var session=SessionFactory.OpenSession())
            {
                var teacher = session.Get<TeacherModel>(teacherId);
                school = teacher.School;
            }
            return school;
        }

        public List<SubjectModel> GetSubjects(int teacherId)
        {
            List<SubjectModel> subjects = new List<SubjectModel>();
            using (var session = SessionFactory.OpenSession())
            {
                subjects = session.Query<SubjectModel>().Where(s => s.Teacher.Id == teacherId).ToList();
            }
            return subjects;
        }

        public void UpdateSchoolClass(int id, TeacherModel currentModel)
        {
            throw new NotImplementedException();
        }
    }
}
