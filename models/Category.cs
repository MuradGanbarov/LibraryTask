using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_20._10.models
{
    internal class Category : Base
    {
        private static int _count = 1;

        public Category(string name)
        {
            Name = name;
            Id = _count;
            _count++;
        }

        public override string ToString()
        {
            return $"name: {Name}, id: {Id}";
        }

        




    }
}
