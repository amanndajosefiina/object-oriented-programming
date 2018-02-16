using System;

namespace TaskAuthor
{
    namespace Literature
    {
        class Program
        {
            static void Main(string[] args)
            {
                Book book1 = new Book("Harry Potter and the Deathly Hallows", "J.K. Rowling", "Bloomsbury Publishing", 26.99, "Fantasy");
                Book book2 = new Book("Wuthering Heights", "Emily Bronte", "Bookpublishers", 24.60, "Romance");
                Book book3 = new Book("To Kill a Mockingbird", "Lee Harper", "Bookpublishers", 32.40, "Drama");
                Book book4 = new Book("The Lord of the Rings", "J.R.R. Tolkien", "Allen & Unwin", 35.00, "Fantasy");

                book1.SearchBook("Harry Potter and the Deathly Hallows");
                book2.SearchBook("Wuthering Heights");

                Console.WriteLine($"Category now: {book1.Theme}");
                book1.ChangeTheme("Drama");
                Console.WriteLine($"Category now: {book1.Theme}");

                Console.ReadKey();
            }
        }
    }
}
