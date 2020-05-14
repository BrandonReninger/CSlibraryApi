using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryApi
{
    public class VideoGame
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Platform { get; set; }
        public string Rating { get; set; }
        [Range(1, 100)]
        public decimal Price { get; private set; }
        public string Id { get; private set; }

        public VideoGame()
        {
            Id = Guid.NewGuid().ToString();
        }

        public VideoGame(string title, string platform, string rating, decimal price)
        {
            Title = title;
            Platform = platform;
            Rating = rating;
            Price = price;
            Id = Guid.NewGuid().ToString();
        }
    }
}