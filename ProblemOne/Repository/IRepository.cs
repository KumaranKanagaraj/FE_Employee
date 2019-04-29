using ProblemOne.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemOne.Repository
{
    public interface IRepository<T>
    {
        Guid Insert(T entity);
        void Delete(T entity);
        T GetById(Guid id);
        IEnumerable<T> Get();
    }
}
