using System;
using Competition2.Models;

namespace USFLibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Books
            Book b1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book b2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book b3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);

            // Patrons
            Student s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student s2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            Staff st1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            library.AddPatron(s1);
            library.AddPatron(s2);
            library.AddPatron(st1);

            // Display books and patrons
            library.DisplayBooks();
            Console.WriteLine();
            library.DisplayPatrons();
            Console.WriteLine();

            // Borrowing scenario
            Console.WriteLine("Borrowing Books...");
            if (b2.BorrowBook()) Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");
            if (b3.BorrowBook()) Console.WriteLine("Akhil borrowed 'Analytics in Action'");
            Console.WriteLine();

            Console.WriteLine("Books after borrowing:");
            library.DisplayBooks();
        }
    }
}
