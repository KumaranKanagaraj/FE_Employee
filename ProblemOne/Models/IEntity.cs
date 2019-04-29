using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemOne.Models
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
