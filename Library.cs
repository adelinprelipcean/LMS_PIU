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

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            Book bookToRemove = books.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
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
            if (book != null)
            {
                return book.LoanBook();
            }
            return false;
        }

        public void ReturnBook(string isbn)
        {
            Book book = SearchByISBN(isbn);
            if (book != null)
            {
                book.ReturnBook();
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
