using ProblemOne.Models;
using ProblemOne.Repository;
using ProblemOne.Service;
using ProblemTwo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemTwo.Repository
{
    public class EmployeeWithAddressContext : IDataContext<EmployeeWithAddress>
    {
        public IEnumerable<EmployeeWithAddress> Set()
        {
            List<EmployeeWithAddress> employeeWithAddresses = new List<EmployeeWithAddress>();
            var employeeRepository = new Repository<Employee>(new EmployeeContext());
            var employeService = new EmployeeService<Employee>(employeeRepository);
            foreach (var item in employeService.Get())
            {
                employeeWithAddresses.Add(new EmployeeWithAddress
                {
                    Address = new Address
                    {
                        BuildingName = "qwewq",
                        City = "trichy",
                        Country = "India",
                        DoorNo = 12,
                        State = "TN",
                        StreetName = "DFDS"
                    },
                    Age = item.Age,
                    Designation = item.Designation,
                    Id = item.Id
                });
            }
            return employeeWithAddresses;
        }
    }
}
