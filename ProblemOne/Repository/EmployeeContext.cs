using ProblemOne.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemOne.Repository
{
    public class EmployeeContext : IDataContext<Employee>
    {
        public IEnumerable<Employee> Set()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    Id= new Guid("99c6979c-8cea-41fb-a3df-46ae9fee204a"),
                    Age = 23,
                    Designation = Designation.SoftwareEngineerLevel1
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 23,
                    Designation = Designation.SoftwareEngineerLevel1
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 24,
                    Designation = Designation.SoftwareEngineerLevel2
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 24,
                    Designation = Designation.SoftwareEngineerLevel2
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 25,
                    Designation = Designation.SoftwareEngineerLevel3
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 23,
                    Designation = Designation.SoftwareEngineerLevel3
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 25,
                    Designation = Designation.ProductManager
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 25,
                    Designation = Designation.ProductManager
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 24,
                    Designation = Designation.TestingEngineer
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 25,
                    Designation = Designation.TestingEngineer
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 23,
                    Designation = Designation.TestingEngineer
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 24,
                    Designation = Designation.SoftwareEngineerLevel1
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 27,
                    Designation = Designation.SoftwareEngineerLevel2
                },
                new Employee
                {
                    Id= Guid.NewGuid(),
                    Age = 27,
                    Designation = Designation.SoftwareEngineerLevel3
                }
            };
        }
    }
}
