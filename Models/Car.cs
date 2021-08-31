using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
    public class Car
    {
        public string Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Modal { get; set; }
        [Required]
        [Range(0, 2021)]
        public int Year { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public Car(string make, string modal, int year, int price, string description = "Not Provided", string imgUrl = "https://via.placeholder.com/420/0000FF/808080")
        {
          Make = make;
          Modal = modal;
          Year = year;
          Price = price;
          Description = description;
          ImgUrl = imgUrl;
          Id = Guid.NewGuid().ToString();
    }
  }
}