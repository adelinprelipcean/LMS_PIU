using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_PIU
{
    public enum BookCondition
    {
        Noua, 
        Buna,
        Mediocra,
        Uzata
    }
    [Flags]
    public enum EducationLevel
    {
        Primar = 1,
        Gimnazial = 2,
        Liceal = 4,
        Universitar = 8,
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public BookCondition BookCondition { get; set; }
        public EducationLevel MinimumLevel { get; set; }


        public Book(string title, string author, string isbn, int copies, BookCondition condition, EducationLevel minimum_level)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            TotalCopies = copies;
            AvailableCopies = copies;
            BookCondition = condition;
            MinimumLevel = minimum_level;
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
            return $"{Title} de {Author} (ISBN: {ISBN}) - Disponibile: {AvailableCopies}/{TotalCopies} bucati - Stare: {BookCondition} - Nivele de educatie recomandate: {MinimumLevel}";
        }
    }
}
