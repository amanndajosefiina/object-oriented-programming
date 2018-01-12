using System;

namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookHarryPotter = new Book();
            bookHarryPotter.Title = "Harry Potter";
            bookHarryPotter.Author = "J.K. Rowling";
            bookHarryPotter.Id = 1701552;
            bookHarryPotter.Price = 20;

            Book bookDorianGray = new Book();
            bookDorianGray.Title = "Dorian Gray";
            bookDorianGray.Author = "Oscar Wilde";
            bookDorianGray.Id = 1701556;
            bookDorianGray.Price = 25;

            bookHarryPotter.PrintBookInfo();
            bookDorianGray.PrintBookInfo();

            Console.WriteLine($"{bookHarryPotter.CompareBook(bookDorianGray)}");

            Console.ReadKey();
    
        }
    }
}
