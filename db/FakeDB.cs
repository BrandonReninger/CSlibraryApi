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
        public static List<VideoGame> VideoGames = new List<VideoGame>()
        {
            new VideoGame("Halo CE", "XBOX", "M", 59.99m),
            new VideoGame("Battlefield 5", "PS4", "M", 59.99m),
            new VideoGame("No Man's Sky", "PS4", "T", 49.99m),
            new VideoGame("GTA 5", "PS4", "M", 0.00m)
        };
    }
}
