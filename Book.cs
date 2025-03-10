using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_PIU
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }

        public Book(string title, string author, string isbn, int copies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            TotalCopies = copies;
            AvailableCopies = copies;
        }

        public bool LoanBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                return true;
            }
            return false;
        }

        public void ReturnBook()
        {
            if (AvailableCopies < TotalCopies)
            {
                AvailableCopies++;
            }
        }

        public override string ToString()
        {
            return $"{Title} de {Author} (ISBN: {ISBN}) - Disponibile: {AvailableCopies}/{TotalCopies}";
        }
    }
}
