using System;

namespace LibraryApi
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; private set; }
        public string Id { get; private set; }

        public Book()
        {
            Id = Guid.NewGuid().ToString();
        }

        public Book(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
            Id = Guid.NewGuid().ToString();
        }
    }
}