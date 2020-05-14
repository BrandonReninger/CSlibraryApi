namespace LibraryApi
{
    public class VideoGame
    {
        public string Title { set; get; }
        public string Platform { get; set; }
        public string Rating { set; get; }
        public decimal Price { set; private get; }

        public VideoGame(string title, string platform, string rating, decimal price)
        {
            Title = title;
            Platform = platform;
            Rating = rating;
            Price = price;
        }
    }
}