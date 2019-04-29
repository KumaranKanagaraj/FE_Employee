using ProblemOne.Models;
using ProblemOne.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemOne.Service
{
    public class EmployeeService<T>where T : class, IEntity
    {
        private Repository<T> _repository;

        public EmployeeService(Repository<T> repository)
        {
            this._repository = repository;
        }

        public void Add(T entity)
        {
            entity.Id = Guid.NewGuid();
            this._repository.Insert(entity);
            Show();
        }

        public void Delete(Guid id)
        {
            var entity = this._repository.Get().ToList().Where(a => a.Id.Equals(id)).SingleOrDefault();
            this._repository.Delete(entity);
        }

        public List<T> Get()
        {
            return this._repository.Get().ToList();
        }

        public string SaveTo(Format format)
        {
            return new Save<T>(Get(), format).SaveAs();
        }

        public virtual void Show()
        {
            var employees = this._repository.Get().ToList();
            foreach (var item in employees as List<Employee>)
            {
                Console.Write($"Id: {item.Id} ");
                Console.Write($"Age: {item.Age} ");
                Console.Write($"Designation: {item.Designation}");
                Console.WriteLine();
            }
        }
    }
}
