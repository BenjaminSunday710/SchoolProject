using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructures.EFcore
{
    public abstract class SchoolDatabaseContext:DbContext
    {
        public SchoolDatabaseContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<SchoolModel> Schools { get; set; }
        public DbSet<SchoolClassModel> SchoolClassModels { get; set; }
        public DbSet<PrincipalModel> Principals { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<SubjectModel> Subjects { get; set; }

        public abstract void InitialiseDatabase(DbContextOptionsBuilder dbContextOptionsBuilder);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            SQLitePCL.Batteries.Init();
            InitialiseDatabase(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolModel>(x => x.HasKey(y => y.Id))
                        .Entity<SchoolClassModel>(x => x.HasKey(y => y.Id))
                        .Entity<StudentModel>(x => x.HasKey(y => y.Id))
                        .Entity<PrincipalModel>(x => x.HasKey(y => y.Id))
                        .Entity<SubjectModel>(x => x.HasKey(y => y.Id))
                        .Entity<TeacherModel>(x => x.HasKey(y => y.Id));
            base.OnModelCreating(modelBuilder);
        }


    }
}
