using System.Net;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Task1_20._10.Exceptions;
using Task1_20._10.Extension;
using Task1_20._10.models;

namespace Task1_20._10
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            List<Library> libraries = new();
            List<Category> categories = new();
            List<Book> books = new();

            string operation = "";

            while (operation != "0")
            {
                Console.WriteLine("============");

                Console.WriteLine(" Ana Menyu");

                Console.WriteLine("============");

                Console.WriteLine("[1] Yeni kitabxana yarat");
                Console.WriteLine("[2] Yeni kategoriya yarat");
                Console.WriteLine("[3] Yeni kitab yarat");
                Console.WriteLine("[4] Kitabxanaya daxil ol");
                Console.WriteLine("[0] Programdan chix");
                operation = Console.ReadLine();
                {
                    switch (operation)
                    {
                        case "1":
                            Console.WriteLine("Kitabxananin adini  daxil et: ");
                            string libraryname;
                            try
                            {
                                libraryname = Helper.Check();
                                Library library = new Library (libraryname);
                                libraries.Add(library);
                                Console.WriteLine($"{libraryname} adli kitabxana yarandi");
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);                
                            }
                            
                            break;

                        case "2":
                            Console.WriteLine("Kateqoriyanin adini daxil edin: ");
                            string categoryname;
                            try
                            {
                                categoryname = Helper.Check();
                                Category category = new Category(categoryname);
                                categories.Add(category);
                                Console.WriteLine($" '{categoryname}' Kateqoriya yaradildi: ");
                                break;
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                            

                        case "3":
                            Console.WriteLine("===========");

                            Console.WriteLine("Yeni kitab yarat");

                            Console.WriteLine("===========");

                            Console.WriteLine("Kitabin adin daxil edin: ");

                            string bookname = Console.ReadLine();
                            

                            Console.WriteLine("Yazar kimdir?");

                            string author = Console.ReadLine();
                            

                            foreach (Category c in categories)
                            {
                                Console.WriteLine(c);
                            }

                            bool isExit = false;

                            int positiveNum = 0;
                            try
                            {
                                positiveNum = Helper.GetPositiveNum();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            
                                foreach (Category c in categories)
                                {
                                    if (c.Id == positiveNum)
                                    {
                                        Book book = new Book(bookname, author, c);
                                        books.Add(book);
                                        Console.WriteLine($"Book {bookname} created");
                                        isExit = true;
                                        break;
                                    }
                                
                                }
                            
                            if (positiveNum > 0 && !isExit) Console.WriteLine("kateqoriya movcud deyil!");
                            break;

                        case "4":
                            if (libraries.Count != 0 )
                            {
                                Console.WriteLine("Kitabxana sech:");

                                foreach (Library library1 in libraries)
                                {
                                    Console.WriteLine("Kitabxanalar:");
                                    Console.WriteLine(library1);

                                }
                                Console.WriteLine("kitabxana id daxil et");
                                int libraryId = 0;
                                try
                                {
                                    libraryId = Helper.GetPositiveNum();


                                }

                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }

                                foreach (Library c in libraries)
                                {

                                    if (c.Id == libraryId)
                                    {

                                        string operation2 = "";
                                        while (operation2 != "0")
                                        {
                                            Console.WriteLine("=======================================");
                                            Console.WriteLine($"{c.Name} Kitabxanasina xosh gelmisiz!");
                                            Console.WriteLine("=======================================");

                                            Console.WriteLine("[1] Kitab elave et");
                                            Console.WriteLine("[2] Kitablari goster");
                                            Console.WriteLine("[0] Kitabxanadan chix");

                                            operation2 = Console.ReadLine();

                                            switch (operation2)
                                            {

                                                case "1":

                                                    Console.WriteLine("Kitab sech");

                                                    foreach (Book book in books)
                                                    {
                                                        Console.WriteLine(book);
                                                    }
                                                    Console.WriteLine("Id daxil edin");
                                                    int bookId = 0;
                                                    try
                                                    {
                                                        bookId = Helper.GetPositiveNum();
                                                    }
                                                    catch (WrongInputException ex)
                                                    {
                                                        Console.WriteLine(ex.Message);
                                                    }
                                                    bool isExist2 = false;

                                                    foreach (Book book in books)
                                                    {
                                                        if (book.Id == bookId)
                                                        {
                                                            try
                                                            {
                                                                c.AddBook(book);
                                                                Console.WriteLine("Kitab elave edildi");
                                                                
                                                            }
                                                            catch (BookAlreadyExistsException ex)
                                                            {
                                                                Console.WriteLine(ex.Message);
                                                            }

                                                            isExist2 = true;

                                                            break;
                                                        }

                                                    }

                                                    if (!isExist2)
                                                    {
                                                        Console.WriteLine($"{bookId} - kitab movcud deyil");
                                                    }





                                                    break;

                                                case "2":
                                                    c.ListAllBooks();
                                                    break;
                                            }


                                        }
                                        Console.Clear();

                                    }


                                }
                            }
                            else Console.WriteLine("Kitabxanalar movcud deyil");
                            break;

                            
                    }
                }
            }

        }
    }
}                      