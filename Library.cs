using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_PIU
{
    public class Library
    {
        private List<Book> books;
        private string filePath = "..\\..\\books.txt";

        public void SaveFile()
        {
            List<string> lines = new List<string>();
            foreach(var book in books)
            {
                lines.Add($"{book.Title};{book.Author};{book.ISBN};{book.TotalCopies};{book.AvailableCopies};{book.BookCondition};{book.MinimumLevel}");
            }
            System.IO.File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Salvez în: {System.IO.Path.GetFullPath(filePath)}");

        }

        public void OpenFile()
        {
            if (System.IO.File.Exists(filePath))
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(';');

                    if (parts.Length < 7)
                    {
                        Console.WriteLine($"Linie invalidă în books.txt: {line}");
                        continue; // ignoră linia greșită
                    }

                    string title = parts[0];
                    string author = parts[1];
                    string isbn = parts[2];
                    int totalCopies = int.Parse(parts[3]);
                    int availableCopies = int.Parse(parts[4]);

                    BookCondition condition = (BookCondition)Enum.Parse(typeof(BookCondition), parts[5]);
                    EducationLevel level = (EducationLevel)Enum.Parse(typeof(EducationLevel), parts[6]);

                    Book book = new Book(title, author, isbn, totalCopies, condition, level);
                    book.AvailableCopies = availableCopies;

                    books.Add(book);
                }
            }
        }

        public Library()
        {
            books = new List<Book>();
            OpenFile();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            SaveFile();
        }

        public void RemoveBook(string isbn)
        {
            Book bookToRemove = books.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                SaveFile();
            }

        }

        public Book SearchByISBN(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public bool LoanBook(string isbn)
        {
            Book book = SearchByISBN(isbn);
            if (book != null && book.LoanBook())
            {
                SaveFile(); 
                return true;
            }
            return false;
        }

        public void ReturnBook(string isbn)
        {
            Book book = SearchByISBN(isbn);
            if (book != null)
            {
                book.ReturnBook();
                SaveFile();
            }
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
