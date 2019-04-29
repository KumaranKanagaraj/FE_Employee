using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemOne.Models
{
    public class Employee : IEntity
    {
        public Guid Id { get; set; }
        public int Age { get; set; }
        public Designation Designation { get; set; }
    }
}
