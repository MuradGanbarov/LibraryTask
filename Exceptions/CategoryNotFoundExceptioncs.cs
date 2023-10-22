using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_20._10.Exceptions
{
    internal class CategoryNotFoundExceptioncs : Exception
    {
        public CategoryNotFoundExceptioncs(string message) : base(message)
        {
            
        }

    }
}
