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

            /* Crearea a două obiecte de tip Book */
            Book b1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", 3);
            Book b2 = new Book("1984", "George Orwell", "9780451524935", 5);

            /* Adaugarea a doua carti in biblioteca */
            lib.AddBook(b1);
            lib.AddBook(b2);

            Console.WriteLine("Catalogul bibliotecii:");
            lib.DisplayBooks();

            /* Incercare imprumut carte */
            Console.WriteLine("\nImprumutam '1984'...");
            if (lib.LoanBook("9780451524935"))
            {
                Console.WriteLine("Imprumut reusit!");
            }
            else
            {
                Console.WriteLine("Imprumut esuat: Cartea nu este disponibila.");
            }

            Console.WriteLine("\nCatalogul dupa imprumut:");
            lib.DisplayBooks();

            /* Returnare carte */
            Console.WriteLine("\nReturnam '1984'...");
            lib.ReturnBook("9780451524935");

            Console.WriteLine("\nCatalogul dupa returnare:");
            lib.DisplayBooks();

            Console.WriteLine("\nApasati orice tasta pentru a iesi...");
            Console.ReadKey();
        }
    }
}
