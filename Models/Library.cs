using System;
using System.Collections.Generic;

namespace Competition2.Models
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Person> Patrons { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Patrons = new List<Person>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddPatron(Person person)
        {
            Patrons.Add(person);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in Books)
            {
                book.DisplayInfo();
            }
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (var patron in Patrons)
            {
                patron.DisplayInfo();
            }
        }
    }
}
