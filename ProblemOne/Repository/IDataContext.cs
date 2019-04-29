using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemOne.Repository
{
    public interface IDataContext<T> where T : class
    {
        IEnumerable<T> Set();
    }
}
