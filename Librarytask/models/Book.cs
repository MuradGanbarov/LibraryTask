using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1_20._10.models
{
    internal class Book : Base
    {
        private static int _count = 1;

        public string Author { get; set; }
        public Category Category { get;}
        

      

       public Book(string book, string author, Category category)

        {
            Name = book;
            Author = author;
            Category = category;
            Id = _count;
            _count++;
        }

        
        

        public override string ToString()
        {
            return $"Id: {Id} | " + $" Name: {Name} | " + $" Author: {Author} | " + $"Category: {Category}";
        }

    }
}
