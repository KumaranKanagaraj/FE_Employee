using ProblemOne.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemTwo.Models
{
    public class EmployeeWithAddress : Employee
    {
        public Address Address { get; set; }
    }
}
