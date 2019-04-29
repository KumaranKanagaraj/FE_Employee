using ProblemOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemOne.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private List<T> _dbSet;

        public Repository(IDataContext<T> dataContext)
        {
            _dbSet = dataContext.Set().ToList();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<T> Get()
        {
            return _dbSet.AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return _dbSet.Where(a => a.Id.Equals(id)).SingleOrDefault();
        }

        public Guid Insert(T entity)
        {
            _dbSet.Add(entity);
            return entity.Id;
        }
    }
}
