using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAuthor
{
    namespace Literature
    {
        class Book
        {
            public string Name;
            public string Author;
            public string Publisher;
            private double _price;
            public string Theme;

            public double Price
            {
                get
                {
                    return _price;
                }
                set
                {
                    if (value > 30)
                    {
                        _price = value * 0.90;
                    }
                }
            }

            public Book()
            {
                Name = "unknown";
                Author = "unknown";
                Publisher = "unknown";
                _price = 0;
                Theme = "unknown";
            }

            public Book(string name, string author, string publisher, double price, string theme)
            {
                Name = name;
                Author = author;
                Publisher = publisher;
                _price = price;
                Theme = theme;
            }

            public void SearchBook(string name)
            {
                Console.WriteLine("Give the name of the book: ");
                string userInput = Console.ReadLine();

                Name = userInput;

                if (Name == name)
                {
                    Console.WriteLine($"\nBook was found!\nName: {Name}\nAuthor: {Author}\nPublisher: {Publisher}\nPrice: {Price}\nTheme: {Theme}\n");
                }
            }

            public void ChangeTheme(string theme)
            {
                Theme = theme;
            }

            public override string ToString()
            {
                return ($"Name = {Name}\nAuthor = {Author}\nPublisher = {Publisher}\nPrice = {Price}\nTheme = {Theme}");

            }

        }
    }
}
