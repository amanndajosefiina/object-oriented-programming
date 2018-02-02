using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAuthor
{
    class Author
    {
        public string AuthorName;
        public string Birthday;
        public string AuthorBook;

        public Author()
        {
            AuthorName = "unknown";
            Birthday = "unknown";
            AuthorBook = "unknown";
        }

        public Author(string authorname, string birthday, string authorbook)
        {
            AuthorName = authorname;
            Birthday = birthday;
            AuthorBook = authorbook;
        }

        public void PrintAuthorInfo()
        {
            Console.Write($"Author: {AuthorName}\nAuthor's birthday: {Birthday}\nBooks: {AuthorBook}");
        }
    }
}
