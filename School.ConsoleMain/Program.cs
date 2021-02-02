using Entities;
using School.Common;
using School.Infrastructures.NHibernate.DatabaseType;
using School.Infrastructures.NHibernate.Queries;
using System;

namespace School.ConsoleMain
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqLite = new SqLiteSessionFactoryCreator();
            var repo = ModelSupport<SchoolModel>.UseNHibernateSqLite();
            //createModel(repo);
            var schoolClassQuery = new SchoolClassRepository(sqLite);
            var teacher = schoolClassQuery.GetTeacher(1);
            var students = schoolClassQuery.GetStudents(1);
            Console.WriteLine("Database created");
            Console.ReadLine();
        }

        static void createModel(IRepository<SchoolModel> repository)
        { 
            var school1 = new SchoolModel()
            {
                Name = "Victorious Child Academy",
                Location = "23, NTA Rd, Ozuoba",
            };
            school1.Principal = new PrincipalModel()
            {
                Name = "Mr. Modest",
                Address = "11, Ogbogoro close, Ogbogoro",
                Gender = Gender.Male
            };

            var teacher1 = new TeacherModel() { Name = "Mr. Johnny", Address = "44, Aba Rd, Rumuola", Gender = Gender.Male, School = school1 };
            var teacher2 = new TeacherModel() { Name = "Mr. Nick", Address = "24, Aba Rd, Rumuola", Gender = Gender.Male, School = school1 };
            var teacher3 = new TeacherModel() { Name = "Mrs. James", Address = "36, Aba Rd, Rumuola", Gender = Gender.Female, School = school1 };
            var teacher4 = new TeacherModel() { Name = "Mrs. Dickson", Address = "19, Aba Rd, Rumuola", Gender = Gender.Female, School = school1 };
            var teacher5 = new TeacherModel() { Name = "Mrs. Tom", Address = "114, NTA Rd, Mgboba", School = school1, Gender = Gender.Female };
            var teacher6 = new TeacherModel() { Name = "Mr. Tony", Address = "104, NTA Rd, Mgboba", School = school1, Gender = Gender.Male };

            var ss1 = new SchoolClassModel() { Name = "SSS 1", ClassTeacher = teacher3, School = school1 };
            var ss2 = new SchoolClassModel() { Name = "SSS 2", ClassTeacher = teacher1, School = school1 };
            var ss3 = new SchoolClassModel() { Name = "SSS 3", ClassTeacher = teacher5, School = school1 };

            var phy1 = new SubjectModel() { Name = "Physics 1", Teacher = teacher1, SchoolClass=ss1 };
            var chem1 = new SubjectModel() { Name = "Chemistry 1", Teacher = teacher1, SchoolClass = ss1 };
            var bio1 = new SubjectModel() { Name = "Biology 1", Teacher = teacher1, SchoolClass = ss1 };
            var comm1 = new SubjectModel() { Name = "Commerce 1", Teacher = teacher2, SchoolClass = ss1 };
            var econs1 = new SubjectModel() { Name = "Economics 1", Teacher = teacher4, SchoolClass = ss1 };
            var agric1 = new SubjectModel() { Name = "Agriculture 1", Teacher = teacher4, SchoolClass = ss1 };
            var math1 = new SubjectModel() { Name = "Mathematics 1", Teacher = teacher5, SchoolClass = ss1 };
            var eng1 = new SubjectModel() { Name = "English 1", Teacher = teacher3, SchoolClass = ss1 };
            var lit1 = new SubjectModel() { Name = "Literature 1", Teacher = teacher3, SchoolClass = ss1 };
            var acct1 = new SubjectModel() { Name = "Accounting 1", Teacher = teacher2, SchoolClass = ss1 };

            var phy2 = new SubjectModel() { Name = "Physics 2", Teacher = teacher1, SchoolClass = ss2 };
            var chem2 = new SubjectModel() { Name = "Chemistry 2", Teacher = teacher1, SchoolClass = ss2 };
            var bio2 = new SubjectModel() { Name = "Biology 2", Teacher = teacher1, SchoolClass = ss2 };
            var comm2 = new SubjectModel() { Name = "Commerce 2", Teacher = teacher2, SchoolClass = ss2 };
            var econs2 = new SubjectModel() { Name = "Economics 2", Teacher = teacher4, SchoolClass = ss2 };
            var agric2 = new SubjectModel() { Name = "Agriculture 2", Teacher = teacher4, SchoolClass = ss2 };
            var math2 = new SubjectModel() { Name = "Mathematics 2", Teacher = teacher5, SchoolClass = ss2 };
            var eng2 = new SubjectModel() { Name = "English 2", Teacher = teacher3, SchoolClass = ss2 };
            var lit2 = new SubjectModel() { Name = "Literature 2", Teacher = teacher3, SchoolClass = ss2 };
            var acct2 = new SubjectModel() { Name = "Accounting 2", Teacher = teacher2, SchoolClass = ss2 };

            var phy3 = new SubjectModel() { Name = "Physics 3", Teacher = teacher1, SchoolClass = ss3 };
            var chem3 = new SubjectModel() { Name = "Chemistry 3", Teacher = teacher1, SchoolClass = ss3 };
            var bio3 = new SubjectModel() { Name = "Biology 3", Teacher = teacher1, SchoolClass = ss3 };
            var comm3 = new SubjectModel() { Name = "Commerce 3", Teacher = teacher2, SchoolClass = ss3 };
            var econs3 = new SubjectModel() { Name = "Economics 3", Teacher = teacher4, SchoolClass = ss3 };
            var agric3 = new SubjectModel() { Name = "Agriculture 3", Teacher = teacher4, SchoolClass = ss3 };
            var math3 = new SubjectModel() { Name = "Mathematics 3", Teacher = teacher5, SchoolClass = ss3 };
            var eng3 = new SubjectModel() { Name = "English 3", Teacher = teacher3, SchoolClass = ss3 };
            var lit3 = new SubjectModel() { Name = "Literature 3", Teacher = teacher3, SchoolClass = ss3 };
            var acct3 = new SubjectModel() { Name = "Accounting 3", Teacher = teacher2, SchoolClass = ss3 };

            ss1.Subjects.Add(phy1);
            ss1.Subjects.Add(acct1);
            ss1.Subjects.Add(math1);
            ss1.Subjects.Add(eng1);
            ss1.Subjects.Add(chem1);
            ss1.Subjects.Add(econs1);
            ss1.Subjects.Add(comm1);
            ss1.Subjects.Add(bio1);
            ss1.Subjects.Add(lit1);

            ss2.Subjects.Add(chem2);
            ss2.Subjects.Add(phy2);
            ss2.Subjects.Add(acct2);
            ss2.Subjects.Add(math2);
            ss2.Subjects.Add(eng2);
            ss2.Subjects.Add(econs2);
            ss2.Subjects.Add(comm2);
            ss2.Subjects.Add(bio2);
            ss2.Subjects.Add(lit2);

            ss3.Subjects.Add(phy3);
            ss3.Subjects.Add(chem3);
            ss3.Subjects.Add(bio3);
            ss3.Subjects.Add(econs3);
            ss3.Subjects.Add(agric3);
            ss3.Subjects.Add(econs3);
            ss3.Subjects.Add(math3);
            ss3.Subjects.Add(eng3);
            ss3.Subjects.Add(lit3);
            ss3.Subjects.Add(comm3);
            ss3.Subjects.Add(acct3);

            teacher1.Subjects.Add(phy1);
            teacher1.Subjects.Add(chem2);
            teacher1.Subjects.Add(phy2);
            teacher1.Subjects.Add(bio1);

            teacher2.Subjects.Add(comm2);
            teacher2.Subjects.Add(acct3);
            teacher4.Subjects.Add(econs3);

            teacher3.Subjects.Add(eng1);
            teacher3.Subjects.Add(lit3);

            teacher4.Subjects.Add(agric2);
            teacher4.Subjects.Add(econs1);
            teacher4.Subjects.Add(agric1);
            teacher4.Subjects.Add(econs2);

            teacher5.Subjects.Add(math1);
            teacher5.Subjects.Add(math2);
            teacher5.Subjects.Add(math3);

            teacher6.Subjects.Add(chem1);
            teacher5.Subjects.Add(chem2);
            teacher5.Subjects.Add(phy3);

            school1.Students.Add(new StudentModel { FirstName = "Benson", LastName = "Jersey", Gender = Gender.Male, School = school1, SchoolClass=ss1 });
            school1.Students.Add(new StudentModel { FirstName = "Ham", LastName = "Lincoln", Gender = Gender.Male, School = school1, SchoolClass = ss1 });
            school1.Students.Add(new StudentModel { FirstName = "Jenny", LastName = "Jersey", Gender = Gender.Female, School = school1, SchoolClass = ss1 });

            school1.Students.Add(new StudentModel { FirstName = "Mosh", LastName = "Jerry", Gender = Gender.Male, School = school1, SchoolClass = ss2, Address="22 First Pillar Close, Rumuokwachi"});
            school1.Students.Add(new StudentModel { FirstName = "Dime", LastName = "Hassel", Gender = Gender.Male, School = school1, SchoolClass = ss2, Address = "26 First Pillar Close, Rumuokwachi" });
            school1.Students.Add(new StudentModel { FirstName = "Bruce", LastName = "Clinton", Gender = Gender.Female, School = school1, SchoolClass = ss2, Address = "19 Open Deck Close, Rumuokwachi" });
            school1.Students.Add(new StudentModel { FirstName = "Helen", LastName = "Lincoln", Gender = Gender.Female, School = school1, SchoolClass = ss2, Address = "218 Walter Street, Rumuokwachi" });
            school1.Students.Add(new StudentModel { FirstName = "Dino", LastName = "Lewis", Gender = Gender.Male, School = school1, SchoolClass = ss2, Address = "26 Church Rd, Rumuosi" });
            school1.Students.Add(new StudentModel { FirstName = "Janet", LastName = "Lenny", Gender = Gender.Female, School = school1, SchoolClass = ss2, Address = "19 Balogun Close, Rumuokwachi" });
            school1.Students.Add(new StudentModel { FirstName = "Nelly", LastName = "Jim", Gender = Gender.Female, School = school1, SchoolClass = ss2, Address = "218 Dexter Street, Rumuokwachi" });

            school1.Teachers.Add(teacher1);
            school1.Teachers.Add(teacher2);
            school1.Teachers.Add(teacher3);
            school1.Teachers.Add(teacher4);
            school1.Teachers.Add(teacher5);

            school1.SchoolClasses.Add(ss1);
            school1.SchoolClasses.Add(ss2);
            school1.SchoolClasses.Add(ss3);

            repository.Create(school1);
        }
    }
}
