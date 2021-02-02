using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common
{
    public interface IRepository<T>
    {
        void Create(T model);
        T GetModel(int id);
        void Update(T model);
        void Update(int id, T model);
        void Delete(T model);
    }
}
