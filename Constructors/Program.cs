using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
           Book book1 = new Book("Harry Potter", "JK Rowling", 456);
           Book book2 = new Book("Lord of the rings", "Tolkien", 678);
           Console.WriteLine("{0} by {1}", book1.Title, book1.Author );
        }
    }
}