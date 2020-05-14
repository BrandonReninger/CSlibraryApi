using System;

namespace LibraryApi
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; private set; }

        public Book(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }
    }
}