using System.Collections.Generic;

namespace LibraryApi
{
    public static class FakeDB
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book("MossFlower", "Brian Jacques", true),
            new Book("The Odyssey", "Homer", true),
            new Book("The Road", "Cormac McCarthy", true),
            new Book("DreamCatcher", "Steven King", true)
        };
    }
}
