using Microsoft.EntityFrameworkCore;
using School.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructures.EFcore
{
    public class EFcoreRepository<T>:IRepository<T> where T:class
    {
        public EFcoreRepository(DbContext databaseContextType)
        {
            DatabaseContext = databaseContextType;
        }

        public DbContext DatabaseContext { get; }

        public void Create(T model)
        {
            DatabaseContext.Add(model);
            DatabaseContext.SaveChanges();
        }

        public void Delete(T model)
        {
            DatabaseContext.Remove(model);
            DatabaseContext.SaveChanges();
        }

        public T GetModel(int id)
        {
            T model = DatabaseContext.Find<T>(id);
            return model;
        }

        public void Update(T prevModel, T newModel)
        {
            DatabaseContext.Attach(prevModel);
            //DatabaseContext.Update()
        }

        public void Update(T model)
        {
            DatabaseContext.Update<T>(model);
            DatabaseContext.SaveChanges();
        }

        public void Update(int id, T model)
        {
            T prevModel = DatabaseContext.Find<T>(id);
            prevModel = model;
            DatabaseContext.Update<T>(model);
            DatabaseContext.SaveChanges();
        }
    }
}
