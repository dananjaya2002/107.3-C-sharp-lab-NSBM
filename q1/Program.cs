using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Book
    {
        public string Title {  get; set; }
        public string Authour {  get; set; }

        public Book(string title, string authour)
        {
            Title = title;
            Authour = authour;
        }

        
    }
    internal class Program
    {
       public static void Main(string[] args)
        {
            Book book1 = new Book("", "");

            Console.WriteLine("Enter the Book Title:");
            book1.Title = Console.ReadLine();

            Console.WriteLine("Enter the Authour of this book:");
            book1.Authour = Console.ReadLine();

            Console.WriteLine("title of the book is " + book1.Title);
            Console.WriteLine("authour of the book is " + book1.Authour);
            Console.ReadLine();
        }

        

    }
}
