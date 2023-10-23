using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Task1_20._10.Exceptions;

namespace Task1_20._10.models
{
    internal class Library : Base
    {
        List<Book> _books = new List<Book>();

        private static int _count = 1;

        public Library(string name)
        {
            Name = name;
            Id = _count;
            _count++;
        }


        public void AddBook(Book book)
        {
            foreach (Book book2 in _books)
            {
                if (book2.Id == book.Id) throw new BookAlreadyExistsException("Book already exist!");
             }

            _books.Add(book);
        }

        public void ListAllBooks()
        {
            foreach (var item in _books)
            {
                Console.WriteLine(item);
            }
            
        }



        public override string ToString()
        {
            return $"Id: {Id} | " + $" Name: {Name} ";
        }

    }
}
