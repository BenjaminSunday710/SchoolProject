﻿using NHibernate;
using School.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructures.NHibernate
{
    public class NHibernateRepository<T>:IRepository<T>
    {
        public ISessionFactory SessionFactory { get; private set; }

        public NHibernateRepository(IDatabaseType databaseType)
        {
            SessionFactory = databaseType.CreateSessionFactory();
        }

        public void Create(T model)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(model);
                    transaction.Commit();
                }
            }
        }

        public void Delete(T model)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(model);
                    transaction.Commit();
                }
            }
        }

        public T GetModel(int id)
        {
            T model;
            using (ISession session = SessionFactory.OpenSession())
            {
                model = session.Get<T>(id);
            }
            return model;
        }

        public void Update(T model)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(model);
                    transaction.Commit();
                }
            }
        }

        public void Update(int id, T model)
        {
            using (ISession session=SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    T prevModel = session.Get<T>(id);
                    prevModel = model;
                    session.Update(model);
                    transaction.Commit();
                }
            }
        }
    }

    //public class StaffRepository : NHibernateRepository<StaffModel>, IStaffRepository<StaffModel>
    //{
    //    public StaffRepository(IDatabaseType databaseType) : base(databaseType)
    //    {

    //    }

    //    public CompanyModel GetCompany(int staffId)
    //    {
    //        StaffModel model = GetModel(staffId);
    //        return model.Company;
    //    }
    //}
}

