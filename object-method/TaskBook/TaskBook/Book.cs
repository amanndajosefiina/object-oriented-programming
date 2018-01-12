using System;
using System.Collections.Generic;
using System.Text;

namespace TaskBook
{
    class Book
    {
        public string Title;
        public string Author;
        public int Id;
        public int Price;

        public Book()
        {
            Title = "unknown";
            Author = "unknown";
            Id = 0;
            Price = 0;
        }

        public Book(string title, string author, int id, int price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Book's title: {Title}\nBook's author: {Author}\nBook's Id: {Id}\nBook's Price: {Price}\n");
        }

        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
                return ($"{this.Title} is more expensieve than {book.Title}.");
            else
                return ($"{book.Title} is more expensive than {this.Title}.");
        }

    }
}
