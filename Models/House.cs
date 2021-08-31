using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
    public class House
    {
        public string Id { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Bedrooms { get; set; }
        [Required]
        [Range(0, int.MaxValue)]

        public int Bathrooms { get; set; }
        [Required]
        [Range(1800, 2021)]

        public int Year { get; set; }
        [Required]
        [Range(1, int.MaxValue)]

        public int Levels { get; set; }
        [Required]
        [Range(0, int.MaxValue)]

        public int Price { get; set; }

    public string Description { get; set; }

        public string ImgUrl { get; set; }

    public House(int bedrooms, int bathrooms, int year, int levels, int price, string description = "Not Provided", string imgUrl = "https://via.placeholder.com/420/0000FF/808080")
    {
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Year = year;
      Levels = levels;
      Price = price;
      Description = description;
      ImgUrl = imgUrl;
      Id = Guid.NewGuid().ToString();
    }
  }
}