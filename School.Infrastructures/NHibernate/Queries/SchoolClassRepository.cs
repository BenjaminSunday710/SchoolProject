using Entities;
using School.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NHibernate.Linq;

namespace School.Infrastructures.NHibernate.Queries
{
    public class SchoolClassRepository: NHibernateRepository<SchoolClassModel>,ISchoolClassQuery<SchoolClassModel>
    {
        public SchoolClassRepository(IDatabaseType databaseType):base(databaseType)
        {
            var sessionFactory = base.SessionFactory;
        }

        public void CreateSchoolClass(string name, SchoolModel school)
        {
            SchoolClassModel model = new SchoolClassModel();
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction=session.BeginTransaction())
                {
                    model.Name = name;
                    model.School = school;
                    session.Save(model);
                    transaction.Commit();
                }
            }
        }

        public void DeleteSchoolClass(SchoolClassModel model)
        {
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction=session.BeginTransaction())
                {
                    session.Delete(model);
                    transaction.Commit();
                }
            }
        }

        public void DeleteSchoolClass(int schoolClassId)
        {
            SchoolClassModel schoolClass = new SchoolClassModel();
            using (var session=SessionFactory.OpenSession())
            {
                using (var transaction=session.BeginTransaction())
                {
                    schoolClass = session.Get<SchoolClassModel>(schoolClassId);
                    session.Delete(schoolClass);
                    transaction.Commit();
                }  
            }
        }

        public int GetNumberofStudents(int schoolClassId)
        {
            int numberofStudents = 0;
            StudentModel studentData = new StudentModel();
            using (var session=SessionFactory.OpenSession())
            {
                if (studentData.SchoolClass.Id == schoolClassId)
                {
                    numberofStudents++;
                }
            }
            return numberofStudents;
        }

        public List<StudentModel> GetStudents(int schoolClassId)
        {
            StudentModel studentData = new StudentModel();
            List<StudentModel> students = new List<StudentModel>();
            using (var session=SessionFactory.OpenSession())
            {
                students = session.Query<StudentModel>().Where(s => s.SchoolClass.Id == schoolClassId).ToList();
            }
            return students;
        }

        public List<SubjectModel> GetSubjects(int schoolClassId)
        {
            SubjectModel subjectDetails = new SubjectModel();
            List<SubjectModel> subjects = new List<SubjectModel>();
            using (var session = SessionFactory.OpenSession())
            {
                subjects = session.Query<SubjectModel>().Where(s => s.SchoolClass.Id == schoolClassId).ToList();
            }
            return subjects;
        }

        public TeacherModel GetTeacher(int schoolClassId)
        {
            TeacherModel teacher = new TeacherModel();
            using (var session = SessionFactory.OpenSession())
            {
                var schoolClass = session.Get<SchoolClassModel>(schoolClassId);
                teacher = schoolClass.ClassTeacher;
            }
            return teacher;
        }

        public void UpdateSchoolClass(int schoolClassId, SchoolClassModel currentModel)
        {
            SchoolClassModel prevModel = new SchoolClassModel();
            using (var session=SessionFactory.OpenSession())
            {
                using (var transaction=session.BeginTransaction())
                {
                    prevModel = session.Get<SchoolClassModel>(schoolClassId);
                    prevModel = currentModel;
                    Update(prevModel);
                    session.Save(prevModel);
                    transaction.Commit();
                }
            }
        }
    }
}
