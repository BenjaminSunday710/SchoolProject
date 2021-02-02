using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructures.EFcore.DatabaseContextType
{
    public class SqLiteDatabaseInitializer:SchoolDatabaseContext
    {
        public override void InitialiseDatabase(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite(@"Data Source=C:\Users\FRIDAY BENJAMIN\Desktop\EFCoreSchoolDB.db");
        }
    }
}
