using ProblemOne.Repository;
using ProblemOne.Service;
using ProblemTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemTwo.Service
{
    public class EmployeeWithAddressService : EmployeeService<EmployeeWithAddress>
    {
        private Repository<EmployeeWithAddress> _repository;

        public EmployeeWithAddressService(Repository<EmployeeWithAddress> repository) : base(repository)
        {
            this._repository = repository;
        }

        public override void Show()
        {
            var employees = this._repository.Get().ToList();
            foreach (var item in employees as List<EmployeeWithAddress>)
            {
                Console.Write($"Id: {item.Id} ");
                Console.Write($"Age: {item.Age} ");
                Console.Write($"Designation: {item.Designation}  ");
                Console.Write($"Address: {item.Address.City} ");
                Console.WriteLine();
            }
        }
    }
}
