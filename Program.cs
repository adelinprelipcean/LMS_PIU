using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_PIU
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            bool exit = false;

            lib.AddBook(new Book("The C Programming Language. 2nd Edition", "Dennis Ritchie", "1", 3));
            lib.AddBook(new Book("Code: The Hidden Language of Computer Hardware and Software", "Charles Petzold", "2", 5));
            lib.AddBook(new Book("The Art of Electronics", "Paul Horowitz", "3", 2));
            lib.AddBook(new Book("Practical Electronics for Inventors", "Paul Scherz", "4", 1));
            lib.AddBook(new Book("Introduction to Algorithms", "Thomas H. Cormen", "5", 4));

            while (!exit)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Search by ISBN");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Loan Book");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Enter Total Copies: ");
                        int copies = int.Parse(Console.ReadLine());
                        Book book = new Book(title, author, isbn, copies);
                        lib.AddBook(book);
                        break;
                    case "2":
                        Console.Write("Enter ISBN: ");
                        isbn = Console.ReadLine();
                        lib.RemoveBook(isbn);
                        break;
                    case "3":
                        Console.Write("Enter ISBN: ");
                        isbn = Console.ReadLine();
                        Book bookByISBN = lib.SearchByISBN(isbn);
                        if (bookByISBN != null)
                        {
                            Console.WriteLine(bookByISBN);
                        }
                        else
                        {
                            Console.WriteLine("Book not found");
                        }
                        break;
                    case "4":
                        Console.Write("Enter Title: ");
                        title = Console.ReadLine();
                        List<Book> booksByTitle = lib.SearchByTitle(title);
                        if (booksByTitle.Count > 0)
                        {
                            foreach (Book b in booksByTitle)
                            {
                                Console.WriteLine(b);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book not found");
                        }
                        break;
                    case "5":
                        Console.Write("Enter ISBN: ");
                        isbn = Console.ReadLine();
                        if (lib.LoanBook(isbn))
                        {
                            Console.WriteLine("Book loaned");
                        }
                        else
                        {
                            Console.WriteLine("Book not found or already loaned");
                        }
                        break;
                    case "6":
                        Console.Write("Enter ISBN: ");
                        isbn = Console.ReadLine();
                        lib.ReturnBook(isbn);
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
